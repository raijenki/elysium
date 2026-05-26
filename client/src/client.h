#ifndef CLIENT_H
#define CLIENT_H

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <stdint.h>
#include <time.h>
#ifdef _WIN32
  #include <winsock2.h>
  #include <ws2tcpip.h>
#else
  #include <unistd.h>
  #include <sys/socket.h>
  #include <netinet/in.h>
  #include <arpa/inet.h>
  #include <fcntl.h>
#endif
#include <errno.h>
#include <ctype.h>

#ifndef MSG_NOSIGNAL
#define MSG_NOSIGNAL 0
#endif

#ifdef _WIN32
  #define CLOSESOCKET(fd) closesocket(fd)
#else
  #define CLOSESOCKET(fd) close(fd)
#endif

#include <CSFML/Graphics.h>
#include <CSFML/Window.h>
#include <CSFML/System.h>
#include <CSFML/Network.h>
#include <CSFML/Audio.h>

// ==================
// Constants
// ==================

#define GAME_PORT 4000
#define GAME_NAME "Mirage Online"
#define MAX_PLAYERS 70
#define MAX_ITEMS 255
#define MAX_NPCS 255
#define MAX_INV 50
#define MAX_MAP_ITEMS 20
#define MAX_MAP_NPCS 5
#define MAX_SHOPS 255
#define MAX_PLAYER_SPELLS 20
#define MAX_SPELLS 255
#define MAX_TRADES 8

#define NO 0
#define YES 1

#define NAME_LENGTH 20
#define MAX_CHARS 3

#define SEX_MALE 0
#define SEX_FEMALE 1

#define MAX_MAPS 1000
#define MAX_MAPX 15
#define MAX_MAPY 11
#define MAP_MORAL_NONE 0
#define MAP_MORAL_SAFE 1

#define PIC_X 32
#define PIC_Y 32

#define TILE_TYPE_WALKABLE 0
#define TILE_TYPE_BLOCKED 1
#define TILE_TYPE_WARP 2
#define TILE_TYPE_ITEM 3
#define TILE_TYPE_NPCAVOID 4
#define TILE_TYPE_KEY 5
#define TILE_TYPE_KEYOPEN 6

#define ITEM_TYPE_NONE 0
#define ITEM_TYPE_WEAPON 1
#define ITEM_TYPE_ARMOR 2
#define ITEM_TYPE_HELMET 3
#define ITEM_TYPE_SHIELD 4
#define ITEM_TYPE_POTIONADDHP 5
#define ITEM_TYPE_POTIONADDMP 6
#define ITEM_TYPE_POTIONADDSP 7
#define ITEM_TYPE_POTIONSUBHP 8
#define ITEM_TYPE_POTIONSUBMP 9
#define ITEM_TYPE_POTIONSUBSP 10
#define ITEM_TYPE_KEY 11
#define ITEM_TYPE_CURRENCY 12
#define ITEM_TYPE_SPELL 13

#define DIR_UP 0
#define DIR_DOWN 1
#define DIR_LEFT 2
#define DIR_RIGHT 3

#define MOVING_WALKING 1
#define MOVING_RUNNING 2

#define WEATHER_NONE 0
#define WEATHER_RAINING 1
#define WEATHER_SNOWING 2

#define TIME_DAY 0
#define TIME_NIGHT 1

#define ADMIN_MONITER 1
#define ADMIN_MAPPER 2
#define ADMIN_DEVELOPER 3
#define ADMIN_CREATOR 4

#define NPC_BEHAVIOR_ATTACKONSIGHT 0
#define NPC_BEHAVIOR_ATTACKWHENATTACKED 1
#define NPC_BEHAVIOR_FRIENDLY 2
#define NPC_BEHAVIOR_SHOPKEEPER 3
#define NPC_BEHAVIOR_GUARD 4

#define SPELL_TYPE_ADDHP 0
#define SPELL_TYPE_ADDMP 1
#define SPELL_TYPE_ADDSP 2
#define SPELL_TYPE_SUBHP 3
#define SPELL_TYPE_SUBMP 4
#define SPELL_TYPE_SUBSP 5
#define SPELL_TYPE_GIVEITEM 6

