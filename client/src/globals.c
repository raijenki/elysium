#include "client.h"

// World data
MapRec Map;
MapRec SaveMap;
MapItemRec SaveMapItem[MAX_MAP_ITEMS + 1];
MapNpcRec SaveMapNpc[MAX_MAP_NPCS + 1];
TempTileRec TempTile[MAX_MAPX + 1][MAX_MAPY + 1];
PlayerRec Player[MAX_PLAYERS + 1];
ClassRec Class[MAX_CHARS + 1];
ItemRec Item[MAX_ITEMS + 1];
NpcRec Npc[MAX_NPCS + 1];
MapItemRec MapItem[MAX_MAP_ITEMS + 1];
MapNpcRec MapNpc[MAX_MAP_NPCS + 1];
ShopRec Shop[MAX_SHOPS + 1];
SpellRec Spell[MAX_SPELLS + 1];

// State
int Max_Classes = 0;
int MyIndex = 0;
int InGame = 0;
int GettingMap = 1;
int InEditor = 0;
int EditorTileX = 0;
int EditorTileY = 0;
int EditorWarpMap = 0;
int EditorWarpX = 0;
int EditorWarpY = 0;
int GameFPS = 0;
int GameWeather = WEATHER_NONE;
int GameTime = TIME_DAY;
uint8_t MapAnim = 0;
int32_t MapAnimTimer = 0;

char MyText[256] = "";
int InChatMode = 0;
ChatLine ChatLines[MAX_CHAT_LINES];
int ChatLineCount = 0;

void AddText(const char *msg, int color) {
    if (ChatLineCount >= MAX_CHAT_LINES) {
        // Shift lines up
        for (int i = 0; i < MAX_CHAT_LINES - 1; i++) {
            ChatLines[i] = ChatLines[i + 1];
        }
        ChatLineCount = MAX_CHAT_LINES - 1;
    }
    strlcpy_safe(ChatLines[ChatLineCount].text, msg, sizeof(ChatLines[ChatLineCount].text));
    ChatLines[ChatLineCount].color = color;
    ChatLineCount++;
}
char PlayerBuffer[BUFFER_SIZE + 1] = "";
int PlayerBufferLen = 0;
int SocketFd = -1;

// Input state
int DirUp = 0, DirDown = 0, DirLeft = 0, DirRight = 0;
int ShiftDown = 0, ControlDown = 0;

// Editor flags
int InItemsEditor = 0, InNpcEditor = 0, InShopEditor = 0, InSpellEditor = 0;
int EditorIndex = 0;

// Utility
#ifdef _WIN32
  #include <io.h>
#endif

int32_t GetGameTick(void) {
#ifdef _WIN32
    return (int32_t)GetTickCount();
#else
    struct timespec ts;
    clock_gettime(CLOCK_MONOTONIC, &ts);
    return (int32_t)(ts.tv_sec * 1000 + ts.tv_nsec / 1000000);
#endif
}

void str_trim(char *str) {
    if (!str) return;
    int len = (int)strlen(str);
    while (len > 0 && (str[len-1] == ' ' || str[len-1] == '\t' || str[len-1] == '\r' || str[len-1] == '\n')) {
        str[--len] = '\0';
    }
    char *start = str;
    while (*start == ' ' || *start == '\t') start++;
    if (start != str) memmove(str, start, strlen(start) + 1);
}

void strlcpy_safe(char *dst, const char *src, size_t size) {
    if (size == 0) return;
    strncpy(dst, src ? src : "", size - 1);
    dst[size - 1] = '\0';
}

int file_exists(const char *path) {
#ifdef _WIN32
    return _access(path, 0) == 0;
#else
    return access(path, F_OK) == 0;
#endif
}

sfColor QBColor(int color) {
    switch (color) {
        case Black:       return sfBlack;
        case Blue:        return sfColor_fromRGB(0, 0, 170);
        case Green:       return sfColor_fromRGB(0, 170, 0);
        case Cyan:        return sfColor_fromRGB(0, 170, 170);
        case Red:         return sfColor_fromRGB(170, 0, 0);
        case Magenta:     return sfColor_fromRGB(170, 0, 170);
        case Brown:       return sfColor_fromRGB(170, 85, 0);
        case Grey:        return sfColor_fromRGB(170, 170, 170);
        case DarkGrey:    return sfColor_fromRGB(85, 85, 85);
        case BrightBlue:  return sfColor_fromRGB(85, 85, 255);
        case BrightGreen: return sfColor_fromRGB(85, 255, 85);
        case BrightCyan:  return sfColor_fromRGB(85, 255, 255);
        case BrightRed:   return sfColor_fromRGB(255, 85, 85);
        case Pink:        return sfColor_fromRGB(255, 85, 255);
        case Yellow:      return sfColor_fromRGB(255, 255, 85);
        case White:       return sfWhite;
        default:          return sfWhite;
    }
}
