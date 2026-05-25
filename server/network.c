#include "server.h"
#include <stdarg.h>

// ========================================================================
// Packet building helper
// ========================================================================

static int pkt_append(char *buf, int pos, int bufsize, const char *fmt, ...)
{
    char tmp[512];
    va_list ap;
    va_start(ap, fmt);
    int n = vsnprintf(tmp, sizeof(tmp), fmt, ap);
    va_end(ap);

    if (n < 0 || pos + n + 1 >= bufsize)
        return pos;

    // Add SEP_CHAR before this field if we are not at position 0
    if (pos > 0) {
        buf[pos] = SEP_CHAR;
        pos++;
    }
    memcpy(buf + pos, tmp, n);
    pos += n;
    return pos;
}

// Finalize packet: add trailing SEP_CHAR then END_CHAR
static int pkt_end(char *buf, int pos, int bufsize)
{
    if (pos + 2 >= bufsize) return pos;
    buf[pos++] = SEP_CHAR;
    buf[pos++] = (char)END_CHAR;
    return pos;
}

// Quick packet builder macros
#define PKT_INIT(buf) int _pos = 0; char buf[BUFFER_SIZE]
#define PKT_S(buf, s)       do { _pos = pkt_append(buf, _pos, sizeof(buf), "%s", (s)); } while(0)
#define PKT_I(buf, v)       do { _pos = pkt_append(buf, _pos, sizeof(buf), "%d", (int)(v)); } while(0)
#define PKT_END(buf)        do { _pos = pkt_end(buf, _pos, sizeof(buf)); } while(0)
#define PKT_LEN             _pos

// ========================================================================
// Connection checks
// ========================================================================

int IsConnected(int Index)
{
    if (Index < 1 || Index > MAX_PLAYERS) return 0;
    return (Player[Index].socket_fd > 0) ? 1 : 0;
}

int IsPlaying(int Index)
{
    if (IsConnected(Index) && Player[Index].InGame)
        return 1;
    return 0;
}

int IsLoggedIn(int Index)
{
    if (IsConnected(Index)) {
        char tmp[NAME_LENGTH + 1];
        strlcpy_safe(tmp, Player[Index].Login, sizeof(tmp));
        str_trim(tmp);
        if (tmp[0] != '\0')
            return 1;
    }
    return 0;
}

int IsMultiAccounts(const char *Login)
{
    char a[NAME_LENGTH + 1], b[NAME_LENGTH + 1];
    strlcpy_safe(a, Login, sizeof(a));
    str_trim(a);
    to_lower(a);

    for (int i = 1; i <= MAX_PLAYERS; i++) {
        if (IsConnected(i)) {
            strlcpy_safe(b, Player[i].Login, sizeof(b));
            str_trim(b);
            to_lower(b);
            if (strcmp(a, b) == 0)
                return 1;
        }
    }
    return 0;
}

int IsMultiIPOnline(const char *IP)
{
    int n = 0;
    char a[46], b[46];
    strlcpy_safe(a, IP, sizeof(a));
    str_trim(a);

    for (int i = 1; i <= MAX_PLAYERS; i++) {
        if (IsConnected(i)) {
            strlcpy_safe(b, GetPlayerIP(i), sizeof(b));
            str_trim(b);
            if (strcmp(a, b) == 0) {
                n++;
                if (n > 1) return 1;
            }
        }
    }
    return 0;
}

int IsBanned(const char *IP)
{
    char path[600];
    snprintf(path, sizeof(path), "%s/banlist.txt", app_path);

    FILE *f = fopen(path, "r");
    if (!f) return 0;

    char fIP[256], fName[256];
    while (fscanf(f, " %255[^,], %255[^\n]", fIP, fName) == 2) {
        str_trim(fIP);
        // prefix match: compare first len(fIP) chars of IP
        size_t flen = strlen(fIP);
        if (flen > 0 && strncasecmp(IP, fIP, flen) == 0) {
            fclose(f);
            return 1;
        }
    }
    fclose(f);
    return 0;
}

// ========================================================================
// Data sending
// ========================================================================

void SendDataTo(int Index, const char *Data)
{
    if (!IsConnected(Index)) return;

    // Find END_CHAR to determine length
    const char *end = memchr(Data, (unsigned char)END_CHAR, BUFFER_SIZE);
    if (!end) return;

    int len = (int)(end - Data) + 1;
    send(Player[Index].socket_fd, Data, len, MSG_NOSIGNAL);
}

void SendDataToAll(const char *Data)
{
    for (int i = 1; i <= MAX_PLAYERS; i++) {
        if (IsPlaying(i))
            SendDataTo(i, Data);
    }
}

void SendDataToAllBut(int Index, const char *Data)
{
    for (int i = 1; i <= MAX_PLAYERS; i++) {
        if (IsPlaying(i) && i != Index)
            SendDataTo(i, Data);
    }
}

void SendDataToMap(int MapNum, const char *Data)
{
    for (int i = 1; i <= MAX_PLAYERS; i++) {
        if (IsPlaying(i) && GetPlayerMap(i) == MapNum)
            SendDataTo(i, Data);
    }
}

void SendDataToMapBut(int Index, int MapNum, const char *Data)
{
    for (int i = 1; i <= MAX_PLAYERS; i++) {
        if (IsPlaying(i) && GetPlayerMap(i) == MapNum && i != Index)
            SendDataTo(i, Data);
    }
}

// ========================================================================
// Message functions
// ========================================================================

void GlobalMsg(const char *Msg, uint8_t Color)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "GLOBALMSG"); PKT_S(pkt, Msg); PKT_I(pkt, Color); PKT_END(pkt);
    SendDataToAll(pkt);
}

void AdminMsg(const char *Msg, uint8_t Color)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "ADMINMSG"); PKT_S(pkt, Msg); PKT_I(pkt, Color); PKT_END(pkt);

    for (int i = 1; i <= MAX_PLAYERS; i++) {
        if (IsPlaying(i) && GetPlayerAccess(i) > 0)
            SendDataTo(i, pkt);
    }
}

void PlayerMsg(int Index, const char *Msg, uint8_t Color)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "PLAYERMSG"); PKT_S(pkt, Msg); PKT_I(pkt, Color); PKT_END(pkt);
    SendDataTo(Index, pkt);
}

void MapMsg(int MapNum, const char *Msg, uint8_t Color)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "MAPMSG"); PKT_S(pkt, Msg); PKT_I(pkt, Color); PKT_END(pkt);
    SendDataToMap(MapNum, pkt);
}

void AlertMsg(int Index, const char *Msg)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "ALERTMSG"); PKT_S(pkt, Msg); PKT_END(pkt);
    SendDataTo(Index, pkt);
    CloseSocket(Index);
}

void HackingAttempt(int Index, const char *Reason)
{
    if (Index > 0) {
        if (IsPlaying(Index)) {
            char msg[512];
            snprintf(msg, sizeof(msg), "%s/%s has been booted for (%s)",
                     GetPlayerLogin(Index), GetPlayerName(Index), Reason);
            GlobalMsg(msg, White);
        }
        AlertMsg(Index, "You have lost your connection with " GAME_NAME ".");
    }
}

// ========================================================================
// Accept / Connect / Close
// ========================================================================

void AcceptConnection(void)
{
    struct sockaddr_in addr;
    socklen_t addrlen = sizeof(addr);

    int new_fd = accept(listen_fd, (struct sockaddr *)&addr, &addrlen);
    if (new_fd < 0) return;

    int i = FindOpenPlayerSlot();
    if (i == 0) {
        close(new_fd);
        return;
    }

    // Set non-blocking
    int flags = fcntl(new_fd, F_GETFL, 0);
    if (flags >= 0) fcntl(new_fd, F_SETFL, flags | O_NONBLOCK);

    ClearPlayer(i);
    Player[i].socket_fd = new_fd;
    inet_ntop(AF_INET, &addr.sin_addr, Player[i].remote_ip, sizeof(Player[i].remote_ip));

    SocketConnected(i);
}

void SocketConnected(int Index)
{
    if (Index != 0) {
        if (!IsBanned(GetPlayerIP(Index))) {
            char msg[256];
            snprintf(msg, sizeof(msg), "Received connection from %s.", GetPlayerIP(Index));
            text_add(msg);
        } else {
            AlertMsg(Index, "You have been banned from " GAME_NAME ", and can no longer play.");
        }
    }
}

void CloseSocket(int Index)
{
    if (Index > 0) {
        LeftGame(Index);

        char msg[256];
        snprintf(msg, sizeof(msg), "Connection from %s has been terminated.", GetPlayerIP(Index));
        text_add(msg);

        if (Player[Index].socket_fd > 0) {
            close(Player[Index].socket_fd);
        }

        UpdateCaption();
        ClearPlayer(Index);
    }
}

void UpdateCaption(void)
{
    printf("[%s] Online Players: %d\n", GAME_NAME, TotalOnlinePlayers());
}

// ========================================================================
// Incoming data
// ========================================================================

void IncomingData(int Index)
{
    if (Index <= 0) return;

    char buf[BUFFER_SIZE];
    int nbytes = recv(Player[Index].socket_fd, buf, sizeof(buf) - 1, 0);

    if (nbytes <= 0) {
        if (nbytes == 0 || (errno != EAGAIN && errno != EWOULDBLOCK)) {
            CloseSocket(Index);
        }
        return;
    }

    // Check for "top" query
    if (nbytes == 3 && memcmp(buf, "top", 3) == 0) {
        char top[4];
        snprintf(top, sizeof(top), "%d", TotalOnlinePlayers());
        send(Player[Index].socket_fd, top, strlen(top), MSG_NOSIGNAL);
        CloseSocket(Index);
        return;
    }

    // Append to player buffer
    int curlen = 0;
    // Find current length of IncBuffer (binary safe - scan for how much data is there)
    // We use a separate length tracker via Buffer field. Actually, let's use strlen
    // carefully. Since buffer may contain nulls (SEP_CHAR), we need to track length.
    // We'll store current buffer length in DataBytes temporarily... Actually,
    // let's use a simpler approach: track the used length via scanning for unused area.
    // The VB6 code uses string concatenation. We'll scan for the END_CHAR to find packets.

    // We need to track buffer fill level. Let's use a convention:
    // Player[Index].Buffer stores data, and we track its length.
    // Since C strings can't hold nulls easily, we'll use IncBuffer as overflow
    // and track lengths with pointer math. Let's just use a static approach:
    // Store current buffer length in the first 4 bytes as an int, data starts at offset 4.

    // Simpler: use the Player[Index].Buffer with memmove. Track length with a simple
    // approach - put a sentinel at the end. Actually let's just keep a running offset
    // encoded at the beginning of Buffer.

    // Let's be pragmatic: store buffer length in DataBytes field (repurpose temporarily no,
    // DataBytes is used for flood protection). We'll add the length as first 4 bytes of Buffer.

    int *buflen_ptr = (int *)Player[Index].Buffer;
    int buflen = *buflen_ptr;
    char *bufdata = Player[Index].Buffer + sizeof(int);
    int bufcap = BUFFER_SIZE - (int)sizeof(int);

    if (buflen < 0 || buflen > bufcap) buflen = 0;

    if (buflen + nbytes > bufcap) {
        // Buffer overflow, disconnect
        HackingAttempt(Index, "Buffer Overflow");
        return;
    }

    memcpy(bufdata + buflen, buf, nbytes);
    buflen += nbytes;

    // Extract packets delimited by END_CHAR
    int start = 0;
    while (start < buflen) {
        // Find END_CHAR
        int found = -1;
        for (int j = start; j < buflen; j++) {
            if ((unsigned char)bufdata[j] == (unsigned char)END_CHAR) {
                found = j;
                break;
            }
        }
        if (found < 0) break;

        int pktlen = found - start;
        Player[Index].DataPackets++;

        if (pktlen > 0) {
            // Copy packet data (without END_CHAR) for processing
            char *pktdata = malloc(pktlen + 1);
            if (pktdata) {
                memcpy(pktdata, bufdata + start, pktlen);
                pktdata[pktlen] = '\0';
                *(int *)Player[Index].IncBuffer = pktlen;
                HandleData(Index, pktdata);
                free(pktdata);
            }
        }

        start = found + 1;
    }

    // Shift remaining data
    if (start > 0 && start < buflen) {
        memmove(bufdata, bufdata + start, buflen - start);
        buflen -= start;
    } else if (start >= buflen) {
        buflen = 0;
    }
    *buflen_ptr = buflen;

    // Flood protection
    Player[Index].DataBytes += nbytes;
    if (GetTickCount() >= Player[Index].DataTimer + 1000) {
        Player[Index].DataTimer = GetTickCount();
        Player[Index].DataBytes = 0;
        Player[Index].DataPackets = 0;
        return;
    }

    if (Player[Index].DataBytes > 1000 && GetPlayerAccess(Index) <= 0) {
        HackingAttempt(Index, "Data Flooding");
        return;
    }

    if (Player[Index].DataPackets > 25 && GetPlayerAccess(Index) <= 0) {
        HackingAttempt(Index, "Packet Flooding");
        return;
    }
}

// ========================================================================
// HandleData - packet router
// ========================================================================

// Helper: parse null-separated fields from binary packet data
// Returns number of fields. parse[] array holds pointers into datacopy.
static int parse_packet(char *datacopy, int datalen, char **parse, int maxparse)
{
    int nparse = 0;
    if (datalen <= 0) return 0;

    parse[0] = datacopy;
    nparse = 1;
    for (int i = 0; i < datalen && nparse < maxparse; i++) {
        if (datacopy[i] == '\0') {
            if (i + 1 < datalen) {
                parse[nparse++] = datacopy + i + 1;
            }
        }
    }
    return nparse;
}

// Helper: validate text for printable ASCII (32-126)
static int validate_text(const char *s)
{
    for (int i = 0; s[i]; i++) {
        unsigned char c = (unsigned char)s[i];
        if (c < 32 || c > 126) return 0;
    }
    return 1;
}

