#include "client.h"

struct sockaddr_in serverAddr;

void TcpInit(void) {
#ifdef _WIN32
    WSADATA wsa;
    WSAStartup(MAKEWORD(2, 2), &wsa);
#endif
    memset(PlayerBuffer, 0, sizeof(PlayerBuffer));
    PlayerBufferLen = 0;
    SocketFd = -1;
}

void TcpDestroy(void) {
    if (SocketFd >= 0) {
        CLOSESOCKET(SocketFd);
        SocketFd = -1;
    }
#ifdef _WIN32
    WSACleanup();
#endif
}

int ConnectToServer(const char *ip, int port) {
    SocketFd = socket(AF_INET, SOCK_STREAM, 0);
    if (SocketFd < 0) return 0;

    memset(&serverAddr, 0, sizeof(serverAddr));
    serverAddr.sin_family = AF_INET;
    serverAddr.sin_port = htons(port);
    inet_pton(AF_INET, ip, &serverAddr.sin_addr);

    if (connect(SocketFd, (struct sockaddr *)&serverAddr, sizeof(serverAddr)) < 0) {
        CLOSESOCKET(SocketFd);
        SocketFd = -1;
        return 0;
    }

    // Non-blocking
#ifdef _WIN32
    u_long mode = 1;
    ioctlsocket(SocketFd, FIONBIO, &mode);
#else
    int flags = fcntl(SocketFd, F_GETFL, 0);
    fcntl(SocketFd, F_SETFL, flags | O_NONBLOCK);
#endif
    return 1;
}

int IsConnected(void) {
    return SocketFd >= 0;
}

void SendData(const char *Data) {
    if (SocketFd < 0) return;
    const char *end = memchr(Data, (unsigned char)END_CHAR, BUFFER_SIZE);
    if (!end) return;
    int len = (int)(end - Data) + 1;
    send(SocketFd, Data, len, MSG_NOSIGNAL);
}

void IncomingData(void) {
    if (SocketFd < 0) return;
    char buf[BUFFER_SIZE];
    int nbytes = recv(SocketFd, buf, sizeof(buf) - 1, 0);
    if (nbytes > 0) {
        if (PlayerBufferLen + nbytes > BUFFER_SIZE) {
            PlayerBufferLen = 0; // overflow, reset
        }
        memcpy(PlayerBuffer + PlayerBufferLen, buf, nbytes);
        PlayerBufferLen += nbytes;

        // Extract packets
        int start = 0;
        while (start < PlayerBufferLen) {
            int found = -1;
            for (int j = start; j < PlayerBufferLen; j++) {
                if ((unsigned char)PlayerBuffer[j] == (unsigned char)END_CHAR) {
                    found = j;
                    break;
                }
            }
            if (found < 0) break;

            int pktlen = found - start;
            if (pktlen > 0) {
                char *pkt = malloc(pktlen + 1);
                if (pkt) {
                    memcpy(pkt, PlayerBuffer + start, pktlen);
                    pkt[pktlen] = '\0';
                    HandleData(pkt, pktlen);
                    free(pkt);
                }
            }
            start = found + 1;
        }

        if (start > 0 && start < PlayerBufferLen) {
            memmove(PlayerBuffer, PlayerBuffer + start, PlayerBufferLen - start);
            PlayerBufferLen -= start;
        } else if (start >= PlayerBufferLen) {
            PlayerBufferLen = 0;
        }
    } else if (nbytes == 0) {
        CLOSESOCKET(SocketFd);
        SocketFd = -1;
    } else if (errno != EAGAIN && errno != EWOULDBLOCK) {
        CLOSESOCKET(SocketFd);
        SocketFd = -1;
    }
}