#define BUFFER_SIZE 10000
#define SEP_CHAR '\0'
#define END_CHAR '\xED'

// Packet builder macros (used in protocol.c and chat.c)
#define PKT_INIT(buf) int _pos = 0; char buf[BUFFER_SIZE]
#define PKT_S(buf, s)       do { _pos = pkt_append(buf, _pos, sizeof(buf), "%s", (s)); } while(0)
#define PKT_I(buf, v)       do { _pos = pkt_append(buf, _pos, sizeof(buf), "%d", (int)(v)); } while(0)
#define PKT_END(buf)        do { _pos = pkt_end(buf, _pos, sizeof(buf)); } while(0)
#define PKT_LEN             _pos

int pkt_append(char *buf, int pos, int bufsize, const char *fmt, ...);
int pkt_end(char *buf, int pos, int bufsize);

// Text colors (QBColor mapping)
#define Black 0
#define Blue 1
#define Green 2
#define Cyan 3
#define Red 4
#define Magenta 5
#define Brown 6
#define Grey 7
#define DarkGrey 8
#define BrightBlue 9
#define BrightGreen 10
#define BrightCyan 11
#define BrightRed 12
#define Pink 13
#define Yellow 14
#define White 15

#define SayColor Grey
#define GlobalColor BrightGreen
#define TellColor Cyan
#define EmoteColor BrightCyan
#define HelpColor Magenta
#define WhoColor Pink
#define JoinLeftColor DarkGrey
#define NpcColor Brown
#define AlertColor Red
#define NewMapColor Pink

// Menu states
#define MENU_STATE_NEWACCOUNT 0
#define MENU_STATE_DELACCOUNT 1
#define MENU_STATE_LOGIN 2
#define MENU_STATE_GETCHARS 3
#define MENU_STATE_NEWCHAR 4
#define MENU_STATE_ADDCHAR 5
#define MENU_STATE_DELCHAR 6
#define MENU_STATE_USECHAR 7
#define MENU_STATE_INIT 8

#define WALK_SPEED 4
#define RUN_SPEED 8

// ==================
// Type Definitions
// ==================

typedef struct {
    uint8_t Num;
    int32_t Value;
    int16_t Dur;
} PlayerInvRec;

typedef struct {
    char Name[NAME_LENGTH + 1];
    uint8_t Class;
    int16_t Sprite;
    uint8_t Level;
    int32_t Exp;
    uint8_t Access;
    uint8_t PK;

    int32_t HP;
    int32_t MP;
    int32_t SP;

    uint8_t STR;
    uint8_t DEF;
    uint8_t SPEED;
    uint8_t MAGI;
    uint8_t POINTS;

    uint8_t ArmorSlot;
    uint8_t WeaponSlot;
    uint8_t HelmetSlot;
    uint8_t ShieldSlot;

    PlayerInvRec Inv[MAX_INV + 1];
    uint8_t Spell[MAX_PLAYER_SPELLS + 1];

    int16_t Map;
    uint8_t x;
    uint8_t y;
    uint8_t Dir;

    // Client-only
    int32_t MaxHP;
    int32_t MaxMP;
    int32_t MaxSP;
    int16_t XOffset;
    int16_t YOffset;
    uint8_t Moving;
    uint8_t Attacking;
    int32_t AttackTimer;
    int32_t MapGetTimer;
    uint8_t CastedSpell;
} PlayerRec;

typedef struct {
    int16_t Ground;
    int16_t Mask;
    int16_t Anim;
    int16_t Fringe;
    uint8_t Type;
    int16_t Data1;
    int16_t Data2;
    int16_t Data3;
} TileRec;

typedef struct {
    char Name[NAME_LENGTH + 1];
    int32_t Revision;
    uint8_t Moral;
    int16_t Up;
    int16_t Down;
    int16_t Left;
    int16_t Right;
    uint8_t Music;
    int16_t BootMap;
    uint8_t BootX;
    uint8_t BootY;
    uint8_t Shop;
    uint8_t Indoors;
    TileRec Tile[MAX_MAPX + 1][MAX_MAPY + 1];
    uint8_t Npc[MAX_MAP_NPCS + 1];
} MapRec;