// Helper: validate a name (letters, digits, spaces, underscores)
static int validate_name(const char *name)
{
    for (int i = 0; name[i]; i++) {
        unsigned char c = (unsigned char)name[i];
        if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') ||
            (c == '_') || (c == ' ') || (c >= '0' && c <= '9'))
            continue;
        return 0;
    }
    return 1;
}

void HandleData(int Index, const char *Data)
{
    // We need to figure out the binary length. Since Data was extracted from the buffer
    // with a known length, and the caller null-terminated it, we scan for the first
    // SEP_CHAR to split. But the data may contain embedded nulls as separators.
    // The caller guarantees the packet data is exactly pktlen bytes with a trailing '\0'.
    // We need to pass the actual length. Let's compute it from the original packet extraction.

    // Actually, our HandleData receives Data that was memcpy'd with pktlen bytes
    // and null-terminated. So we need the actual binary length. Let's rework:
    // The caller in IncomingData already allocated pktlen+1 bytes. We need the length.
    // We'll compute it by searching from the end for the actual data length.
    // Better approach: pass length. But the header says HandleData(int, const char*).
    // Since the data contains null separators, strlen won't work.

    // Workaround: encode the length in a global or use the parse approach.
    // The simplest fix: compute datalen by scanning forward for the artificial '\0' we added.
    // But there are embedded '\0's...

    // Actually looking at the VB6 code, Parse = Split(Data, SEP_CHAR) where SEP_CHAR is Chr(0).
    // In VB6, strings can contain nulls. In our C version, the caller stored pktlen bytes
    // then set byte[pktlen] = '\0'. So the total allocation is pktlen+1 bytes.
    // We can get datalen by checking all bytes. But we can't from just a pointer.

    // Practical solution: Since HandleData signature takes const char*, and the data has
    // embedded nulls, we need to know the length. Let's use a trick:
    // Store the length in Player[Index].IncBuffer before calling HandleData.
    // OR, simpler: we'll just scan assuming max BUFFER_SIZE and stop at first END_CHAR or
    // at a reasonable limit. The data should not contain END_CHAR (it was the delimiter).

    // Let's just use strlen on the first field (the command), since the command name
    // has no nulls. Then for subsequent fields, we step past nulls.
    // We know the packet doesn't contain END_CHAR (stripped by IncomingData).

    // We'll reparse from the raw data. We need the packet length though.
    // The caller stores it... let's look at IncomingData. pktdata[pktlen] = '\0'
    // So we need to find pktlen. Since the data has embedded NULs, we can't use strlen.

    // REVISED APPROACH: Let's read the length from IncBuffer where IncomingData stashes it.
    // OR we can just estimate: scan up to BUFFER_SIZE bytes looking for the pattern end.
    // The safest is to find the extent by checking the malloc'd block size, but that's not
    // portable. Let's just use a practical upper bound and handle it.

    // The simplest correct approach: the packet is null-separated fields. The first field
    // is the command (no nulls). After that, each null byte is a separator. We'll parse
    // up to BUFFER_SIZE bytes, stopping when we hit areas that look like uninitialized memory.
    // Since malloc+memcpy was used, the data is exactly pktlen bytes followed by one '\0'.

    // Best approach: We compute the total data extent by finding the furthest non-null byte.
    // But that's fragile. Instead, let's just modify IncomingData to store length in IncBuffer.
    // Actually, let's change HandleData to work with the length stored in IncBuffer.

    // PRAGMATIC: we store the packet length in Player[Index].IncBuffer as an int before call.
    int datalen = *(int *)Player[Index].IncBuffer;
    if (datalen <= 0 || datalen > BUFFER_SIZE) return;

    char *datacopy = malloc(datalen + 1);
    if (!datacopy) return;
    memcpy(datacopy, Data, datalen);
    datacopy[datalen] = '\0';

    char *parse[256];
    int nparse = parse_packet(datacopy, datalen, parse, 256);

    if (nparse < 1) { free(datacopy); return; }

    // Make lowercase copy of command
    char cmd[64];
    strlcpy_safe(cmd, parse[0], sizeof(cmd));
    to_lower(cmd);

    // Helper macro to safely get parse fields
    #define P(n) ((n) < nparse ? parse[n] : "")
    #define PVAL(n) ((n) < nparse ? atoi(parse[n]) : 0)

    // ==========================================
    // getclasses
    // ==========================================
    if (strcmp(cmd, "getclasses") == 0) {
        if (!IsPlaying(Index))
            SendNewCharClasses(Index);
        goto done;
    }

    // ==========================================
    // newaccount
    // ==========================================
    if (strcmp(cmd, "newaccount") == 0) {
        if (!IsPlaying(Index) && !IsLoggedIn(Index)) {
            const char *Name = P(1);
            const char *Password = P(2);

            char tname[NAME_LENGTH+1], tpass[NAME_LENGTH+1];
            strlcpy_safe(tname, Name, sizeof(tname));
            strlcpy_safe(tpass, Password, sizeof(tpass));
            str_trim(tname);
            str_trim(tpass);

            if (strlen(tname) < 3 || strlen(tpass) < 3) {
                AlertMsg(Index, "Your name and password must be at least three characters in length");
                goto done;
            }

            if (!validate_name(tname)) {
                AlertMsg(Index, "Invalid name, only letters, numbers, spaces, and _ allowed in names.");
                goto done;
            }

            if (!AccountExist(tname)) {
                AddAccount(Index, tname, tpass);
                text_add("Account has been created.");
                char logmsg[256];
                snprintf(logmsg, sizeof(logmsg), "Account %s has been created.", tname);
                AddLog(logmsg, PLAYER_LOG);
                AlertMsg(Index, "Your account has been created!");
            } else {
                AlertMsg(Index, "Sorry, that account name is already taken!");
            }
        }
        goto done;
    }

    // ==========================================
    // delaccount
    // ==========================================
    if (strcmp(cmd, "delaccount") == 0) {
        if (!IsPlaying(Index) && !IsLoggedIn(Index)) {
            const char *Name = P(1);
            const char *Password = P(2);

            char tname[NAME_LENGTH+1], tpass[NAME_LENGTH+1];
            strlcpy_safe(tname, Name, sizeof(tname));
            strlcpy_safe(tpass, Password, sizeof(tpass));
            str_trim(tname);
            str_trim(tpass);

            if (strlen(tname) < 3 || strlen(tpass) < 3) {
                AlertMsg(Index, "The name and password must be at least three characters in length");
                goto done;
            }

            if (!AccountExist(tname)) {
                AlertMsg(Index, "That account name does not exist.");
                goto done;
            }

            if (!PasswordOK(tname, tpass)) {
                AlertMsg(Index, "Incorrect password.");
                goto done;
            }

            // Delete names from master name file
            LoadPlayer(Index, tname);
            for (int i = 1; i <= MAX_CHARS; i++) {
                char cname[NAME_LENGTH+1];
                strlcpy_safe(cname, Player[Index].Char[i].Name, sizeof(cname));
                str_trim(cname);
                if (cname[0] != '\0')
                    DeleteName(cname);
            }
            ClearPlayer(Index);

            // Delete the account file
            char fpath[600];
            snprintf(fpath, sizeof(fpath), "%s/accounts/%s.ini", app_path, tname);
            remove(fpath);

            char logmsg[256];
            snprintf(logmsg, sizeof(logmsg), "Account %s has been deleted.", tname);
            AddLog(logmsg, PLAYER_LOG);
            AlertMsg(Index, "Your account has been deleted.");
        }
        goto done;
    }

    // ==========================================
    // login
    // ==========================================
    if (strcmp(cmd, "login") == 0) {
        if (!IsPlaying(Index) && !IsLoggedIn(Index)) {
            const char *Name = P(1);
            const char *Password = P(2);

            // Check versions
            if (PVAL(3) < CLIENT_MAJOR || PVAL(4) < CLIENT_MINOR || PVAL(5) < CLIENT_REVISION) {
                AlertMsg(Index, "Version outdated, please visit the website for updates.");
                goto done;
            }

            char tname[NAME_LENGTH+1], tpass[NAME_LENGTH+1];
            strlcpy_safe(tname, Name, sizeof(tname));
            strlcpy_safe(tpass, Password, sizeof(tpass));
            str_trim(tname);
            str_trim(tpass);

            if (strlen(tname) < 3 || strlen(tpass) < 3) {
                AlertMsg(Index, "Your name and password must be at least three characters in length");
                goto done;
            }

            if (!AccountExist(tname)) {
                AlertMsg(Index, "That account name does not exist.");
                goto done;
            }

            if (!PasswordOK(tname, tpass)) {
                AlertMsg(Index, "Incorrect password.");
                goto done;
            }

            if (IsMultiAccounts(tname)) {
                AlertMsg(Index, "Multiple account logins is not authorized.");
                goto done;
            }

            LoadPlayer(Index, tname);
            SendChars(Index);

            char logmsg[256];
            snprintf(logmsg, sizeof(logmsg), "%s has logged in from %s.", GetPlayerLogin(Index), GetPlayerIP(Index));
            AddLog(logmsg, PLAYER_LOG);
            text_add(logmsg);
        }
        goto done;
    }

    // ==========================================
    // addchar
    // ==========================================
    if (strcmp(cmd, "addchar") == 0) {
        if (!IsPlaying(Index)) {
            const char *Name = P(1);
            int Sex = PVAL(2);
            int ClassNum = PVAL(3);
            int CharNum = PVAL(4);

            char tname[NAME_LENGTH+1];
            strlcpy_safe(tname, Name, sizeof(tname));
            str_trim(tname);

            if (strlen(tname) < 3) {
                AlertMsg(Index, "Character name must be at least three characters in length.");
                goto done;
            }

            if (!validate_name(tname)) {
                AlertMsg(Index, "Invalid name, only letters, numbers, spaces, and _ allowed in names.");
                goto done;
            }

            if (CharNum < 1 || CharNum > MAX_CHARS) {
                HackingAttempt(Index, "Invalid CharNum");
                goto done;
            }

            if (Sex < SEX_MALE || Sex > SEX_FEMALE) {
                HackingAttempt(Index, "Invalid Sex");
                goto done;
            }

            if (ClassNum < 0 || ClassNum > Max_Classes) {
                HackingAttempt(Index, "Invalid Class");
                goto done;
            }

            if (CharExist(Index, CharNum)) {
                AlertMsg(Index, "Character already exists!");
                goto done;
            }

            if (FindChar(tname)) {
                AlertMsg(Index, "Sorry, but that name is in use!");
                goto done;
            }

            AddChar(Index, tname, Sex, ClassNum, CharNum);
            SavePlayer(Index);

            char logmsg[256];
            snprintf(logmsg, sizeof(logmsg), "Character %s added to %s's account.", tname, GetPlayerLogin(Index));
            AddLog(logmsg, PLAYER_LOG);
            AlertMsg(Index, "Character has been created!");
        }
        goto done;
    }

    // ==========================================
    // delchar
    // ==========================================
    if (strcmp(cmd, "delchar") == 0) {
        if (!IsPlaying(Index)) {
            int CharNum = PVAL(1);

            if (CharNum < 1 || CharNum > MAX_CHARS) {
                HackingAttempt(Index, "Invalid CharNum");
                goto done;
            }

            DelChar(Index, CharNum);
            char logmsg[256];
            snprintf(logmsg, sizeof(logmsg), "Character deleted on %s's account.", GetPlayerLogin(Index));
            AddLog(logmsg, PLAYER_LOG);
            AlertMsg(Index, "Character has been deleted!");
        }
        goto done;
    }

    // ==========================================
    // usechar
    // ==========================================
    if (strcmp(cmd, "usechar") == 0) {
        if (!IsPlaying(Index)) {
            int CharNum = PVAL(1);

            if (CharNum < 1 || CharNum > MAX_CHARS) {
                HackingAttempt(Index, "Invalid CharNum");
                goto done;
            }

            if (CharExist(Index, CharNum)) {
                Player[Index].CharNum = CharNum;
                JoinGame(Index);

                char logmsg[256];
                snprintf(logmsg, sizeof(logmsg), "%s/%s has began playing %s.",
                         GetPlayerLogin(Index), GetPlayerName(Index), GAME_NAME);
                AddLog(logmsg, PLAYER_LOG);
                text_add(logmsg);
                UpdateCaption();

                // Add to charlist if not already there
                if (!FindChar(GetPlayerName(Index))) {
                    char clpath[600];
                    snprintf(clpath, sizeof(clpath), "%s/accounts/charlist.txt", app_path);
                    FILE *f = fopen(clpath, "a");
                    if (f) {
                        fprintf(f, "%s\n", GetPlayerName(Index));
                        fclose(f);
                    }
                }
            } else {
                AlertMsg(Index, "Character does not exist!");
            }
        }
        goto done;
    }

    // ==========================================
    // saymsg
    // ==========================================
    if (strcmp(cmd, "saymsg") == 0) {
        const char *Msg = P(1);
        if (!validate_text(Msg)) { HackingAttempt(Index, "Say Text Modification"); goto done; }

        char logmsg[512], s[512];
        snprintf(logmsg, sizeof(logmsg), "Map #%d: %s says, '%s'", GetPlayerMap(Index), GetPlayerName(Index), Msg);
        AddLog(logmsg, PLAYER_LOG);
        snprintf(s, sizeof(s), "%s says, '%s'", GetPlayerName(Index), Msg);
        MapMsg(GetPlayerMap(Index), s, SayColor);
        goto done;
    }

    // ==========================================
    // emotemsg
    // ==========================================
    if (strcmp(cmd, "emotemsg") == 0) {
        const char *Msg = P(1);
        if (!validate_text(Msg)) { HackingAttempt(Index, "Emote Text Modification"); goto done; }

        char logmsg[512], s[512];
        snprintf(logmsg, sizeof(logmsg), "Map #%d: %s %s", GetPlayerMap(Index), GetPlayerName(Index), Msg);
        AddLog(logmsg, PLAYER_LOG);
        snprintf(s, sizeof(s), "%s %s", GetPlayerName(Index), Msg);
        MapMsg(GetPlayerMap(Index), s, EmoteColor);
        goto done;
    }

    // ==========================================
    // broadcastmsg
    // ==========================================
    if (strcmp(cmd, "broadcastmsg") == 0) {
        const char *Msg = P(1);
        if (!validate_text(Msg)) { HackingAttempt(Index, "Broadcast Text Modification"); goto done; }

        char s[512];
        snprintf(s, sizeof(s), "%s: %s", GetPlayerName(Index), Msg);
        AddLog(s, PLAYER_LOG);
        GlobalMsg(s, BroadcastColor);
        text_add(s);
        goto done;
    }

    // ==========================================
    // globalmsg
    // ==========================================
    if (strcmp(cmd, "globalmsg") == 0) {
        const char *Msg = P(1);
        if (!validate_text(Msg)) { HackingAttempt(Index, "Global Text Modification"); goto done; }

        if (GetPlayerAccess(Index) > 0) {
            char s[512];
            snprintf(s, sizeof(s), "(global) %s: %s", GetPlayerName(Index), Msg);
            AddLog(s, ADMIN_LOG);
            GlobalMsg(s, GlobalColor);
            text_add(s);
        }
        goto done;
    }

    // ==========================================
    // adminmsg
    // ==========================================
    if (strcmp(cmd, "adminmsg") == 0) {
        const char *Msg = P(1);
        if (!validate_text(Msg)) { HackingAttempt(Index, "Admin Text Modification"); goto done; }

        if (GetPlayerAccess(Index) > 0) {
            char s[512];
            snprintf(s, sizeof(s), "(admin %s) %s", GetPlayerName(Index), Msg);
            AddLog(s, ADMIN_LOG);
            AdminMsg(s, AdminColor);
        }
        goto done;
    }

    // ==========================================
    // playermsg
    // ==========================================
    if (strcmp(cmd, "playermsg") == 0) {
        int MsgTo = FindPlayer(P(1));
        const char *Msg = P(2);
        if (!validate_text(Msg)) { HackingAttempt(Index, "Player Msg Text Modification"); goto done; }

        if (MsgTo != Index) {
            if (MsgTo > 0) {
                char logmsg[512], s1[512], s2[512];
                snprintf(logmsg, sizeof(logmsg), "%s tells %s, %s'", GetPlayerName(Index), GetPlayerName(MsgTo), Msg);
                AddLog(logmsg, PLAYER_LOG);
                snprintf(s1, sizeof(s1), "%s tells you, '%s'", GetPlayerName(Index), Msg);
                PlayerMsg(MsgTo, s1, TellColor);
                snprintf(s2, sizeof(s2), "You tell %s, '%s'", GetPlayerName(MsgTo), Msg);
                PlayerMsg(Index, s2, TellColor);
            } else {
                PlayerMsg(Index, "Player is not online.", White);
            }
        } else {
            char s[512];
            snprintf(s, sizeof(s), "%s begins to mumble to himself, what a wierdo...", GetPlayerName(Index));
            char logmsg[512];
            snprintf(logmsg, sizeof(logmsg), "Map #%d: %s", GetPlayerMap(Index), s);
            AddLog(logmsg, PLAYER_LOG);
            MapMsg(GetPlayerMap(Index), s, Green);
        }
        goto done;
    }

    // ==========================================
    // playermove
    // ==========================================
    if (strcmp(cmd, "playermove") == 0 && Player[Index].GettingMap == NO) {
        int Dir = PVAL(1);
        int Movement = PVAL(2);

        if (Dir < DIR_UP || Dir > DIR_RIGHT) { HackingAttempt(Index, "Invalid Direction"); goto done; }
        if (Movement < 1 || Movement > 2) { HackingAttempt(Index, "Invalid Movement"); goto done; }

        // Check if spell was cast
        if (Player[Index].CastedSpell == YES) {
            if (GetTickCount() > Player[Index].AttackTimer + 1000) {
                Player[Index].CastedSpell = NO;
            } else {
                SendPlayerXY(Index);
                goto done;
            }
        }

        PlayerMove(Index, Dir, Movement);
        goto done;
    }

    // ==========================================
    // playerdir
    // ==========================================
    if (strcmp(cmd, "playerdir") == 0 && Player[Index].GettingMap == NO) {
        int Dir = PVAL(1);
        if (Dir < DIR_UP || Dir > DIR_RIGHT) { HackingAttempt(Index, "Invalid Direction"); goto done; }

        SetPlayerDir(Index, Dir);

        PKT_INIT(pkt);
        PKT_S(pkt, "PLAYERDIR"); PKT_I(pkt, Index); PKT_I(pkt, GetPlayerDir(Index)); PKT_END(pkt);
        SendDataToMapBut(Index, GetPlayerMap(Index), pkt);
        goto done;
    }

    // ==========================================
    // useitem
    // ==========================================
    if (strcmp(cmd, "useitem") == 0) {
        int InvNum = PVAL(1);
        int CharNum = Player[Index].CharNum;

        if (InvNum < 1 || InvNum > MAX_INV) { HackingAttempt(Index, "Invalid InvNum"); goto done; }
        if (CharNum < 1 || CharNum > MAX_CHARS) { HackingAttempt(Index, "Invalid CharNum"); goto done; }

        int itemNum = GetPlayerInvItemNum(Index, InvNum);
        if (itemNum > 0 && itemNum <= MAX_ITEMS) {
            int n = Item_[itemNum].Data2;

            switch (Item_[itemNum].Type) {
                case ITEM_TYPE_ARMOR:
                    if (InvNum != GetPlayerArmorSlot(Index)) {
                        if (GetPlayerDEF(Index) < n) {
                            char msg[256];
                            snprintf(msg, sizeof(msg), "Your defense is to low to wear this armor!  Required DEF (%d)", n * 2);
                            PlayerMsg(Index, msg, BrightRed);
                            goto done;
                        }
                        SetPlayerArmorSlot(Index, InvNum);
                    } else {
                        SetPlayerArmorSlot(Index, 0);
                    }
                    SendWornEquipment(Index);
                    break;

                case ITEM_TYPE_WEAPON:
                    if (InvNum != GetPlayerWeaponSlot(Index)) {
                        if (GetPlayerSTR(Index) < n) {
                            char msg[256];
                            snprintf(msg, sizeof(msg), "Your strength is to low to hold this weapon!  Required STR (%d)", n * 2);
                            PlayerMsg(Index, msg, BrightRed);
                            goto done;
                        }
                        SetPlayerWeaponSlot(Index, InvNum);
                    } else {
                        SetPlayerWeaponSlot(Index, 0);
                    }
                    SendWornEquipment(Index);
                    break;

                case ITEM_TYPE_HELMET:
                    if (InvNum != GetPlayerHelmetSlot(Index)) {
                        if (GetPlayerSPEED(Index) < n) {
                            char msg[256];
                            snprintf(msg, sizeof(msg), "Your speed coordination is to low to wear this helmet!  Required SPEED (%d)", n * 2);
                            PlayerMsg(Index, msg, BrightRed);
                            goto done;
                        }
                        SetPlayerHelmetSlot(Index, InvNum);
                    } else {
                        SetPlayerHelmetSlot(Index, 0);
                    }
                    SendWornEquipment(Index);
                    break;

                case ITEM_TYPE_SHIELD:
                    if (InvNum != GetPlayerShieldSlot(Index)) {
                        SetPlayerShieldSlot(Index, InvNum);
                    } else {
                        SetPlayerShieldSlot(Index, 0);
                    }
                    SendWornEquipment(Index);
                    break;

                case ITEM_TYPE_POTIONADDHP:
                    SetPlayerHP(Index, GetPlayerHP(Index) + Item_[Player[Index].Char[CharNum].Inv[InvNum].Num].Data1);
                    TakeItem_(Index, Player[Index].Char[CharNum].Inv[InvNum].Num, 0);
                    SendHP(Index);
                    break;

                case ITEM_TYPE_POTIONADDMP:
                    SetPlayerMP(Index, GetPlayerMP(Index) + Item_[Player[Index].Char[CharNum].Inv[InvNum].Num].Data1);
                    TakeItem_(Index, Player[Index].Char[CharNum].Inv[InvNum].Num, 0);
                    SendMP(Index);
                    break;

                case ITEM_TYPE_POTIONADDSP:
                    SetPlayerSP(Index, GetPlayerSP(Index) + Item_[Player[Index].Char[CharNum].Inv[InvNum].Num].Data1);
                    TakeItem_(Index, Player[Index].Char[CharNum].Inv[InvNum].Num, 0);
                    SendSP(Index);
                    break;

                case ITEM_TYPE_POTIONSUBHP:
                    SetPlayerHP(Index, GetPlayerHP(Index) - Item_[Player[Index].Char[CharNum].Inv[InvNum].Num].Data1);
                    TakeItem_(Index, Player[Index].Char[CharNum].Inv[InvNum].Num, 0);
                    SendHP(Index);
                    break;

                case ITEM_TYPE_POTIONSUBMP:
                    SetPlayerMP(Index, GetPlayerMP(Index) - Item_[Player[Index].Char[CharNum].Inv[InvNum].Num].Data1);
                    TakeItem_(Index, Player[Index].Char[CharNum].Inv[InvNum].Num, 0);
                    SendMP(Index);
                    break;

                case ITEM_TYPE_POTIONSUBSP:
                    SetPlayerSP(Index, GetPlayerSP(Index) - Item_[Player[Index].Char[CharNum].Inv[InvNum].Num].Data1);
                    TakeItem_(Index, Player[Index].Char[CharNum].Inv[InvNum].Num, 0);
                    SendSP(Index);
                    break;

                case ITEM_TYPE_KEY: {
                    int x = 0, y = 0;
                    switch (GetPlayerDir(Index)) {
                        case DIR_UP:
                            if (GetPlayerY(Index) > 0) { x = GetPlayerX(Index); y = GetPlayerY(Index) - 1; }
                            else goto done;
                            break;
                        case DIR_DOWN:
                            if (GetPlayerY(Index) < MAX_MAPY) { x = GetPlayerX(Index); y = GetPlayerY(Index) + 1; }
                            else goto done;
                            break;
                        case DIR_LEFT:
                            if (GetPlayerX(Index) > 0) { x = GetPlayerX(Index) - 1; y = GetPlayerY(Index); }
                            else goto done;
                            break;
                        case DIR_RIGHT:
                            if (GetPlayerX(Index) < MAX_MAPX) { x = GetPlayerX(Index) + 1; y = GetPlayerY(Index); }
                            else goto done;
                            break;
                    }

                    int pmap = GetPlayerMap(Index);
                    if (Map_[pmap].Tile[x][y].Type == TILE_TYPE_KEY) {
                        if (GetPlayerInvItemNum(Index, InvNum) == Map_[pmap].Tile[x][y].Data1) {
                            TempTile[pmap].DoorOpen[x][y] = YES;
                            TempTile[pmap].DoorTimer = GetTickCount();

                            PKT_INIT(kpkt);
                            PKT_S(kpkt, "MAPKEY"); PKT_I(kpkt, x); PKT_I(kpkt, y); PKT_I(kpkt, 1); PKT_END(kpkt);
                            SendDataToMap(pmap, kpkt);
                            MapMsg(pmap, "A door has been unlocked.", White);

                            if (Map_[pmap].Tile[x][y].Data2 == 1) {
                                TakeItem_(Index, GetPlayerInvItemNum(Index, InvNum), 0);
                                PlayerMsg(Index, "The key disolves.", Yellow);
                            }
                        }
                    }
                    break;
                }

                case ITEM_TYPE_SPELL: {
                    int spellnum = Item_[GetPlayerInvItemNum(Index, InvNum)].Data1;

                    if (spellnum > 0) {
                        if (Spell_[spellnum].ClassReq - 1 == GetPlayerClass(Index) || Spell_[spellnum].ClassReq == 0) {
                            int reqLvl = GetSpellReqLevel(Index, spellnum);
                            if (reqLvl <= GetPlayerLevel(Index)) {
                                int slot = FindOpenSpellSlot(Index);
                                if (slot > 0) {
                                    if (!HasSpell(Index, spellnum)) {
                                        SetPlayerSpell_(Index, slot, spellnum);
                                        TakeItem_(Index, GetPlayerInvItemNum(Index, InvNum), 0);
                                        PlayerMsg(Index, "You study the spell carefully...", Yellow);
                                        PlayerMsg(Index, "You have learned a new spell!", White);
                                    } else {
                                        TakeItem_(Index, GetPlayerInvItemNum(Index, InvNum), 0);
                                        PlayerMsg(Index, "You have already learned this spell!  The spells crumbles into dust.", BrightRed);
                                    }
                                } else {
                                    PlayerMsg(Index, "You have learned all that you can learn!", BrightRed);
                                }
                            } else {
                                char msg[256];
                                snprintf(msg, sizeof(msg), "You must be level %d to learn this spell.", reqLvl);
                                PlayerMsg(Index, msg, White);
                            }
                        } else {
                            char msg[256];
                            snprintf(msg, sizeof(msg), "This spell can only be learned by a %s.", GetClassName(Spell_[spellnum].ClassReq - 1));
                            PlayerMsg(Index, msg, White);
                        }
                    } else {
                        PlayerMsg(Index, "This scroll is not connected to a spell, please inform an admin!", White);
                    }
                    break;
                }
            }
        }
        goto done;
    }

    // ==========================================
    // attack
    // ==========================================
    if (strcmp(cmd, "attack") == 0) {
        // Try to attack a player
        for (int i = 1; i <= MAX_PLAYERS; i++) {
            if (i != Index) {
                if (CanAttackPlayer(Index, i)) {
                    if (!CanPlayerBlockHit(i)) {
                        int Damage;
                        if (!CanPlayerCriticalHit(Index)) {
                            Damage = GetPlayerDamage(Index) - GetPlayerProtection(i);
                        } else {
                            int n = GetPlayerDamage(Index);
                            Damage = n + (rand() % (n / 2 + 1)) + 1 - GetPlayerProtection(i);
                            PlayerMsg(Index, "You feel a surge of energy upon swinging!", BrightCyan);
                            PlayerMsg(i, "swings with enormous might!", BrightCyan);
                        }
                        if (Damage > 0) {
                            AttackPlayer(Index, i, Damage);
                        } else {
                            PlayerMsg(Index, "Your attack does nothing.", BrightRed);
                        }
                    } else {
                        char msg1[256], msg2[256];
                        snprintf(msg1, sizeof(msg1), "%s's %s has blocked your hit!",
                                 GetPlayerName(i), Item_[GetPlayerInvItemNum(i, GetPlayerShieldSlot(i))].Name);
                        snprintf(msg2, sizeof(msg2), "Your %s has blocked %s's hit!",
                                 Item_[GetPlayerInvItemNum(i, GetPlayerShieldSlot(i))].Name, GetPlayerName(Index));
                        PlayerMsg(Index, msg1, BrightCyan);
                        PlayerMsg(i, msg2, BrightCyan);
                    }
                    goto done;
                }
            }
        }

        // Try to attack an NPC
        for (int i = 1; i <= MAX_MAP_NPCS; i++) {
            if (CanAttackNpc(Index, i)) {
                int Damage;
                if (!CanPlayerCriticalHit(Index)) {
                    Damage = GetPlayerDamage(Index) - (int)(Npc_[MapNpc_[GetPlayerMap(Index)][i].Num].DEF / 2);
                } else {
                    int n = GetPlayerDamage(Index);
                    Damage = n + (rand() % (n / 2 + 1)) + 1 - (int)(Npc_[MapNpc_[GetPlayerMap(Index)][i].Num].DEF / 2);
                    PlayerMsg(Index, "You feel a surge of energy upon swinging!", BrightCyan);
                }
                if (Damage > 0) {
                    AttackNpc(Index, i, Damage);
                } else {
                    PlayerMsg(Index, "Your attack does nothing.", BrightRed);
                }
                goto done;
            }
        }
        goto done;
    }

    // ==========================================
    // usestatpoint
    // ==========================================
    if (strcmp(cmd, "usestatpoint") == 0) {
        int PointType = PVAL(1);
        if (PointType < 0 || PointType > 3) { HackingAttempt(Index, "Invalid Point Type"); goto done; }

        if (GetPlayerPOINTS(Index) > 0) {
            SetPlayerPOINTS(Index, GetPlayerPOINTS(Index) - 1);
            switch (PointType) {
                case 0:
                    SetPlayerSTR(Index, GetPlayerSTR(Index) + 1);
                    PlayerMsg(Index, "You have gained more strength!", White);
                    break;
                case 1:
                    SetPlayerDEF(Index, GetPlayerDEF(Index) + 1);
                    PlayerMsg(Index, "You have gained more defense!", White);
                    break;
                case 2:
                    SetPlayerMAGI(Index, GetPlayerMAGI(Index) + 1);
                    PlayerMsg(Index, "You have gained more magic abilities!", White);
                    break;
                case 3:
                    SetPlayerSPEED(Index, GetPlayerSPEED(Index) + 1);
                    PlayerMsg(Index, "You have gained more speed!", White);
                    break;
            }
        } else {
            PlayerMsg(Index, "You have no skill points to train with!", BrightRed);
        }
        SendStats(Index);
        goto done;
    }

    // ==========================================
    // playerinforequest
    // ==========================================
    if (strcmp(cmd, "playerinforequest") == 0) {
        int i = FindPlayer(P(1));
        if (i > 0) {
            char msg[512];
            snprintf(msg, sizeof(msg), "Account: %s, Name: %s", Player[i].Login, GetPlayerName(i));
            PlayerMsg(Index, msg, BrightGreen);

            if (GetPlayerAccess(Index) > ADMIN_MONITER) {
                snprintf(msg, sizeof(msg), "-=- Stats for %s -=-", GetPlayerName(i));
                PlayerMsg(Index, msg, BrightGreen);
                snprintf(msg, sizeof(msg), "Level: %d  Exp: %d/%d", GetPlayerLevel(i), GetPlayerExp(i), GetPlayerNextLevel(i));
                PlayerMsg(Index, msg, BrightGreen);
                snprintf(msg, sizeof(msg), "HP: %d/%d  MP: %d/%d  SP: %d/%d",
                         GetPlayerHP(i), GetPlayerMaxHP(i), GetPlayerMP(i), GetPlayerMaxMP(i), GetPlayerSP(i), GetPlayerMaxSP(i));
                PlayerMsg(Index, msg, BrightGreen);
                snprintf(msg, sizeof(msg), "STR: %d  DEF: %d  MAGI: %d  SPEED: %d",
                         GetPlayerSTR(i), GetPlayerDEF(i), GetPlayerMAGI(i), GetPlayerSPEED(i));
                PlayerMsg(Index, msg, BrightGreen);
                int cn = GetPlayerSTR(i) / 2 + GetPlayerLevel(i) / 2;
                int ci = GetPlayerDEF(i) / 2 + GetPlayerLevel(i) / 2;
                if (cn > 100) cn = 100;
                if (ci > 100) ci = 100;
                snprintf(msg, sizeof(msg), "Critical Hit Chance: %d%%, Block Chance: %d%%", cn, ci);
                PlayerMsg(Index, msg, BrightGreen);
            }
        } else {
            PlayerMsg(Index, "Player is not online.", White);
        }
        goto done;
    }

    // ==========================================
    // warpmeto
    // ==========================================
    if (strcmp(cmd, "warpmeto") == 0) {
        if (GetPlayerAccess(Index) < ADMIN_MAPPER) { HackingAttempt(Index, "Admin Cloning"); goto done; }

        int n = FindPlayer(P(1));
        if (n != Index) {
            if (n > 0) {
                PlayerWarp(Index, GetPlayerMap(n), GetPlayerX(n), GetPlayerY(n));
                char msg[256];
                snprintf(msg, sizeof(msg), "%s has warped to you.", GetPlayerName(Index));
                PlayerMsg(n, msg, BrightBlue);
                snprintf(msg, sizeof(msg), "You have been warped to %s.", GetPlayerName(n));
                PlayerMsg(Index, msg, BrightBlue);
                snprintf(msg, sizeof(msg), "%s has warped to %s, map #%d.", GetPlayerName(Index), GetPlayerName(n), GetPlayerMap(n));
                AddLog(msg, ADMIN_LOG);
            } else {
                PlayerMsg(Index, "Player is not online.", White);
            }
        } else {
            PlayerMsg(Index, "You cannot warp to yourself!", White);
        }
        goto done;
    }

    // ==========================================
    // warptome
    // ==========================================
    if (strcmp(cmd, "warptome") == 0) {
        if (GetPlayerAccess(Index) < ADMIN_MAPPER) { HackingAttempt(Index, "Admin Cloning"); goto done; }

        int n = FindPlayer(P(1));
        if (n != Index) {
            if (n > 0) {
                PlayerWarp(n, GetPlayerMap(Index), GetPlayerX(Index), GetPlayerY(Index));
                char msg[256];
                snprintf(msg, sizeof(msg), "You have been summoned by %s.", GetPlayerName(Index));
                PlayerMsg(n, msg, BrightBlue);
                snprintf(msg, sizeof(msg), "%s has been summoned.", GetPlayerName(n));
                PlayerMsg(Index, msg, BrightBlue);
                snprintf(msg, sizeof(msg), "%s has warped %s to self, map #%d.", GetPlayerName(Index), GetPlayerName(n), GetPlayerMap(Index));
                AddLog(msg, ADMIN_LOG);
            } else {
                PlayerMsg(Index, "Player is not online.", White);
            }
        } else {
            PlayerMsg(Index, "You cannot warp yourself to yourself!", White);
        }
        goto done;
    }

    // ==========================================
    // warpto
    // ==========================================
    if (strcmp(cmd, "warpto") == 0) {
        if (GetPlayerAccess(Index) < ADMIN_MAPPER) { HackingAttempt(Index, "Admin Cloning"); goto done; }

        int n = PVAL(1);
        if (n < 0 || n > MAX_MAPS) { HackingAttempt(Index, "Invalid map"); goto done; }

        PlayerWarp(Index, n, GetPlayerX(Index), GetPlayerY(Index));
        char msg[256];
        snprintf(msg, sizeof(msg), "You have been warped to map #%d", n);
        PlayerMsg(Index, msg, BrightBlue);
        snprintf(msg, sizeof(msg), "%s warped to map #%d.", GetPlayerName(Index), n);
        AddLog(msg, ADMIN_LOG);
        goto done;
    }

    // ==========================================
    // setsprite
    // ==========================================
    if (strcmp(cmd, "setsprite") == 0) {
        if (GetPlayerAccess(Index) < ADMIN_MAPPER) { HackingAttempt(Index, "Admin Cloning"); goto done; }
        SetPlayerSprite(Index, PVAL(1));
        SendPlayerData(Index);
        goto done;
    }

    // ==========================================
    // getstats
    // ==========================================
    if (strcmp(cmd, "getstats") == 0) {
        char msg[512];
        snprintf(msg, sizeof(msg), "-=- Stats for %s -=-", GetPlayerName(Index));
        PlayerMsg(Index, msg, White);
        snprintf(msg, sizeof(msg), "Level: %d  Exp: %d/%d", GetPlayerLevel(Index), GetPlayerExp(Index), GetPlayerNextLevel(Index));
        PlayerMsg(Index, msg, White);
        snprintf(msg, sizeof(msg), "HP: %d/%d  MP: %d/%d  SP: %d/%d",
                 GetPlayerHP(Index), GetPlayerMaxHP(Index), GetPlayerMP(Index), GetPlayerMaxMP(Index), GetPlayerSP(Index), GetPlayerMaxSP(Index));
        PlayerMsg(Index, msg, White);
        snprintf(msg, sizeof(msg), "STR: %d  DEF: %d  MAGI: %d  SPEED: %d",
                 GetPlayerSTR(Index), GetPlayerDEF(Index), GetPlayerMAGI(Index), GetPlayerSPEED(Index));
        PlayerMsg(Index, msg, White);
        int n = GetPlayerSTR(Index) / 2 + GetPlayerLevel(Index) / 2;
        int i = GetPlayerDEF(Index) / 2 + GetPlayerLevel(Index) / 2;
        if (n > 100) n = 100;
        if (i > 100) i = 100;
        snprintf(msg, sizeof(msg), "Critical Hit Chance: %d%%, Block Chance: %d%%", n, i);
        PlayerMsg(Index, msg, White);
        goto done;
    }

    // ==========================================
    // requestnewmap
    // ==========================================
    if (strcmp(cmd, "requestnewmap") == 0) {
        int Dir = PVAL(1);
        if (Dir < DIR_UP || Dir > DIR_RIGHT) { HackingAttempt(Index, "Invalid Direction"); goto done; }
        PlayerMove(Index, Dir, 1);
        goto done;
    }

    // ==========================================
    // mapdata (admin save map)
    // ==========================================
    if (strcmp(cmd, "mapdata") == 0) {
        if (GetPlayerAccess(Index) < ADMIN_MAPPER) { HackingAttempt(Index, "Admin Cloning"); goto done; }

        int n = 1;
        int MapNum = GetPlayerMap(Index);
        strlcpy_safe(Map_[MapNum].Name, P(n + 1), sizeof(Map_[MapNum].Name));
        Map_[MapNum].Revision++;
        Map_[MapNum].Moral = PVAL(n + 3);
        Map_[MapNum].Up = PVAL(n + 4);
        Map_[MapNum].Down = PVAL(n + 5);
        Map_[MapNum].Left = PVAL(n + 6);
        Map_[MapNum].Right = PVAL(n + 7);
        Map_[MapNum].Music = PVAL(n + 8);
        Map_[MapNum].BootMap = PVAL(n + 9);
        Map_[MapNum].BootX = PVAL(n + 10);
        Map_[MapNum].BootY = PVAL(n + 11);
        Map_[MapNum].Shop = PVAL(n + 12);

        n = n + 13;
        for (int y = 0; y <= MAX_MAPY; y++) {
            for (int x = 0; x <= MAX_MAPX; x++) {
                Map_[MapNum].Tile[x][y].Ground = PVAL(n);
                Map_[MapNum].Tile[x][y].Mask = PVAL(n + 1);
                Map_[MapNum].Tile[x][y].Anim = PVAL(n + 2);
                Map_[MapNum].Tile[x][y].Fringe = PVAL(n + 3);
                Map_[MapNum].Tile[x][y].Type = PVAL(n + 4);
                Map_[MapNum].Tile[x][y].Data1 = PVAL(n + 5);
                Map_[MapNum].Tile[x][y].Data2 = PVAL(n + 6);
                Map_[MapNum].Tile[x][y].Data3 = PVAL(n + 7);
                n += 8;
            }
        }

        for (int x = 1; x <= MAX_MAP_NPCS; x++) {
            Map_[MapNum].Npc[x] = PVAL(n);
            n++;
            ClearMapNpc(x, MapNum);
        }
        SendMapNpcsToMap(MapNum);
        SpawnMapNpcs(MapNum);

        SaveMap(MapNum);

        // Refresh map for everyone online
        for (int i = 1; i <= MAX_PLAYERS; i++) {
            if (IsPlaying(i) && GetPlayerMap(i) == MapNum) {
                PlayerWarp(i, MapNum, GetPlayerX(i), GetPlayerY(i));
            }
        }
        goto done;
    }

    // ==========================================
    // needmap
    // ==========================================
    if (strcmp(cmd, "needmap") == 0) {
        char s[16];
        strlcpy_safe(s, P(1), sizeof(s));
        to_lower(s);

        if (strcmp(s, "yes") == 0) {
            SendMap(Index, GetPlayerMap(Index));
        }
        SendMapItemsTo(Index, GetPlayerMap(Index));
        SendMapNpcsTo(Index, GetPlayerMap(Index));
        SendJoinMap(Index);
        Player[Index].GettingMap = NO;

        PKT_INIT(pkt);
        PKT_S(pkt, "MAPDONE"); PKT_END(pkt);
        SendDataTo(Index, pkt);
        goto done;
    }

    // ==========================================
    // mapgetitem
    // ==========================================
    if (strcmp(cmd, "mapgetitem") == 0) {
        PlayerMapGetItem(Index);
        goto done;
    }

    // ==========================================
    // mapdropitem
    // ==========================================
    if (strcmp(cmd, "mapdropitem") == 0) {
        int InvNum = PVAL(1);
        int Amount = PVAL(2);

        if (InvNum < 1 || InvNum > MAX_INV) { HackingAttempt(Index, "Invalid InvNum"); goto done; }
        if (Amount > GetPlayerInvItemValue(Index, InvNum)) { HackingAttempt(Index, "Item ammount modification"); goto done; }
        if (Item_[GetPlayerInvItemNum(Index, InvNum)].Type == ITEM_TYPE_CURRENCY) {
            if (Amount <= 0) { HackingAttempt(Index, "Trying to drop 0 ammount of currency"); goto done; }
        }

        PlayerMapDropItem(Index, InvNum, Amount);
        goto done;
    }

    // ==========================================
    // maprespawn
    // ==========================================
    if (strcmp(cmd, "maprespawn") == 0) {
        if (GetPlayerAccess(Index) < ADMIN_MAPPER) { HackingAttempt(Index, "Admin Cloning"); goto done; }

        int pmap = GetPlayerMap(Index);
        for (int i = 1; i <= MAX_MAP_ITEMS; i++) {
            SpawnItemSlot(i, 0, 0, 0, pmap, MapItem_[pmap][i].x, MapItem_[pmap][i].y);
            ClearMapItem(i, pmap);
        }
        SpawnMapItems(pmap);
        for (int i = 1; i <= MAX_MAP_NPCS; i++) {
            SpawnNpc_(i, pmap);
        }
        PlayerMsg(Index, "Map respawned.", Blue);
        char logmsg[256];
        snprintf(logmsg, sizeof(logmsg), "%s has respawned map #%d", GetPlayerName(Index), pmap);
        AddLog(logmsg, ADMIN_LOG);
        goto done;
    }

    // ==========================================
    // mapreport
    // ==========================================
    if (strcmp(cmd, "mapreport") == 0) {
        if (GetPlayerAccess(Index) < ADMIN_MAPPER) { HackingAttempt(Index, "Admin Cloning"); goto done; }

        char s[BUFFER_SIZE];
        strlcpy_safe(s, "Free Maps: ", sizeof(s));
        int tMapStart = 1, tMapEnd = 1;

        for (int i = 1; i <= MAX_MAPS; i++) {
            char mname[NAME_LENGTH+1];
            strlcpy_safe(mname, Map_[i].Name, sizeof(mname));
            str_trim(mname);
            if (mname[0] == '\0') {
                tMapEnd++;
            } else {
                if (tMapEnd - tMapStart > 0) {
                    char tmp[64];
                    snprintf(tmp, sizeof(tmp), "%d-%d, ", tMapStart, tMapEnd - 1);
                    strncat(s, tmp, sizeof(s) - strlen(s) - 1);
                }
                tMapStart = i + 1;
                tMapEnd = i + 1;
            }
        }
        {
            char tmp[64];
            snprintf(tmp, sizeof(tmp), "%d-%d, ", tMapStart, tMapEnd - 1);
            strncat(s, tmp, sizeof(s) - strlen(s) - 1);
        }
        // Remove trailing ", " and add "."
        size_t slen = strlen(s);
        if (slen >= 2 && s[slen-2] == ',' && s[slen-1] == ' ') {
            s[slen-2] = '.';
            s[slen-1] = '\0';
        }

        PlayerMsg(Index, s, Brown);
        goto done;
    }

    // ==========================================
    // kickplayer
    // ==========================================
    if (strcmp(cmd, "kickplayer") == 0) {
        if (GetPlayerAccess(Index) <= 0) { HackingAttempt(Index, "Admin Cloning"); goto done; }

        int n = FindPlayer(P(1));
        if (n != Index) {
            if (n > 0) {
                if (GetPlayerAccess(n) <= GetPlayerAccess(Index)) {
                    char msg[256];
                    snprintf(msg, sizeof(msg), "%s has been kicked from %s by %s!", GetPlayerName(n), GAME_NAME, GetPlayerName(Index));
                    GlobalMsg(msg, White);
                    snprintf(msg, sizeof(msg), "%s has kicked %s.", GetPlayerName(Index), GetPlayerName(n));
                    AddLog(msg, ADMIN_LOG);
                    char amsg[256];
                    snprintf(amsg, sizeof(amsg), "You have been kicked by %s!", GetPlayerName(Index));
                    AlertMsg(n, amsg);
                } else {
                    PlayerMsg(Index, "That is a higher access admin then you!", White);
                }
            } else {
                PlayerMsg(Index, "Player is not online.", White);
            }
        } else {
            PlayerMsg(Index, "You cannot kick yourself!", White);
        }
        goto done;
    }

    // ==========================================
    // banlist
    // ==========================================
    if (strcmp(cmd, "banlist") == 0) {
        if (GetPlayerAccess(Index) < ADMIN_MAPPER) { HackingAttempt(Index, "Admin Cloning"); goto done; }

        char fpath[600];
        snprintf(fpath, sizeof(fpath), "%s/banlist.txt", app_path);
        FILE *f = fopen(fpath, "r");
        if (f) {
            char fIP[256], fName[256];
            int n = 1;
            while (fscanf(f, " %255[^,], %255[^\n]", fIP, fName) == 2) {
                char msg[512];
                snprintf(msg, sizeof(msg), "%d: Banned IP %s by %s", n, fIP, fName);
                PlayerMsg(Index, msg, White);
                n++;
            }
            fclose(f);
        }
        goto done;
    }

    // ==========================================
    // bandestroy
    // ==========================================
    if (strcmp(cmd, "bandestroy") == 0) {
        if (GetPlayerAccess(Index) < ADMIN_CREATOR) { HackingAttempt(Index, "Admin Cloning"); goto done; }

        char fpath[600];
        snprintf(fpath, sizeof(fpath), "%s/banlist.txt", app_path);
        remove(fpath);
        PlayerMsg(Index, "Ban list destroyed.", White);
        goto done;
    }

    // ==========================================
    // banplayer
    // ==========================================
    if (strcmp(cmd, "banplayer") == 0) {
        if (GetPlayerAccess(Index) < ADMIN_MAPPER) { HackingAttempt(Index, "Admin Cloning"); goto done; }

        int n = FindPlayer(P(1));
        if (n != Index) {
            if (n > 0) {
                if (GetPlayerAccess(n) <= GetPlayerAccess(Index)) {
                    BanIndex(n, Index);
                } else {
                    PlayerMsg(Index, "That is a higher access admin then you!", White);
                }
            } else {
                PlayerMsg(Index, "Player is not online.", White);
            }
        } else {
            PlayerMsg(Index, "You cannot ban yourself!", White);
        }
        goto done;
    }

    // ==========================================
    // requesteditmap
    // ==========================================
    if (strcmp(cmd, "requesteditmap") == 0) {
        if (GetPlayerAccess(Index) < ADMIN_MAPPER) { HackingAttempt(Index, "Admin Cloning"); goto done; }
        PKT_INIT(pkt); PKT_S(pkt, "EDITMAP"); PKT_END(pkt);
        SendDataTo(Index, pkt);
        goto done;
    }

    // ==========================================
    // requestedititem
    // ==========================================
    if (strcmp(cmd, "requestedititem") == 0) {
        if (GetPlayerAccess(Index) < ADMIN_DEVELOPER) { HackingAttempt(Index, "Admin Cloning"); goto done; }
        PKT_INIT(pkt); PKT_S(pkt, "ITEMEDITOR"); PKT_END(pkt);
        SendDataTo(Index, pkt);
        goto done;
    }

    // ==========================================
    // edititem
    // ==========================================
    if (strcmp(cmd, "edititem") == 0) {
        if (GetPlayerAccess(Index) < ADMIN_DEVELOPER) { HackingAttempt(Index, "Admin Cloning"); goto done; }
        int n = PVAL(1);
        if (n < 0 || n > MAX_ITEMS) { HackingAttempt(Index, "Invalid Item Index"); goto done; }
        char logmsg[256];
        snprintf(logmsg, sizeof(logmsg), "%s editing item #%d.", GetPlayerName(Index), n);
        AddLog(logmsg, ADMIN_LOG);
        SendEditItemTo(Index, n);
        goto done;
    }

    // ==========================================
    // saveitem
    // ==========================================
    if (strcmp(cmd, "saveitem") == 0) {
        if (GetPlayerAccess(Index) < ADMIN_DEVELOPER) { HackingAttempt(Index, "Admin Cloning"); goto done; }
        int n = PVAL(1);
        if (n < 0 || n > MAX_ITEMS) { HackingAttempt(Index, "Invalid Item Index"); goto done; }

        strlcpy_safe(Item_[n].Name, P(2), sizeof(Item_[n].Name));
        Item_[n].Pic = PVAL(3);
        Item_[n].Type = PVAL(4);
        Item_[n].Data1 = PVAL(5);
        Item_[n].Data2 = PVAL(6);
        Item_[n].Data3 = PVAL(7);

        SendUpdateItemToAll(n);
        SaveItem(n);
        char logmsg[256];
        snprintf(logmsg, sizeof(logmsg), "%s saved item #%d.", GetPlayerName(Index), n);
        AddLog(logmsg, ADMIN_LOG);
        goto done;
    }

    // ==========================================
    // requesteditnpc
    // ==========================================
    if (strcmp(cmd, "requesteditnpc") == 0) {
        if (GetPlayerAccess(Index) < ADMIN_DEVELOPER) { HackingAttempt(Index, "Admin Cloning"); goto done; }
        PKT_INIT(pkt); PKT_S(pkt, "NPCEDITOR"); PKT_END(pkt);
        SendDataTo(Index, pkt);
        goto done;
    }

    // ==========================================
    // editnpc
    // ==========================================
    if (strcmp(cmd, "editnpc") == 0) {
        if (GetPlayerAccess(Index) < ADMIN_DEVELOPER) { HackingAttempt(Index, "Admin Cloning"); goto done; }
        int n = PVAL(1);
        if (n < 0 || n > MAX_NPCS) { HackingAttempt(Index, "Invalid NPC Index"); goto done; }
        char logmsg[256];
        snprintf(logmsg, sizeof(logmsg), "%s editing npc #%d.", GetPlayerName(Index), n);
        AddLog(logmsg, ADMIN_LOG);
        SendEditNpcTo(Index, n);
        goto done;
    }

    // ==========================================
    // savenpc
    // ==========================================
    if (strcmp(cmd, "savenpc") == 0) {
        if (GetPlayerAccess(Index) < ADMIN_DEVELOPER) { HackingAttempt(Index, "Admin Cloning"); goto done; }
        int n = PVAL(1);
        if (n < 0 || n > MAX_NPCS) { HackingAttempt(Index, "Invalid NPC Index"); goto done; }

        strlcpy_safe(Npc_[n].Name, P(2), sizeof(Npc_[n].Name));
        strlcpy_safe(Npc_[n].AttackSay, P(3), sizeof(Npc_[n].AttackSay));
        Npc_[n].Sprite = PVAL(4);
        Npc_[n].SpawnSecs = PVAL(5);
        Npc_[n].Behavior = PVAL(6);
        Npc_[n].Range = PVAL(7);
        Npc_[n].DropChance = PVAL(8);
        Npc_[n].DropItem = PVAL(9);
        Npc_[n].DropItemValue = PVAL(10);
        Npc_[n].STR = PVAL(11);
        Npc_[n].DEF = PVAL(12);
        Npc_[n].SPEED = PVAL(13);
        Npc_[n].MAGI = PVAL(14);

        SendUpdateNpcToAll(n);
        SaveNpc(n);
        char logmsg[256];
        snprintf(logmsg, sizeof(logmsg), "%s saved npc #%d.", GetPlayerName(Index), n);
        AddLog(logmsg, ADMIN_LOG);
        goto done;
    }

    // ==========================================
    // requesteditshop
    // ==========================================
    if (strcmp(cmd, "requesteditshop") == 0) {
        if (GetPlayerAccess(Index) < ADMIN_DEVELOPER) { HackingAttempt(Index, "Admin Cloning"); goto done; }
        PKT_INIT(pkt); PKT_S(pkt, "SHOPEDITOR"); PKT_END(pkt);
        SendDataTo(Index, pkt);
        goto done;
    }

    // ==========================================
    // editshop
    // ==========================================
    if (strcmp(cmd, "editshop") == 0) {
        if (GetPlayerAccess(Index) < ADMIN_DEVELOPER) { HackingAttempt(Index, "Admin Cloning"); goto done; }
        int n = PVAL(1);
        if (n < 0 || n > MAX_SHOPS) { HackingAttempt(Index, "Invalid Shop Index"); goto done; }
        char logmsg[256];
        snprintf(logmsg, sizeof(logmsg), "%s editing shop #%d.", GetPlayerName(Index), n);
        AddLog(logmsg, ADMIN_LOG);
        SendEditShopTo(Index, n);
        goto done;
    }

    // ==========================================
    // saveshop
    // ==========================================
    if (strcmp(cmd, "saveshop") == 0) {
        if (GetPlayerAccess(Index) < ADMIN_DEVELOPER) { HackingAttempt(Index, "Admin Cloning"); goto done; }
        int ShopNum = PVAL(1);
        if (ShopNum < 0 || ShopNum > MAX_SHOPS) { HackingAttempt(Index, "Invalid Shop Index"); goto done; }

        strlcpy_safe(Shop_[ShopNum].Name, P(2), sizeof(Shop_[ShopNum].Name));
        strlcpy_safe(Shop_[ShopNum].JoinSay, P(3), sizeof(Shop_[ShopNum].JoinSay));
        strlcpy_safe(Shop_[ShopNum].LeaveSay, P(4), sizeof(Shop_[ShopNum].LeaveSay));
        Shop_[ShopNum].FixesItems = PVAL(5);

        int n = 6;
        for (int i = 1; i <= MAX_TRADES; i++) {
            Shop_[ShopNum].TradeItem[i].GiveItem = PVAL(n);
            Shop_[ShopNum].TradeItem[i].GiveValue = PVAL(n + 1);
            Shop_[ShopNum].TradeItem[i].GetItem = PVAL(n + 2);
            Shop_[ShopNum].TradeItem[i].GetValue = PVAL(n + 3);
            n += 4;
        }

        SendUpdateShopToAll(ShopNum);
        SaveShop(ShopNum);
        char logmsg[256];
        snprintf(logmsg, sizeof(logmsg), "%s saving shop #%d.", GetPlayerName(Index), ShopNum);
        AddLog(logmsg, ADMIN_LOG);
        goto done;
    }

    // ==========================================
    // requesteditspell
    // ==========================================
    if (strcmp(cmd, "requesteditspell") == 0) {
        if (GetPlayerAccess(Index) < ADMIN_DEVELOPER) { HackingAttempt(Index, "Admin Cloning"); goto done; }
        PKT_INIT(pkt); PKT_S(pkt, "SPELLEDITOR"); PKT_END(pkt);
        SendDataTo(Index, pkt);
        goto done;
    }

    // ==========================================
    // editspell
    // ==========================================
    if (strcmp(cmd, "editspell") == 0) {
        if (GetPlayerAccess(Index) < ADMIN_DEVELOPER) { HackingAttempt(Index, "Admin Cloning"); goto done; }
        int n = PVAL(1);
        if (n < 0 || n > MAX_SPELLS) { HackingAttempt(Index, "Invalid Spell Index"); goto done; }
        char logmsg[256];
        snprintf(logmsg, sizeof(logmsg), "%s editing spell #%d.", GetPlayerName(Index), n);
        AddLog(logmsg, ADMIN_LOG);
        SendEditSpellTo(Index, n);
        goto done;
    }

    // ==========================================
    // savespell
    // ==========================================
    if (strcmp(cmd, "savespell") == 0) {
        if (GetPlayerAccess(Index) < ADMIN_DEVELOPER) { HackingAttempt(Index, "Admin Cloning"); goto done; }
        int n = PVAL(1);
        if (n < 0 || n > MAX_SPELLS) { HackingAttempt(Index, "Invalid Spell Index"); goto done; }

        strlcpy_safe(Spell_[n].Name, P(2), sizeof(Spell_[n].Name));
        Spell_[n].ClassReq = PVAL(3);
        Spell_[n].LevelReq = PVAL(4);
        Spell_[n].Type = PVAL(5);
        Spell_[n].Data1 = PVAL(6);
        Spell_[n].Data2 = PVAL(7);
        Spell_[n].Data3 = PVAL(8);

        SendUpdateSpellToAll(n);
        SaveSpell(n);
        char logmsg[256];
        snprintf(logmsg, sizeof(logmsg), "%s saving spell #%d.", GetPlayerName(Index), n);
        AddLog(logmsg, ADMIN_LOG);
        goto done;
    }

    // ==========================================
    // setaccess
    // ==========================================
    if (strcmp(cmd, "setaccess") == 0) {
        if (GetPlayerAccess(Index) < ADMIN_CREATOR) { HackingAttempt(Index, "Trying to use powers not available"); goto done; }

        int n = FindPlayer(P(1));
        int i = PVAL(2);

        if (i >= 0 && i <= 3) {
            if (n > 0) {
                if (GetPlayerAccess(n) <= 0) {
                    GlobalMsg("has been blessed with administrative access.", BrightBlue);
                }
                SetPlayerAccess(n, i);
                SendPlayerData(n);
                char logmsg[256];
                snprintf(logmsg, sizeof(logmsg), "%s has modified %s's access.", GetPlayerName(Index), GetPlayerName(n));
                AddLog(logmsg, ADMIN_LOG);
            } else {
                PlayerMsg(Index, "Player is not online.", White);
            }
        } else {
            PlayerMsg(Index, "Invalid access level.", Red);
        }
        goto done;
    }

    // ==========================================
    // whosonline
    // ==========================================
    if (strcmp(cmd, "whosonline") == 0) {
        SendWhosOnline(Index);
        goto done;
    }

    // ==========================================
    // setmotd
    // ==========================================
    if (strcmp(cmd, "setmotd") == 0) {
        if (GetPlayerAccess(Index) < ADMIN_MAPPER) { HackingAttempt(Index, "Admin Cloning"); goto done; }

        char mpath[600];
        snprintf(mpath, sizeof(mpath), "%s/motd.ini", app_path);
        put_var(mpath, "MOTD", "Msg", P(1));

        char msg[512];
        snprintf(msg, sizeof(msg), "MOTD changed to: %s", P(1));
        GlobalMsg(msg, BrightCyan);
        char logmsg[256];
        snprintf(logmsg, sizeof(logmsg), "%s changed MOTD to: %s", GetPlayerName(Index), P(1));
        AddLog(logmsg, ADMIN_LOG);
        goto done;
    }

    // ==========================================
    // trade
    // ==========================================
    if (strcmp(cmd, "trade") == 0) {
        if (Map_[GetPlayerMap(Index)].Shop > 0) {
            SendTrade(Index, Map_[GetPlayerMap(Index)].Shop);
        } else {
            PlayerMsg(Index, "There is no shop here.", BrightRed);
        }
        goto done;
    }

    // ==========================================
    // traderequest
    // ==========================================
    if (strcmp(cmd, "traderequest") == 0) {
        int n = PVAL(1);
        if (n <= 0 || n > MAX_TRADES) { HackingAttempt(Index, "Trade Request Modification"); goto done; }

        int shopIdx = Map_[GetPlayerMap(Index)].Shop;

        int x = FindOpenInvSlot(Index, Shop_[shopIdx].TradeItem[n].GetItem);
        if (x == 0) { PlayerMsg(Index, "Trade unsuccessful, inventory full.", BrightRed); goto done; }

        if (HasItem(Index, Shop_[shopIdx].TradeItem[n].GiveItem) >= Shop_[shopIdx].TradeItem[n].GiveValue) {
            TakeItem_(Index, Shop_[shopIdx].TradeItem[n].GiveItem, Shop_[shopIdx].TradeItem[n].GiveValue);
            GiveItem_(Index, Shop_[shopIdx].TradeItem[n].GetItem, Shop_[shopIdx].TradeItem[n].GetValue);
            PlayerMsg(Index, "The trade was successful!", Yellow);
        } else {
            PlayerMsg(Index, "Trade unsuccessful.", BrightRed);
        }
        goto done;
    }

    // ==========================================
    // fixitem
    // ==========================================
    if (strcmp(cmd, "fixitem") == 0) {
        int n = PVAL(1);

        if (Item_[GetPlayerInvItemNum(Index, n)].Type < ITEM_TYPE_WEAPON || Item_[GetPlayerInvItemNum(Index, n)].Type > ITEM_TYPE_SHIELD) {
            PlayerMsg(Index, "You can only fix weapons, armors, helmets, and shields.", BrightRed);
            goto done;
        }

        if (FindOpenInvSlot(Index, GetPlayerInvItemNum(Index, n)) <= 0) {
            PlayerMsg(Index, "You have no inventory space left!", BrightRed);
            goto done;
        }

        int ItemNum = GetPlayerInvItemNum(Index, n);
        int i = (int)(Item_[GetPlayerInvItemNum(Index, n)].Data2 / 5);
        if (i <= 0) i = 1;

        int DurNeeded = Item_[ItemNum].Data1 - GetPlayerInvItemDur(Index, n);
        int GoldNeeded = (int)(DurNeeded * i / 2);
        if (GoldNeeded <= 0) GoldNeeded = 1;

        if (DurNeeded <= 0) {
            PlayerMsg(Index, "This item is in perfect condition!", White);
            goto done;
        }

        if (HasItem(Index, 1) >= i) {
            if (HasItem(Index, 1) >= GoldNeeded) {
                TakeItem_(Index, 1, GoldNeeded);
                SetPlayerInvItemDur(Index, n, Item_[ItemNum].Data1);
                char msg[256];
                snprintf(msg, sizeof(msg), "Item has been totally restored for %d gold!", GoldNeeded);
                PlayerMsg(Index, msg, BrightBlue);
            } else {
                DurNeeded = HasItem(Index, 1) / i;
                GoldNeeded = (int)(DurNeeded * i / 2);
                if (GoldNeeded <= 0) GoldNeeded = 1;

                TakeItem_(Index, 1, GoldNeeded);
                SetPlayerInvItemDur(Index, n, GetPlayerInvItemDur(Index, n) + DurNeeded);
                char msg[256];
                snprintf(msg, sizeof(msg), "Item has been partially fixed for %d gold!", GoldNeeded);
                PlayerMsg(Index, msg, BrightBlue);
            }
        } else {
            PlayerMsg(Index, "Insufficient gold to fix this item!", BrightRed);
        }
        goto done;
    }

    // ==========================================
    // search
    // ==========================================
    if (strcmp(cmd, "search") == 0) {
        int x = PVAL(1);
        int y = PVAL(2);

        if (x < 0 || x > MAX_MAPX || y < 0 || y > MAX_MAPY) goto done;

        // Check for a player
        for (int i = 1; i <= MAX_PLAYERS; i++) {
            if (IsPlaying(i) && GetPlayerMap(Index) == GetPlayerMap(i) && GetPlayerX(i) == x && GetPlayerY(i) == y) {
                if (GetPlayerLevel(i) >= GetPlayerLevel(Index) + 5) {
                    PlayerMsg(Index, "You wouldn't stand a chance.", BrightRed);
                } else if (GetPlayerLevel(i) > GetPlayerLevel(Index)) {
                    PlayerMsg(Index, "This one seems to have an advantage over you.", Yellow);
                } else if (GetPlayerLevel(i) == GetPlayerLevel(Index)) {
                    PlayerMsg(Index, "This would be an even fight.", White);
                } else if (GetPlayerLevel(Index) >= GetPlayerLevel(i) + 5) {
                    PlayerMsg(Index, "You could slaughter that player.", BrightBlue);
                } else if (GetPlayerLevel(Index) > GetPlayerLevel(i)) {
                    PlayerMsg(Index, "You would have an advantage over that player.", Yellow);
                }

                Player[Index].Target = i;
                Player[Index].TargetType = TARGET_TYPE_PLAYER;
                char msg[256];
                snprintf(msg, sizeof(msg), "Your target is now %s.", GetPlayerName(i));
                PlayerMsg(Index, msg, Yellow);
                goto done;
            }
        }

        // Check for an item
        int pmap = GetPlayerMap(Index);
        for (int i = 1; i <= MAX_MAP_ITEMS; i++) {
            if (MapItem_[pmap][i].Num > 0) {
                if (MapItem_[pmap][i].x == x && MapItem_[pmap][i].y == y) {
                    char msg[256];
                    snprintf(msg, sizeof(msg), "You see a %s.", Item_[MapItem_[pmap][i].Num].Name);
                    PlayerMsg(Index, msg, Yellow);
                    goto done;
                }
            }
        }

        // Check for an NPC
        for (int i = 1; i <= MAX_MAP_NPCS; i++) {
            if (MapNpc_[pmap][i].Num > 0) {
                if (MapNpc_[pmap][i].x == x && MapNpc_[pmap][i].y == y) {
                    Player[Index].Target = i;
                    Player[Index].TargetType = TARGET_TYPE_NPC;
                    char msg[256];
                    snprintf(msg, sizeof(msg), "Your target is now a %s.", Npc_[MapNpc_[pmap][i].Num].Name);
                    PlayerMsg(Index, msg, Yellow);
                    goto done;
                }
            }
        }
        goto done;
    }

    // ==========================================
    // party
    // ==========================================
    if (strcmp(cmd, "party") == 0) {
        int n = FindPlayer(P(1));

        if (n == Index) goto done;

        if (Player[Index].InParty == YES) {
            PlayerMsg(Index, "You are already in a party!", Pink);
            goto done;
        }

        if (n > 0) {
            if (GetPlayerAccess(Index) > ADMIN_MONITER) {
                PlayerMsg(Index, "You can't join a party, you are an admin!", BrightBlue);
                goto done;
            }
            if (GetPlayerAccess(n) > ADMIN_MONITER) {
                PlayerMsg(Index, "Admins cannot join parties!", BrightBlue);
                goto done;
            }
            if (GetPlayerLevel(Index) + 5 < GetPlayerLevel(n) || GetPlayerLevel(Index) - 5 > GetPlayerLevel(n)) {
                PlayerMsg(Index, "There is more then a 5 level gap between you two, party failed.", Pink);
                goto done;
            }

            if (Player[n].InParty == NO) {
                char msg[256];
                snprintf(msg, sizeof(msg), "Party request has been sent to %s.", GetPlayerName(n));
                PlayerMsg(Index, msg, Pink);
                snprintf(msg, sizeof(msg), "%s wants you to join their party.  Type /join to join, or /leave to decline.", GetPlayerName(Index));
                PlayerMsg(n, msg, Pink);

                Player[Index].PartyStarter = YES;
                Player[Index].PartyPlayer = n;
                Player[n].PartyPlayer = Index;
            } else {
                PlayerMsg(Index, "Player is already in a party!", Pink);
            }
        } else {
            PlayerMsg(Index, "Player is not online.", White);
        }
        goto done;
    }

    // ==========================================
    // joinparty
    // ==========================================
    if (strcmp(cmd, "joinparty") == 0) {
        int n = Player[Index].PartyPlayer;

        if (n > 0) {
            if (Player[Index].PartyStarter == NO) {
                if (Player[n].PartyPlayer == Index) {
                    char msg[256];
                    snprintf(msg, sizeof(msg), "You have joined %s's party!", GetPlayerName(n));
                    PlayerMsg(Index, msg, Pink);
                    snprintf(msg, sizeof(msg), "%s has joined your party!", GetPlayerName(Index));
                    PlayerMsg(n, msg, Pink);

                    Player[Index].InParty = YES;
                    Player[n].InParty = YES;
                } else {
                    PlayerMsg(Index, "Party failed.", Pink);
                }
            } else {
                PlayerMsg(Index, "You have not been invited to join a party!", Pink);
            }
        } else {
            PlayerMsg(Index, "You have not been invited into a party!", Pink);
        }
        goto done;
    }

    // ==========================================
    // leaveparty
    // ==========================================
    if (strcmp(cmd, "leaveparty") == 0) {
        int n = Player[Index].PartyPlayer;

        if (n > 0) {
            if (Player[Index].InParty == YES) {
                PlayerMsg(Index, "You have left the party.", Pink);
                char msg[256];
                snprintf(msg, sizeof(msg), "%s has left the party.", GetPlayerName(Index));
                PlayerMsg(n, msg, Pink);
            } else {
                PlayerMsg(Index, "Declined party request.", Pink);
                char msg[256];
                snprintf(msg, sizeof(msg), "%s declined your request.", GetPlayerName(Index));
                PlayerMsg(n, msg, Pink);
            }

            Player[Index].PartyPlayer = 0;
            Player[Index].PartyStarter = NO;
            Player[Index].InParty = NO;
            Player[n].PartyPlayer = 0;
            Player[n].PartyStarter = NO;
            Player[n].InParty = NO;
        } else {
            PlayerMsg(Index, "You are not in a party!", Pink);
        }
        goto done;
    }

    // ==========================================
    // spells
    // ==========================================
    if (strcmp(cmd, "spells") == 0) {
        SendPlayerSpells(Index);
        goto done;
    }

    // ==========================================
    // cast
    // ==========================================
    if (strcmp(cmd, "cast") == 0) {
        int n = PVAL(1);
        CastSpell_(Index, n);
        goto done;
    }

    // ==========================================
    // requestlocation
    // ==========================================
    if (strcmp(cmd, "requestlocation") == 0) {
        if (GetPlayerAccess(Index) < ADMIN_MAPPER) { HackingAttempt(Index, "Admin Cloning"); goto done; }
        char msg[256];
        snprintf(msg, sizeof(msg), "Map: %d, X: %d, Y: %d", GetPlayerMap(Index), GetPlayerX(Index), GetPlayerY(Index));
        PlayerMsg(Index, msg, Pink);
        goto done;
    }

done:
    free(datacopy);
    #undef P
    #undef PVAL
}

