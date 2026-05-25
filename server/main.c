#include "server.h"
#include <poll.h>
#include <stdarg.h>

// ==================
// Global Variables
// ==================

int Max_Classes = 0;
MapRec Map_[MAX_MAPS + 1];
TempTileRec TempTile[MAX_MAPS + 1];
int32_t PlayersOnMap[MAX_MAPS + 1];
AccountRec Player[MAX_PLAYERS + 1];
ClassRec *Class = NULL;
ItemRec Item_[MAX_ITEMS + 1];
NpcRec Npc_[MAX_NPCS + 1];
MapItemRec MapItem_[MAX_MAPS + 1][MAX_MAP_ITEMS + 1];
MapNpcRec MapNpc_[MAX_MAPS + 1][MAX_MAP_NPCS + 1];
ShopRec Shop_[MAX_SHOPS + 1];
SpellRec Spell_[MAX_SPELLS + 1];
GuildRec Guild[MAX_GUILDS + 1];

int32_t SpawnSeconds = 0;
int32_t GameWeather = WEATHER_NONE;
int32_t WeatherSeconds = 0;
int32_t GameTime_ = TIME_DAY;
int32_t TimeSeconds = 0;
int32_t KeyTimer = 0;
int32_t GiveHPTimer = 0;
int32_t GiveNPCHPTimer = 0;
int ServerLog = 0;

int listen_fd = -1;
char app_path[512];
volatile int server_running = 1;

// ==================
// Utility Functions
// ==================

int32_t GetTickCount(void) {
    struct timespec ts;
    clock_gettime(CLOCK_MONOTONIC, &ts);
    return (int32_t)(ts.tv_sec * 1000 + ts.tv_nsec / 1000000);
}

void str_trim(char *str) {
    if (!str) return;
    int len = strlen(str);
    while (len > 0 && (str[len-1] == ' ' || str[len-1] == '\t' || str[len-1] == '\r' || str[len-1] == '\n')) {
        str[--len] = '\0';
    }
    // Trim leading
    char *start = str;
    while (*start == ' ' || *start == '\t') start++;
    if (start != str) memmove(str, start, strlen(start) + 1);
}

char *str_trim_ret(const char *str) {
    static char buf[256];
    if (!str) { buf[0] = '\0'; return buf; }
    strncpy(buf, str, sizeof(buf) - 1);
    buf[sizeof(buf) - 1] = '\0';
    str_trim(buf);
    return buf;
}

void strlcpy_safe(char *dst, const char *src, size_t size) {
    if (size == 0) return;
    strncpy(dst, src ? src : "", size - 1);
    dst[size - 1] = '\0';
}

void to_lower(char *s) {
    for (; *s; s++) *s = tolower((unsigned char)*s);
}

void set_status(const char *msg) {
    printf("[STATUS] %s\n", msg);
    fflush(stdout);
}

void text_add(const char *msg) {
    printf("[SERVER] %s\n", msg);
    fflush(stdout);
}

static int pkt_append(char *buf, int pos, int bufsize, const char *fmt, ...) {
    if (pos >= bufsize - 2) return pos;
    va_list args;
    va_start(args, fmt);
    int written = vsnprintf(buf + pos, bufsize - pos - 1, fmt, args);
    va_end(args);
    if (written < 0) return pos;
    pos += written;
    if (pos < bufsize - 1) {
        buf[pos++] = SEP_CHAR;
    }
    return pos;
}

// ==================
// Signal Handler
// ==================

static void signal_handler(int sig) {
    (void)sig;
    server_running = 0;
}

// ==================
// Server Init/Destroy
// ==================

