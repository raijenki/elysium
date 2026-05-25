#include "client.h"
#include <stdarg.h>

int pkt_append(char *buf, int pos, int bufsize, const char *fmt, ...) {
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

int pkt_end(char *buf, int pos, int bufsize) {
    if (pos + 2 >= bufsize) return pos;
    buf[pos++] = SEP_CHAR;
    buf[pos++] = (char)END_CHAR;
    return pos;
}

// Macros moved to client.h

void SendNewAccount(const char *Name, const char *Password) {
    PKT_INIT(pkt);
    PKT_S(pkt, "newaccount"); PKT_S(pkt, Name); PKT_S(pkt, Password); PKT_END(pkt);
    SendData(pkt);
}

void SendDelAccount(const char *Name, const char *Password) {
    PKT_INIT(pkt);
    PKT_S(pkt, "delaccount"); PKT_S(pkt, Name); PKT_S(pkt, Password); PKT_END(pkt);
    SendData(pkt);
}

void SendLogin(const char *Name, const char *Password) {
    PKT_INIT(pkt);
    PKT_S(pkt, "login"); PKT_S(pkt, Name); PKT_S(pkt, Password);
    PKT_I(pkt, 3); PKT_I(pkt, 0); PKT_I(pkt, 3); // version major/minor/rev
    PKT_END(pkt);
    SendData(pkt);
}

void SendGetClasses(void) {
    PKT_INIT(pkt);
    PKT_S(pkt, "getclasses"); PKT_END(pkt);
    SendData(pkt);
}

void SendAddChar(const char *Name, int Sex, int ClassNum, int CharNum) {
    PKT_INIT(pkt);
    PKT_S(pkt, "addchar"); PKT_S(pkt, Name); PKT_I(pkt, Sex); PKT_I(pkt, ClassNum); PKT_I(pkt, CharNum); PKT_END(pkt);
    SendData(pkt);
}

void SendDelChar(int CharNum) {
    PKT_INIT(pkt);
    PKT_S(pkt, "delchar"); PKT_I(pkt, CharNum); PKT_END(pkt);
    SendData(pkt);
}

void SendUseChar(int CharNum) {
    PKT_INIT(pkt);
    PKT_S(pkt, "usechar"); PKT_I(pkt, CharNum); PKT_END(pkt);
    SendData(pkt);
}

void SendPlayerMove(int Dir, int Movement) {
    PKT_INIT(pkt);
    PKT_S(pkt, "playermove"); PKT_I(pkt, Dir); PKT_I(pkt, Movement); PKT_END(pkt);
    SendData(pkt);
}

void SendPlayerDir(int Dir) {
    PKT_INIT(pkt);
    PKT_S(pkt, "playerdir"); PKT_I(pkt, Dir); PKT_END(pkt);
    SendData(pkt);
}

void SendAttack(void) {
    PKT_INIT(pkt);
    PKT_S(pkt, "attack"); PKT_END(pkt);
    SendData(pkt);
}

void SendRequestEditMap(void) {
    PKT_INIT(pkt);
    PKT_S(pkt, "requesteditmap"); PKT_END(pkt);
    SendData(pkt);
}