// ========================================================================
// Send functions
// ========================================================================

void SendWhosOnline(int Index)
{
    char s[BUFFER_SIZE];
    s[0] = '\0';
    int n = 0;

    for (int i = 1; i <= MAX_PLAYERS; i++) {
        if (IsPlaying(i) && i != Index) {
            if (s[0] != '\0') strncat(s, ", ", sizeof(s) - strlen(s) - 1);
            strncat(s, GetPlayerName(i), sizeof(s) - strlen(s) - 1);
            n++;
        }
    }

    char msg[BUFFER_SIZE];
    if (n == 0) {
        strlcpy_safe(msg, "There are no other players online.", sizeof(msg));
    } else {
        snprintf(msg, sizeof(msg), "There are %d other players online: %s.", n, s);
    }

    PlayerMsg(Index, msg, WhoColor);
}

void SendChars(int Index)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "ALLCHARS");
    for (int i = 1; i <= MAX_CHARS; i++) {
        char *trimname = strdup(str_trim_ret(Player[Index].Char[i].Name));
        char *trimclass = strdup(str_trim_ret(Class[Player[Index].Char[i].Class].Name));
        PKT_S(pkt, trimname);
        PKT_S(pkt, trimclass);
        PKT_I(pkt, Player[Index].Char[i].Level);
        free(trimname);
        free(trimclass);
    }
    PKT_END(pkt);
    SendDataTo(Index, pkt);
}