void InitServer(void) {
    srand(time(NULL));

    GameWeather = WEATHER_NONE;
    WeatherSeconds = 0;
    GameTime_ = TIME_DAY;
    TimeSeconds = 0;

    // Create directories
    char path[600];
    snprintf(path, sizeof(path), "%s/maps", app_path);
    mkdir(path, 0755);
    snprintf(path, sizeof(path), "%s/accounts", app_path);
    mkdir(path, 0755);

    ServerLog = 0;

    // Init player array
    for (int i = 1; i <= MAX_PLAYERS; i++) {
        set_status("Initializing player array...");
        ClearPlayer(i);
    }

    set_status("Clearing temp tile fields...");
    ClearTempTile();
    set_status("Clearing maps...");
    ClearMaps();
    set_status("Clearing map items...");
    ClearMapItems();
    set_status("Clearing map npcs...");
    ClearMapNpcs();
    set_status("Clearing npcs...");
    ClearNpcs();
    set_status("Clearing items...");
    ClearItems();
    set_status("Clearing shops...");
    ClearShops();
    set_status("Clearing spells...");
    ClearSpells();
    set_status("Loading classes...");
    LoadClasses();
    set_status("Loading maps...");
    LoadMaps();
    set_status("Loading items...");
    LoadItems();
    set_status("Loading npcs...");
    LoadNpcs();
    set_status("Loading shops...");
    LoadShops();
    set_status("Loading spells...");
    LoadSpells();
    set_status("Spawning map items...");
    SpawnAllMapsItems();
    set_status("Spawning map npcs...");
    SpawnAllMapNpcs();

    // Check charlist exists
    snprintf(path, sizeof(path), "%s/accounts/charlist.txt", app_path);
    if (!file_exists(path)) {
        FILE *f = fopen(path, "w");
        if (f) fclose(f);
    }

    // Create listening socket
    listen_fd = socket(AF_INET, SOCK_STREAM, 0);
    if (listen_fd < 0) {
        perror("socket");
        exit(1);
    }

    int opt = 1;
    setsockopt(listen_fd, SOL_SOCKET, SO_REUSEADDR, &opt, sizeof(opt));

    struct sockaddr_in addr;
    memset(&addr, 0, sizeof(addr));
    addr.sin_family = AF_INET;
    addr.sin_addr.s_addr = INADDR_ANY;
    addr.sin_port = htons(GAME_PORT);

    if (bind(listen_fd, (struct sockaddr *)&addr, sizeof(addr)) < 0) {
        perror("bind");
        exit(1);
    }

    if (listen(listen_fd, 10) < 0) {
        perror("listen");
        exit(1);
    }

    // Set non-blocking
    int flags = fcntl(listen_fd, F_GETFL, 0);
    fcntl(listen_fd, F_SETFL, flags | O_NONBLOCK);

    UpdateCaption();

    SpawnSeconds = 0;
    set_status("Server started successfully!");
    printf("===========================================\n");
    printf("  %s Server - Port %d\n", GAME_NAME, GAME_PORT);
    printf("  Type messages to broadcast, 'quit' to exit\n");
    printf("===========================================\n");
}

void DestroyServer(void) {
    set_status("Saving players online...");
    SaveAllPlayersOnline();
    set_status("Clearing maps...");
    ClearMaps();
    set_status("Clearing map items...");
    ClearMapItems();
    set_status("Clearing map npcs...");
    ClearMapNpcs();
    set_status("Clearing npcs...");
    ClearNpcs();
    set_status("Clearing items...");
    ClearItems();
    set_status("Clearing shops...");
    ClearShops();

    for (int i = 1; i <= MAX_PLAYERS; i++) {
        if (Player[i].socket_fd > 0) {
            close(Player[i].socket_fd);
            Player[i].socket_fd = -1;
        }
    }

    if (listen_fd > 0) {
        close(listen_fd);
        listen_fd = -1;
    }

    if (Class) {
        free(Class);
        Class = NULL;
    }

    set_status("Server shut down.");
}

// ==================
// Server Logic
// ==================

void ServerLogic(void) {
    // Check for disconnections
    for (int i = 1; i <= MAX_PLAYERS; i++) {
        if (Player[i].socket_fd > 0) {
            // Check if socket is still alive with a zero-byte peek
            char tmp;
            int ret = recv(Player[i].socket_fd, &tmp, 1, MSG_PEEK | MSG_DONTWAIT);
            if (ret == 0) {
                // Connection closed
                CloseSocket(i);
            }
        }
    }

    CheckGiveHP();
    GameAI();
}

void CheckSpawnMapItems(void) {
    SpawnSeconds++;

    if (SpawnSeconds >= 120) {
        for (int y = 1; y <= MAX_MAPS; y++) {
            if (!PlayersOnMap[y]) {
                for (int x = 1; x <= MAX_MAP_ITEMS; x++) {
                    ClearMapItem(x, y);
                }
                SpawnMapItems(y);
                SendMapItemsToAll(y);
            }
        }
        SpawnSeconds = 0;
    }
}

void CheckGiveHP(void) {
    if (GetTickCount() > GiveHPTimer + 10000) {
        for (int i = 1; i <= MAX_PLAYERS; i++) {
            if (IsPlaying(i)) {
                SetPlayerHP(i, GetPlayerHP(i) + GetPlayerHPRegen(i));
                SendHP(i);
                SetPlayerMP(i, GetPlayerMP(i) + GetPlayerMPRegen(i));
                SendMP(i);
                SetPlayerSP(i, GetPlayerSP(i) + GetPlayerSPRegen(i));
                SendSP(i);
            }
        }
        GiveHPTimer = GetTickCount();
    }
}