typedef struct {
    char Name[NAME_LENGTH + 1];
    int16_t Sprite;
    uint8_t STR;
    uint8_t DEF;
    uint8_t SPEED;
    uint8_t MAGI;
    int32_t HP;
    int32_t MP;
    int32_t SP;
} ClassRec;

typedef struct {
    char Name[NAME_LENGTH + 1];
    int16_t Pic;
    uint8_t Type;
    int16_t Data1;
    int16_t Data2;
    int16_t Data3;
} ItemRec;

typedef struct {
    uint8_t Num;
    int32_t Value;
    int16_t Dur;
    uint8_t x;
    uint8_t y;
} MapItemRec;

typedef struct {
    char Name[NAME_LENGTH + 1];
    char AttackSay[256];
    int16_t Sprite;
    int32_t SpawnSecs;
    uint8_t Behavior;
    uint8_t Range;
    int16_t DropChance;
    uint8_t DropItem;
    int16_t DropItemValue;
    uint8_t STR;
    uint8_t DEF;
    uint8_t SPEED;
    uint8_t MAGI;
} NpcRec;

typedef struct {
    uint8_t Num;
    int16_t Target;
    int32_t HP;
    int32_t MP;
    int32_t SP;
    uint8_t x;
    uint8_t y;
    uint8_t Dir;
    // Client-only
    int16_t XOffset;
    int16_t YOffset;
    uint8_t Moving;
    uint8_t Attacking;
    int32_t AttackTimer;
} MapNpcRec;

typedef struct {
    int32_t GiveItem;
    int32_t GiveValue;
    int32_t GetItem;
    int32_t GetValue;
} TradeItemRec;

typedef struct {
    char Name[NAME_LENGTH + 1];
    char JoinSay[256];
    char LeaveSay[256];
    uint8_t FixesItems;
    TradeItemRec TradeItem[MAX_TRADES + 1];
} ShopRec;

typedef struct {
    char Name[NAME_LENGTH + 1];
    uint8_t ClassReq;
    uint8_t LevelReq;
    uint8_t Type;
    int16_t Data1;
    int16_t Data2;
    int16_t Data3;
} SpellRec;

typedef struct {
    uint8_t DoorOpen;
} TempTileRec;

// ==================
// Global Variables
// ==================

extern MapRec Map;
extern MapRec SaveMap;
extern MapItemRec SaveMapItem[MAX_MAP_ITEMS + 1];
extern MapNpcRec SaveMapNpc[MAX_MAP_NPCS + 1];
extern TempTileRec TempTile[MAX_MAPX + 1][MAX_MAPY + 1];
extern PlayerRec Player[MAX_PLAYERS + 1];
extern ClassRec Class[MAX_CHARS + 1];
extern ItemRec Item[MAX_ITEMS + 1];
extern NpcRec Npc[MAX_NPCS + 1];
extern MapItemRec MapItem[MAX_MAP_ITEMS + 1];
extern MapNpcRec MapNpc[MAX_MAP_NPCS + 1];
extern ShopRec Shop[MAX_SHOPS + 1];
extern SpellRec Spell[MAX_SPELLS + 1];

extern int Max_Classes;
extern int MyIndex;
extern int InGame;
extern int GettingMap;
extern int InEditor;
extern int EditorTileX;
extern int EditorTileY;
extern int EditorWarpMap;
extern int EditorWarpX;
extern int EditorWarpY;
extern int GameFPS;
extern int GameWeather;
extern int GameTime;
extern uint8_t MapAnim;
extern int32_t MapAnimTimer;

extern char MyText[256];
extern int InChatMode;

#define MAX_CHAT_LINES 50

typedef struct {
    char text[256];
    int color;
} ChatLine;

extern ChatLine ChatLines[MAX_CHAT_LINES];
extern int ChatLineCount;
extern char PlayerBuffer[BUFFER_SIZE + 1];
extern int PlayerBufferLen;
extern int SocketFd;