void SendJoinMap(int Index)
{
    // Send all players on current map to index
    for (int i = 1; i <= MAX_PLAYERS; i++) {
        if (IsPlaying(i) && i != Index && GetPlayerMap(i) == GetPlayerMap(Index)) {
            PKT_INIT(pkt);
            PKT_S(pkt, "PLAYERDATA"); PKT_I(pkt, i); PKT_S(pkt, GetPlayerName(i));
            PKT_I(pkt, GetPlayerSprite(i)); PKT_I(pkt, GetPlayerMap(i));
            PKT_I(pkt, GetPlayerX(i)); PKT_I(pkt, GetPlayerY(i));
            PKT_I(pkt, GetPlayerDir(i)); PKT_I(pkt, GetPlayerAccess(i));
            PKT_I(pkt, GetPlayerPK(i)); PKT_END(pkt);
            SendDataTo(Index, pkt);
        }
    }

    // Send index's player data to everyone on the map including himself
    PKT_INIT(pkt);
    PKT_S(pkt, "PLAYERDATA"); PKT_I(pkt, Index); PKT_S(pkt, GetPlayerName(Index));
    PKT_I(pkt, GetPlayerSprite(Index)); PKT_I(pkt, GetPlayerMap(Index));
    PKT_I(pkt, GetPlayerX(Index)); PKT_I(pkt, GetPlayerY(Index));
    PKT_I(pkt, GetPlayerDir(Index)); PKT_I(pkt, GetPlayerAccess(Index));
    PKT_I(pkt, GetPlayerPK(Index)); PKT_END(pkt);
    SendDataToMap(GetPlayerMap(Index), pkt);
}