void PlayerSaveTimer(void) {
    static int MinPassed = 0;

    MinPassed++;
    if (MinPassed >= 10) {
        if (TotalOnlinePlayers() > 0) {
            text_add("Saving all online players...");
            GlobalMsg("Saving all online players...", Pink);
            for (int i = 1; i <= MAX_PLAYERS; i++) {
                if (IsPlaying(i)) {
                    SavePlayer(i);
                }
            }
        }
        MinPassed = 0;
    }
}

// ==================
// Main Loop
// ==================

static void handle_stdin(void) {
    char line[512];
    if (fgets(line, sizeof(line), stdin)) {
        // Remove newline
        line[strcspn(line, "\n")] = '\0';
        if (strlen(line) == 0) return;

        if (strcmp(line, "quit") == 0 || strcmp(line, "exit") == 0) {
            server_running = 0;
            return;
        }
        if (strcmp(line, "log") == 0) {
            ServerLog = !ServerLog;
            printf("Server logging %s\n", ServerLog ? "enabled" : "disabled");
            return;
        }
        if (strcmp(line, "status") == 0) {
            printf("Online players: %d\n", TotalOnlinePlayers());
            return;
        }
        if (strcmp(line, "save") == 0) {
            SaveAllPlayersOnline();
            printf("All players saved.\n");
            return;
        }
        if (strcmp(line, "reload") == 0) {
            LoadClasses();
            printf("All classes reloaded.\n");
            return;
        }

        // Broadcast message
        GlobalMsg(line, White);
        char msg[600];
        snprintf(msg, sizeof(msg), "Server: %s", line);
        text_add(msg);
    }
}

int main(int argc, char *argv[]) {
    (void)argc;
    (void)argv;

    // Determine app path
    if (getcwd(app_path, sizeof(app_path)) == NULL) {
        strcpy(app_path, ".");
    }

    signal(SIGINT, signal_handler);
    signal(SIGTERM, signal_handler);
    signal(SIGPIPE, SIG_IGN);

    InitServer();

    // Timer tracking
    int32_t lastGameAI = GetTickCount();
    int32_t lastSpawnCheck = GetTickCount();
    int32_t lastSaveTimer = GetTickCount();

    // Make stdin non-blocking
    int stdin_flags = fcntl(STDIN_FILENO, F_GETFL, 0);
    fcntl(STDIN_FILENO, F_SETFL, stdin_flags | O_NONBLOCK);

    while (server_running) {
        // Build poll set
        struct pollfd fds[MAX_PLAYERS + 2];
        int nfds = 0;

        // Listen socket
        fds[nfds].fd = listen_fd;
        fds[nfds].events = POLLIN;
        nfds++;

        // Stdin
        fds[nfds].fd = STDIN_FILENO;
        fds[nfds].events = POLLIN;
        nfds++;

        // Player sockets
        for (int i = 1; i <= MAX_PLAYERS; i++) {
            if (Player[i].socket_fd > 0) {
                fds[nfds].fd = Player[i].socket_fd;
                fds[nfds].events = POLLIN;
                nfds++;
            }
        }

        int ret = poll(fds, nfds, 100); // 100ms timeout
        if (ret < 0) {
            if (errno == EINTR) continue;
            perror("poll");
            break;
        }

        // Process events
        for (int f = 0; f < nfds; f++) {
            if (!(fds[f].revents & (POLLIN | POLLHUP | POLLERR))) continue;

            if (fds[f].fd == listen_fd) {
                AcceptConnection();
            } else if (fds[f].fd == STDIN_FILENO) {
                handle_stdin();
            } else {
                // Find which player this socket belongs to
                for (int i = 1; i <= MAX_PLAYERS; i++) {
                    if (Player[i].socket_fd == fds[f].fd) {
                        if (fds[f].revents & (POLLHUP | POLLERR)) {
                            CloseSocket(i);
                        } else {
                            IncomingData(i);
                        }
                        break;
                    }
                }
            }
        }

        // Timer-based tasks
        int32_t now = GetTickCount();

        // Game AI every 500ms
        if (now - lastGameAI >= 500) {
            ServerLogic();
            lastGameAI = now;
        }

        // Spawn check every 1000ms
        if (now - lastSpawnCheck >= 1000) {
            CheckSpawnMapItems();
            lastSpawnCheck = now;
        }

        // Player save every 60000ms (1 minute)
        if (now - lastSaveTimer >= 60000) {
            PlayerSaveTimer();
            lastSaveTimer = now;
        }
    }

    DestroyServer();
    return 0;
}