// Directions
extern int DirUp, DirDown, DirLeft, DirRight;
extern int ShiftDown, ControlDown;

// Editor flags
extern int InItemsEditor, InNpcEditor, InShopEditor, InSpellEditor;
extern int EditorIndex;

// CSFML globals
extern sfRenderWindow *g_window;
extern sfTexture *texTiles;
extern sfTexture *texSprites;
extern sfTexture *texItems;
extern sfFont *g_font;
extern sfRenderTexture *g_backBuffer;

// ==================
// Utility
// ==================

int32_t GetGameTick(void);
void str_trim(char *str);
void strlcpy_safe(char *dst, const char *src, size_t size);
int file_exists(const char *path);
sfColor QBColor(int color);

// Player getters/setters
const char *GetPlayerName(int Index);
void SetPlayerName(int Index, const char *Name);
int GetPlayerClass(int Index);
void SetPlayerClass(int Index, int ClassNum);
int GetPlayerSprite(int Index);
void SetPlayerSprite(int Index, int Sprite);
int GetPlayerLevel(int Index);
void SetPlayerLevel(int Index, int Level);
int GetPlayerExp(int Index);
void SetPlayerExp(int Index, int Exp);
int GetPlayerAccess(int Index);
void SetPlayerAccess(int Index, int Access);
int GetPlayerPK(int Index);
void SetPlayerPK(int Index, int PK);
int GetPlayerHP(int Index);
void SetPlayerHP(int Index, int HP);
int GetPlayerMP(int Index);
void SetPlayerMP(int Index, int MP);
int GetPlayerSP(int Index);
void SetPlayerSP(int Index, int SP);
int GetPlayerMaxHP(int Index);
int GetPlayerMaxMP(int Index);
int GetPlayerMaxSP(int Index);
int GetPlayerSTR(int Index);
void SetPlayerSTR(int Index, int STR);
int GetPlayerDEF(int Index);
void SetPlayerDEF(int Index, int DEF);
int GetPlayerSPEED(int Index);
void SetPlayerSPEED(int Index, int SPEED);
int GetPlayerMAGI(int Index);
void SetPlayerMAGI(int Index, int MAGI);
int GetPlayerPOINTS(int Index);
void SetPlayerPOINTS(int Index, int POINTS);
int GetPlayerMap(int Index);
void SetPlayerMap(int Index, int MapNum);
int GetPlayerX(int Index);
void SetPlayerX(int Index, int x);
int GetPlayerY(int Index);
void SetPlayerY(int Index, int y);
int GetPlayerDir(int Index);
void SetPlayerDir(int Index, int Dir);
int GetPlayerInvItemNum(int Index, int InvSlot);
void SetPlayerInvItemNum(int Index, int InvSlot, int ItemNum);
int GetPlayerInvItemValue(int Index, int InvSlot);
void SetPlayerInvItemValue(int Index, int InvSlot, int ItemValue);
int GetPlayerInvItemDur(int Index, int InvSlot);
void SetPlayerInvItemDur(int Index, int InvSlot, int ItemDur);
int GetPlayerArmorSlot(int Index);
void SetPlayerArmorSlot(int Index, int InvNum);
int GetPlayerWeaponSlot(int Index);
void SetPlayerWeaponSlot(int Index, int InvNum);
int GetPlayerHelmetSlot(int Index);
void SetPlayerHelmetSlot(int Index, int InvNum);
int GetPlayerShieldSlot(int Index);
void SetPlayerShieldSlot(int Index, int InvNum);

// ==================
// Database
// ==================

void SaveLocalMap(int MapNum);
void LoadMap(int MapNum);
int GetMapRevision(int MapNum);

// ==================
// Network
// ==================

void TcpInit(void);
void TcpDestroy(void);
int ConnectToServer(const char *ip, int port);
int IsConnected(void);
void SendData(const char *Data);
void IncomingData(void);
void HandleData(const char *Data, int DataLen);