void SendLeaveMap(int Index, int MapNum)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "PLAYERDATA"); PKT_I(pkt, Index); PKT_S(pkt, GetPlayerName(Index));
    PKT_I(pkt, GetPlayerSprite(Index)); PKT_I(pkt, 0);
    PKT_I(pkt, GetPlayerX(Index)); PKT_I(pkt, GetPlayerY(Index));
    PKT_I(pkt, GetPlayerDir(Index)); PKT_I(pkt, GetPlayerAccess(Index));
    PKT_I(pkt, GetPlayerPK(Index)); PKT_END(pkt);
    SendDataToMapBut(Index, MapNum, pkt);
}

void SendPlayerData(int Index)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "PLAYERDATA"); PKT_I(pkt, Index); PKT_S(pkt, GetPlayerName(Index));
    PKT_I(pkt, GetPlayerSprite(Index)); PKT_I(pkt, GetPlayerMap(Index));
    PKT_I(pkt, GetPlayerX(Index)); PKT_I(pkt, GetPlayerY(Index));
    PKT_I(pkt, GetPlayerDir(Index)); PKT_I(pkt, GetPlayerAccess(Index));
    PKT_I(pkt, GetPlayerPK(Index)); PKT_END(pkt);
    SendDataToMap(GetPlayerMap(Index), pkt);
}

