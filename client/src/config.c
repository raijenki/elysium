#include "client.h"

char ConfigServerIP[64] = "127.0.0.1";
int ConfigServerPort = GAME_PORT;
int ConfigFullscreen = 0;

void LoadConfig(void) {
    FILE *f = fopen("config.ini", "r");
    if (!f) return;
    char line[256];
    while (fgets(line, sizeof(line), f)) {
        line[strcspn(line, "\r\n")] = '\0';
        char key[64], value[192];
        if (sscanf(line, "%63[^=]=%191s", key, value) == 2) {
            str_trim(key);
            str_trim(value);
            if (strcmp(key, "ServerIP") == 0) {
                strlcpy_safe(ConfigServerIP, value, sizeof(ConfigServerIP));
            } else if (strcmp(key, "ServerPort") == 0) {
                ConfigServerPort = atoi(value);
            } else if (strcmp(key, "Fullscreen") == 0) {
                ConfigFullscreen = atoi(value);
            }
        }
    }
    fclose(f);
}

void SaveConfig(void) {
    FILE *f = fopen("config.ini", "w");
    if (!f) return;
    fprintf(f, "ServerIP=%s\n", ConfigServerIP);
    fprintf(f, "ServerPort=%d\n", ConfigServerPort);
    fprintf(f, "Fullscreen=%d\n", ConfigFullscreen);
    fclose(f);
}