// Packet sending helpers
void SendNewAccount(const char *Name, const char *Password);
void SendDelAccount(const char *Name, const char *Password);
void SendLogin(const char *Name, const char *Password);
void SendGetClasses(void);
void SendAddChar(const char *Name, int Sex, int ClassNum, int CharNum);
void SendDelChar(int CharNum);
void SendUseChar(int CharNum);
void SendPlayerMove(int Dir, int Movement);
void SendPlayerDir(int Dir);
void SendAttack(void);
void SendRequestEditMap(void);
void SendWhosOnline(void);
void SendPartyRequest(const char *name);
void SendJoinParty(void);
void SendLeaveParty(void);
void SendKick(const char *name);
void WarpMeTo(const char *name);
void WarpToMe(const char *name);
void WarpTo(int MapNum);
void SendSetSprite(int Sprite);
void SendMapRespawn(void);
void SendMOTDChange(const char *msg);
void SendBanList(void);
void SendBan(const char *name);
void SendRequestEditItem(void);
void SendRequestEditNpc(void);
void SendRequestEditShop(void);
void SendRequestEditSpell(void);
void SendRequestLocation(void);
void SendTradeRequest(void);
void SendAcceptTrade(void);
void SendDeclineTrade(void);
void SendDropItem(int InvNum, int Amount);
void SendUseItem(int InvNum);
void SendCastSpell(int SpellSlot);
void SendUnequipItem(int EquipSlot);
void SendPlayerInfoRequest(const char *name);
void SendStatsRequest(void);

// ==================
// Game Logic
// ==================

void GameInit(void);
void GameLoop(void);
void GameDestroy(void);
void MenuState(int State);
void SetStatus(const char *Caption);
void CheckMovement(void);
void CheckAttack(void);
void ProcessMovement(int Index);
void ProcessNpcMovement(int MapNpcNum);
void AddText(const char *msg, int color);
void BroadcastMsg(const char *msg);
void EmoteMsg(const char *msg);
void PlayerMsg(const char *msg, const char *to);
void GlobalMsg(const char *msg);
void AdminMsg(const char *msg);
void HandleKeypresses(int KeyAscii);

// ==================
// Graphics
// ==================

int GraphicsInit(void);
void GraphicsDestroy(void);
void GraphicsClear(void);
void GraphicsDisplay(void);
void GraphicsDrawSprite(sfTexture *tex, int srcX, int srcY, int srcW, int srcH, int dstX, int dstY, int dstW, int dstH, bool useKey);
void GraphicsDrawRect(int x, int y, int w, int h, sfColor color);
void GraphicsDrawText(const char *text, int x, int y, int size, sfColor color);

// ==================
// UI
// ==================

void UIInit(void);
void UIDestroy(void);
void UIUpdate(void);
void UIDraw(void);
void UIHandleText(int codepoint);
void UIHandleKey(int key);
void UIHandleMouseMove(int x, int y);
void UIHandleMouseButton(int button, int pressed, int x, int y);
void UISetListItems(int screen, int listIndex, const char **items, int count);
void UIAddChatLine(const char *text, int color);

// Screen IDs
#define SCREEN_NONE 0
#define SCREEN_MAINMENU 1
#define SCREEN_LOGIN 2
#define SCREEN_NEWACCOUNT 3
#define SCREEN_DELACCOUNT 4
#define SCREEN_CREDITS 5
#define SCREEN_CHARS 6
#define SCREEN_NEWCHAR 7
#define SCREEN_GAME 8

// Screen switching
void SetScreen(int screen);
int GetScreen(void);

// ==================
// Rendering
// ==================

void BltTile(int x, int y);
void BltFringeTile(int x, int y);
void BltItem(int ItemNum);
void BltPlayer(int Index);
void BltNpc(int MapNpcNum);
void BltPlayerName(int Index);
void RenderGame(void);

// ==================
// Sound
// ==================

void SoundInit(void);
void SoundDestroy(void);
void PlayMidi(const char *song);
void StopMidi(void);
void PlayGameSound(const char *sound);

// ==================
// Config
// ==================

void LoadConfig(void);
void SaveConfig(void);

extern char ConfigServerIP[64];
extern int ConfigServerPort;
extern int ConfigFullscreen;

#endif // CLIENT_H