void SendMap(int Index, int MapNum)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "MAPDATA"); PKT_I(pkt, MapNum);
    char *trimname = str_trim_ret(Map_[MapNum].Name);
    PKT_S(pkt, trimname);
    PKT_I(pkt, Map_[MapNum].Revision);
    PKT_I(pkt, Map_[MapNum].Moral);
    PKT_I(pkt, Map_[MapNum].Up); PKT_I(pkt, Map_[MapNum].Down);
    PKT_I(pkt, Map_[MapNum].Left); PKT_I(pkt, Map_[MapNum].Right);
    PKT_I(pkt, Map_[MapNum].Music);
    PKT_I(pkt, Map_[MapNum].BootMap); PKT_I(pkt, Map_[MapNum].BootX); PKT_I(pkt, Map_[MapNum].BootY);
    PKT_I(pkt, Map_[MapNum].Shop);

    for (int y = 0; y <= MAX_MAPY; y++) {
        for (int x = 0; x <= MAX_MAPX; x++) {
            PKT_I(pkt, Map_[MapNum].Tile[x][y].Ground);
            PKT_I(pkt, Map_[MapNum].Tile[x][y].Mask);
            PKT_I(pkt, Map_[MapNum].Tile[x][y].Anim);
            PKT_I(pkt, Map_[MapNum].Tile[x][y].Fringe);
            PKT_I(pkt, Map_[MapNum].Tile[x][y].Type);
            PKT_I(pkt, Map_[MapNum].Tile[x][y].Data1);
            PKT_I(pkt, Map_[MapNum].Tile[x][y].Data2);
            PKT_I(pkt, Map_[MapNum].Tile[x][y].Data3);
        }
    }

    for (int x = 1; x <= MAX_MAP_NPCS; x++) {
        PKT_I(pkt, Map_[MapNum].Npc[x]);
    }

    PKT_END(pkt);
    SendDataTo(Index, pkt);
}

void SendMapItemsTo(int Index, int MapNum)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "MAPITEMDATA");
    for (int i = 1; i <= MAX_MAP_ITEMS; i++) {
        PKT_I(pkt, MapItem_[MapNum][i].Num);
        PKT_I(pkt, MapItem_[MapNum][i].Value);
        PKT_I(pkt, MapItem_[MapNum][i].Dur);
        PKT_I(pkt, MapItem_[MapNum][i].x);
        PKT_I(pkt, MapItem_[MapNum][i].y);
    }
    PKT_END(pkt);
    SendDataTo(Index, pkt);
}

void SendMapItemsToAll(int MapNum)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "MAPITEMDATA");
    for (int i = 1; i <= MAX_MAP_ITEMS; i++) {
        PKT_I(pkt, MapItem_[MapNum][i].Num);
        PKT_I(pkt, MapItem_[MapNum][i].Value);
        PKT_I(pkt, MapItem_[MapNum][i].Dur);
        PKT_I(pkt, MapItem_[MapNum][i].x);
        PKT_I(pkt, MapItem_[MapNum][i].y);
    }
    PKT_END(pkt);
    SendDataToMap(MapNum, pkt);
}

void SendMapNpcsTo(int Index, int MapNum)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "MAPNPCDATA");
    for (int i = 1; i <= MAX_MAP_NPCS; i++) {
        PKT_I(pkt, MapNpc_[MapNum][i].Num);
        PKT_I(pkt, MapNpc_[MapNum][i].x);
        PKT_I(pkt, MapNpc_[MapNum][i].y);
        PKT_I(pkt, MapNpc_[MapNum][i].Dir);
    }
    PKT_END(pkt);
    SendDataTo(Index, pkt);
}

void SendMapNpcsToMap(int MapNum)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "MAPNPCDATA");
    for (int i = 1; i <= MAX_MAP_NPCS; i++) {
        PKT_I(pkt, MapNpc_[MapNum][i].Num);
        PKT_I(pkt, MapNpc_[MapNum][i].x);
        PKT_I(pkt, MapNpc_[MapNum][i].y);
        PKT_I(pkt, MapNpc_[MapNum][i].Dir);
    }
    PKT_END(pkt);
    SendDataToMap(MapNum, pkt);
}

void SendItems(int Index)
{
    for (int i = 1; i <= MAX_ITEMS; i++) {
        char tname[NAME_LENGTH+1];
        strlcpy_safe(tname, Item_[i].Name, sizeof(tname));
        str_trim(tname);
        if (tname[0] != '\0')
            SendUpdateItemTo(Index, i);
    }
}

void SendNpcs(int Index)
{
    for (int i = 1; i <= MAX_NPCS; i++) {
        char tname[NAME_LENGTH+1];
        strlcpy_safe(tname, Npc_[i].Name, sizeof(tname));
        str_trim(tname);
        if (tname[0] != '\0')
            SendUpdateNpcTo(Index, i);
    }
}

void SendInventory(int Index)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "PLAYERINV");
    for (int i = 1; i <= MAX_INV; i++) {
        PKT_I(pkt, GetPlayerInvItemNum(Index, i));
        PKT_I(pkt, GetPlayerInvItemValue(Index, i));
        PKT_I(pkt, GetPlayerInvItemDur(Index, i));
    }
    PKT_END(pkt);
    SendDataTo(Index, pkt);
}

void SendInventoryUpdate(int Index, int InvSlot)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "PLAYERINVUPDATE");
    PKT_I(pkt, InvSlot);
    PKT_I(pkt, GetPlayerInvItemNum(Index, InvSlot));
    PKT_I(pkt, GetPlayerInvItemValue(Index, InvSlot));
    PKT_I(pkt, GetPlayerInvItemDur(Index, InvSlot));
    PKT_END(pkt);
    SendDataTo(Index, pkt);
}

void SendWornEquipment(int Index)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "PLAYERWORNEQ");
    PKT_I(pkt, GetPlayerArmorSlot(Index));
    PKT_I(pkt, GetPlayerWeaponSlot(Index));
    PKT_I(pkt, GetPlayerHelmetSlot(Index));
    PKT_I(pkt, GetPlayerShieldSlot(Index));
    PKT_END(pkt);
    SendDataTo(Index, pkt);
}

void SendHP(int Index)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "PLAYERHP");
    PKT_I(pkt, GetPlayerMaxHP(Index));
    PKT_I(pkt, GetPlayerHP(Index));
    PKT_END(pkt);
    SendDataTo(Index, pkt);
}

void SendMP(int Index)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "PLAYERMP");
    PKT_I(pkt, GetPlayerMaxMP(Index));
    PKT_I(pkt, GetPlayerMP(Index));
    PKT_END(pkt);
    SendDataTo(Index, pkt);
}

void SendSP(int Index)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "PLAYERSP");
    PKT_I(pkt, GetPlayerMaxSP(Index));
    PKT_I(pkt, GetPlayerSP(Index));
    PKT_END(pkt);
    SendDataTo(Index, pkt);
}

void SendStats(int Index)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "PLAYERSTATS");
    PKT_I(pkt, GetPlayerSTR(Index));
    PKT_I(pkt, GetPlayerDEF(Index));
    PKT_I(pkt, GetPlayerSPEED(Index));
    PKT_I(pkt, GetPlayerMAGI(Index));
    PKT_END(pkt);
    SendDataTo(Index, pkt);
}

void SendWelcome(int Index)
{
    char msg[512];
    snprintf(msg, sizeof(msg), "Welcome to %s!  Version %d.%d.%d", GAME_NAME, CLIENT_MAJOR, CLIENT_MINOR, CLIENT_REVISION);
    PlayerMsg(Index, msg, BrightBlue);
    PlayerMsg(Index, "Type /help for help on commands.  Use arrow keys to move, hold down shift to run, and use ctrl to attack.", Cyan);

    // Send MOTD
    char mpath[600];
    snprintf(mpath, sizeof(mpath), "%s/motd.ini", app_path);
    char *motd = get_var(mpath, "MOTD", "Msg");
    if (motd) {
        str_trim(motd);
        if (motd[0] != '\0') {
            char motdmsg[512];
            snprintf(motdmsg, sizeof(motdmsg), "MOTD: %s", motd);
            PlayerMsg(Index, motdmsg, BrightCyan);
        }
        free(motd);
    }

    SendWhosOnline(Index);
}

void SendClasses(int Index)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "CLASSESDATA");
    PKT_I(pkt, Max_Classes);
    for (int i = 0; i <= Max_Classes; i++) {
        PKT_S(pkt, GetClassName(i));
        PKT_I(pkt, GetClassMaxHP(i));
        PKT_I(pkt, GetClassMaxMP(i));
        PKT_I(pkt, GetClassMaxSP(i));
        PKT_I(pkt, Class[i].STR);
        PKT_I(pkt, Class[i].DEF);
        PKT_I(pkt, Class[i].SPEED);
        PKT_I(pkt, Class[i].MAGI);
    }
    PKT_END(pkt);
    SendDataTo(Index, pkt);
}

void SendNewCharClasses(int Index)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "NEWCHARCLASSES");
    PKT_I(pkt, Max_Classes);
    for (int i = 0; i <= Max_Classes; i++) {
        PKT_S(pkt, GetClassName(i));
        PKT_I(pkt, GetClassMaxHP(i));
        PKT_I(pkt, GetClassMaxMP(i));
        PKT_I(pkt, GetClassMaxSP(i));
        PKT_I(pkt, Class[i].STR);
        PKT_I(pkt, Class[i].DEF);
        PKT_I(pkt, Class[i].SPEED);
        PKT_I(pkt, Class[i].MAGI);
    }
    PKT_END(pkt);
    SendDataTo(Index, pkt);
}

void SendLeftGame(int Index)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "PLAYERDATA"); PKT_I(pkt, Index); PKT_S(pkt, "");
    PKT_I(pkt, 0); PKT_I(pkt, 0); PKT_I(pkt, 0); PKT_I(pkt, 0);
    PKT_I(pkt, 0); PKT_I(pkt, 0); PKT_I(pkt, 0);
    // Note: original VB6 uses END_CHAR directly after last field (no trailing SEP_CHAR)
    // We keep our consistent format
    PKT_END(pkt);
    SendDataToAllBut(Index, pkt);
}

void SendPlayerXY(int Index)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "PLAYERXY");
    PKT_I(pkt, GetPlayerX(Index));
    PKT_I(pkt, GetPlayerY(Index));
    PKT_END(pkt);
    SendDataTo(Index, pkt);
}

void SendUpdateItemToAll(int ItemNum)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "UPDATEITEM"); PKT_I(pkt, ItemNum);
    char *trimname = str_trim_ret(Item_[ItemNum].Name);
    PKT_S(pkt, trimname);
    PKT_I(pkt, Item_[ItemNum].Pic);
    PKT_I(pkt, Item_[ItemNum].Type);
    PKT_I(pkt, Item_[ItemNum].Data1);
    PKT_I(pkt, Item_[ItemNum].Data2);
    PKT_I(pkt, Item_[ItemNum].Data3);
    PKT_END(pkt);
    SendDataToAll(pkt);
}

void SendUpdateItemTo(int Index, int ItemNum)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "UPDATEITEM"); PKT_I(pkt, ItemNum);
    char *trimname = str_trim_ret(Item_[ItemNum].Name);
    PKT_S(pkt, trimname);
    PKT_I(pkt, Item_[ItemNum].Pic);
    PKT_I(pkt, Item_[ItemNum].Type);
    PKT_END(pkt);
    SendDataTo(Index, pkt);
}

void SendEditItemTo(int Index, int ItemNum)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "EDITITEM"); PKT_I(pkt, ItemNum);
    char *trimname = str_trim_ret(Item_[ItemNum].Name);
    PKT_S(pkt, trimname);
    PKT_I(pkt, Item_[ItemNum].Pic);
    PKT_I(pkt, Item_[ItemNum].Type);
    PKT_I(pkt, Item_[ItemNum].Data1);
    PKT_I(pkt, Item_[ItemNum].Data2);
    PKT_I(pkt, Item_[ItemNum].Data3);
    PKT_END(pkt);
    SendDataTo(Index, pkt);
}

void SendUpdateNpcToAll(int NpcNum)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "UPDATENPC"); PKT_I(pkt, NpcNum);
    char *trimname = str_trim_ret(Npc_[NpcNum].Name);
    PKT_S(pkt, trimname);
    PKT_I(pkt, Npc_[NpcNum].Sprite);
    PKT_END(pkt);
    SendDataToAll(pkt);
}

void SendUpdateNpcTo(int Index, int NpcNum)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "UPDATENPC"); PKT_I(pkt, NpcNum);
    char *trimname = str_trim_ret(Npc_[NpcNum].Name);
    PKT_S(pkt, trimname);
    PKT_I(pkt, Npc_[NpcNum].Sprite);
    PKT_END(pkt);
    SendDataTo(Index, pkt);
}

void SendEditNpcTo(int Index, int NpcNum)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "EDITNPC"); PKT_I(pkt, NpcNum);
    char *trimname = str_trim_ret(Npc_[NpcNum].Name);
    PKT_S(pkt, trimname);
    char *trimatk = str_trim_ret(Npc_[NpcNum].AttackSay);
    PKT_S(pkt, trimatk);
    PKT_I(pkt, Npc_[NpcNum].Sprite);
    PKT_I(pkt, Npc_[NpcNum].SpawnSecs);
    PKT_I(pkt, Npc_[NpcNum].Behavior);
    PKT_I(pkt, Npc_[NpcNum].Range);
    PKT_I(pkt, Npc_[NpcNum].DropChance);
    PKT_I(pkt, Npc_[NpcNum].DropItem);
    PKT_I(pkt, Npc_[NpcNum].DropItemValue);
    PKT_I(pkt, Npc_[NpcNum].STR);
    PKT_I(pkt, Npc_[NpcNum].DEF);
    PKT_I(pkt, Npc_[NpcNum].SPEED);
    PKT_I(pkt, Npc_[NpcNum].MAGI);
    PKT_END(pkt);
    SendDataTo(Index, pkt);
}

void SendShops_(int Index)
{
    for (int i = 1; i <= MAX_SHOPS; i++) {
        char tname[NAME_LENGTH+1];
        strlcpy_safe(tname, Shop_[i].Name, sizeof(tname));
        str_trim(tname);
        if (tname[0] != '\0')
            SendUpdateShopTo(Index, i);
    }
}

void SendUpdateShopToAll(int ShopNum)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "UPDATESHOP"); PKT_I(pkt, ShopNum);
    char *trimname = str_trim_ret(Shop_[ShopNum].Name);
    PKT_S(pkt, trimname);
    PKT_END(pkt);
    SendDataToAll(pkt);
}

void SendUpdateShopTo(int Index, int ShopNum)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "UPDATESHOP"); PKT_I(pkt, ShopNum);
    char *trimname = str_trim_ret(Shop_[ShopNum].Name);
    PKT_S(pkt, trimname);
    PKT_END(pkt);
    SendDataTo(Index, pkt);
}

void SendEditShopTo(int Index, int ShopNum)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "EDITSHOP"); PKT_I(pkt, ShopNum);
    char *trimname = str_trim_ret(Shop_[ShopNum].Name);
    PKT_S(pkt, trimname);
    char *trimjoin = str_trim_ret(Shop_[ShopNum].JoinSay);
    PKT_S(pkt, trimjoin);
    char *trimleave = str_trim_ret(Shop_[ShopNum].LeaveSay);
    PKT_S(pkt, trimleave);
    PKT_I(pkt, Shop_[ShopNum].FixesItems);
    for (int i = 1; i <= MAX_TRADES; i++) {
        PKT_I(pkt, Shop_[ShopNum].TradeItem[i].GiveItem);
        PKT_I(pkt, Shop_[ShopNum].TradeItem[i].GiveValue);
        PKT_I(pkt, Shop_[ShopNum].TradeItem[i].GetItem);
        PKT_I(pkt, Shop_[ShopNum].TradeItem[i].GetValue);
    }
    PKT_END(pkt);
    SendDataTo(Index, pkt);
}

void SendSpells_(int Index)
{
    for (int i = 1; i <= MAX_SPELLS; i++) {
        char tname[NAME_LENGTH+1];
        strlcpy_safe(tname, Spell_[i].Name, sizeof(tname));
        str_trim(tname);
        if (tname[0] != '\0')
            SendUpdateSpellTo(Index, i);
    }
}

void SendUpdateSpellToAll(int SpellNum)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "UPDATESPELL"); PKT_I(pkt, SpellNum);
    char *trimname = str_trim_ret(Spell_[SpellNum].Name);
    PKT_S(pkt, trimname);
    PKT_END(pkt);
    SendDataToAll(pkt);
}

void SendUpdateSpellTo(int Index, int SpellNum)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "UPDATESPELL"); PKT_I(pkt, SpellNum);
    char *trimname = str_trim_ret(Spell_[SpellNum].Name);
    PKT_S(pkt, trimname);
    PKT_END(pkt);
    SendDataTo(Index, pkt);
}

void SendEditSpellTo(int Index, int SpellNum)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "EDITSPELL"); PKT_I(pkt, SpellNum);
    char *trimname = str_trim_ret(Spell_[SpellNum].Name);
    PKT_S(pkt, trimname);
    PKT_I(pkt, Spell_[SpellNum].ClassReq);
    PKT_I(pkt, Spell_[SpellNum].LevelReq);
    PKT_I(pkt, Spell_[SpellNum].Type);
    PKT_I(pkt, Spell_[SpellNum].Data1);
    PKT_I(pkt, Spell_[SpellNum].Data2);
    PKT_I(pkt, Spell_[SpellNum].Data3);
    PKT_END(pkt);
    SendDataTo(Index, pkt);
}

void SendTrade(int Index, int ShopNum)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "TRADE"); PKT_I(pkt, ShopNum); PKT_I(pkt, Shop_[ShopNum].FixesItems);
    for (int i = 1; i <= MAX_TRADES; i++) {
        PKT_I(pkt, Shop_[ShopNum].TradeItem[i].GiveItem);
        PKT_I(pkt, Shop_[ShopNum].TradeItem[i].GiveValue);
        PKT_I(pkt, Shop_[ShopNum].TradeItem[i].GetItem);
        PKT_I(pkt, Shop_[ShopNum].TradeItem[i].GetValue);

        // Send spell class info for spell items
        int x = Shop_[ShopNum].TradeItem[i].GetItem;
        if (x > 0 && x <= MAX_ITEMS && Item_[x].Type == ITEM_TYPE_SPELL) {
            int y = Spell_[Item_[x].Data1].ClassReq;
            if (y == 0) {
                char msg[256];
                snprintf(msg, sizeof(msg), "%s can be used by all classes.", Item_[x].Name);
                PlayerMsg(Index, msg, Yellow);
            } else {
                char msg[256];
                snprintf(msg, sizeof(msg), "%s can only be used by a %s.", Item_[x].Name, GetClassName(y - 1));
                PlayerMsg(Index, msg, Yellow);
            }
        }
    }
    PKT_END(pkt);
    SendDataTo(Index, pkt);
}

void SendPlayerSpells(int Index)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "SPELLS");
    for (int i = 1; i <= MAX_PLAYER_SPELLS; i++) {
        PKT_I(pkt, GetPlayerSpell_(Index, i));
    }
    PKT_END(pkt);
    SendDataTo(Index, pkt);
}

void SendWeatherTo(int Index)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "WEATHER");
    PKT_I(pkt, GameWeather);
    PKT_END(pkt);
    SendDataTo(Index, pkt);
}

void SendWeatherToAll(void)
{
    for (int i = 1; i <= MAX_PLAYERS; i++) {
        if (IsPlaying(i))
            SendWeatherTo(i);
    }
}

void SendTimeTo(int Index)
{
    PKT_INIT(pkt);
    PKT_S(pkt, "TIME");
    PKT_I(pkt, GameTime_);
    PKT_END(pkt);
    SendDataTo(Index, pkt);
}

void SendTimeToAll(void)
{
    for (int i = 1; i <= MAX_PLAYERS; i++) {
        if (IsPlaying(i))
            SendTimeTo(i);
    }
}
