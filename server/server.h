#ifndef SERVER_H
#define SERVER_H

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <stdint.h>
#include <time.h>
#include <unistd.h>
#include <sys/socket.h>
#include <sys/types.h>
#include <sys/stat.h>
#include <sys/time.h>
#include <netinet/in.h>
#include <arpa/inet.h>
#include <fcntl.h>
#include <errno.h>
#include <ctype.h>
#include <signal.h>

// Portable socket flag fallbacks
#ifndef MSG_NOSIGNAL
#define MSG_NOSIGNAL 0
#endif
#ifndef MSG_DONTWAIT
#define MSG_DONTWAIT 0
#endif

// Winsock globals
#define GAME_PORT 4000

// General constants
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
#define MAX_GUILDS 20
#define MAX_GUILD_MEMBERS 10

#define NO 0
#define YES 1

// Account constants
#define NAME_LENGTH 20
#define MAX_CHARS 3

// Sex constants
#define SEX_MALE 0
#define SEX_FEMALE 1

// Map constants
#define MAX_MAPS 1000
#define MAX_MAPX 15
#define MAX_MAPY 11
#define MAP_MORAL_NONE 0
#define MAP_MORAL_SAFE 1

// Image constants
#define PIC_X 32
#define PIC_Y 32

// Tile constants
#define TILE_TYPE_WALKABLE 0
#define TILE_TYPE_BLOCKED 1
#define TILE_TYPE_WARP 2
#define TILE_TYPE_ITEM 3
#define TILE_TYPE_NPCAVOID 4
#define TILE_TYPE_KEY 5
#define TILE_TYPE_KEYOPEN 6

// Item constants
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

// Direction constants
#define DIR_UP 0
#define DIR_DOWN 1
#define DIR_LEFT 2
#define DIR_RIGHT 3

// Constants for player movement
#define MOVING_WALKING 1
#define MOVING_RUNNING 2

// Weather constants
#define WEATHER_NONE 0
#define WEATHER_RAINING 1
#define WEATHER_SNOWING 2

// Time constants
#define TIME_DAY 0
#define TIME_NIGHT 1

// Admin constants
#define ADMIN_MONITER 1
#define ADMIN_MAPPER 2
#define ADMIN_DEVELOPER 3
#define ADMIN_CREATOR 4

// NPC constants
#define NPC_BEHAVIOR_ATTACKONSIGHT 0
#define NPC_BEHAVIOR_ATTACKWHENATTACKED 1
#define NPC_BEHAVIOR_FRIENDLY 2
#define NPC_BEHAVIOR_SHOPKEEPER 3
#define NPC_BEHAVIOR_GUARD 4

// Spell constants
#define SPELL_TYPE_ADDHP 0
#define SPELL_TYPE_ADDMP 1
#define SPELL_TYPE_ADDSP 2
#define SPELL_TYPE_SUBHP 3
#define SPELL_TYPE_SUBMP 4
#define SPELL_TYPE_SUBSP 5
#define SPELL_TYPE_GIVEITEM 6

// Target type constants
#define TARGET_TYPE_PLAYER 0
#define TARGET_TYPE_NPC 1

// Network
#define BUFFER_SIZE 10000
#define SEP_CHAR '\0'
#define END_CHAR '\xED'

// Version constants
#define CLIENT_MAJOR 3
#define CLIENT_MINOR 0
#define CLIENT_REVISION 3

// Database constants
#define START_MAP 1
#define START_X (MAX_MAPX / 2)
#define START_Y (MAX_MAPY / 2)
#define ADMIN_LOG "admin.txt"
#define PLAYER_LOG "player.txt"

// Text color constants
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
#define GlobalColor BrightBlue
#define BroadcastColor Pink
#define TellColor BrightGreen
#define EmoteColor BrightCyan
#define AdminColor BrightCyan
#define HelpColor Pink
#define WhoColor Pink
#define JoinLeftColor DarkGrey
#define NpcColor Brown
#define AlertColor Red
#define NewMapColor Pink

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
    uint8_t Sex;
    uint8_t Class;
    int16_t Sprite;
    uint8_t Level;
    int32_t Exp;
    uint8_t Access;
    uint8_t PK;
    uint8_t Guild;

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

    PlayerInvRec Inv[MAX_INV + 1];     // 1-based
    uint8_t Spell[MAX_PLAYER_SPELLS + 1]; // 1-based

    int16_t Map;
    uint8_t x;
    uint8_t y;
    uint8_t Dir;
} PlayerRec;

typedef struct {
    char Login[NAME_LENGTH + 1];
    char Password[NAME_LENGTH + 1];

    PlayerRec Char[MAX_CHARS + 1]; // 0 to MAX_CHARS

    char Buffer[BUFFER_SIZE + 1];
    char IncBuffer[BUFFER_SIZE + 1];
    uint8_t CharNum;
    int InGame;
    int32_t AttackTimer;
    int32_t DataTimer;
    int32_t DataBytes;
    int32_t DataPackets;
    int32_t PartyPlayer;
    uint8_t InParty;
    uint8_t TargetType;
    uint8_t Target;
    uint8_t CastedSpell;
    uint8_t PartyStarter;
    uint8_t GettingMap;

    // Socket
    int socket_fd;
    char remote_ip[46];
} AccountRec;

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
    TileRec Tile[MAX_MAPX + 1][MAX_MAPY + 1]; // 0-based
    uint8_t Npc[MAX_MAP_NPCS + 1]; // 1-based
} MapRec;

typedef struct {
    char Name[NAME_LENGTH + 1];
    int16_t Sprite;
    uint8_t STR;
    uint8_t DEF;
    uint8_t SPEED;
    uint8_t MAGI;
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
    int16_t Num;
    int16_t Target;
    int32_t HP;
    int32_t MP;
    int32_t SP;
    uint8_t x;
    uint8_t y;
    int16_t Dir;
    int32_t SpawnWait;
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
    TradeItemRec TradeItem[MAX_TRADES + 1]; // 1-based
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
    uint8_t DoorOpen[MAX_MAPX + 1][MAX_MAPY + 1];
    int32_t DoorTimer;
} TempTileRec;

typedef struct {
    char Name[NAME_LENGTH + 1];
    char Founder[NAME_LENGTH + 1];
    char Member[MAX_GUILD_MEMBERS + 1][NAME_LENGTH + 1];
} GuildRec;

// ==================
// Global Variables
// ==================

extern int Max_Classes;
extern MapRec Map_[MAX_MAPS + 1];
extern TempTileRec TempTile[MAX_MAPS + 1];
extern int32_t PlayersOnMap[MAX_MAPS + 1];
extern AccountRec Player[MAX_PLAYERS + 1];
extern ClassRec *Class;
extern ItemRec Item_[MAX_ITEMS + 1];
extern NpcRec Npc_[MAX_NPCS + 1];
extern MapItemRec MapItem_[MAX_MAPS + 1][MAX_MAP_ITEMS + 1];
extern MapNpcRec MapNpc_[MAX_MAPS + 1][MAX_MAP_NPCS + 1];
extern ShopRec Shop_[MAX_SHOPS + 1];
extern SpellRec Spell_[MAX_SPELLS + 1];
extern GuildRec Guild[MAX_GUILDS + 1];

extern int32_t SpawnSeconds;
extern int32_t GameWeather;
extern int32_t WeatherSeconds;
extern int32_t GameTime_;
extern int32_t TimeSeconds;
extern int32_t KeyTimer;
extern int32_t GiveHPTimer;
extern int32_t GiveNPCHPTimer;
extern int ServerLog;

extern int listen_fd;
extern char app_path[512];
extern volatile int server_running;

// ==================
// Utility
// ==================

int32_t GetTickCount(void);
void str_trim(char *str);
char *str_trim_ret(const char *str);
void strlcpy_safe(char *dst, const char *src, size_t size);
void to_lower(char *s);
int file_exists(const char *path);
void set_status(const char *msg);
void text_add(const char *msg);

// ==================
// INI File Functions
// ==================

char *get_var(const char *file, const char *header, const char *var);
void put_var(const char *file, const char *header, const char *var, const char *value);

// ==================
// Types (clear/get/set)
// ==================

void ClearTempTile(void);
void ClearClasses(void);
void ClearPlayer(int Index);
void ClearChar(int Index, int CharNum);
void ClearItem(int Index);
void ClearItems(void);
void ClearNpc(int Index);
void ClearNpcs(void);
void ClearMapItem(int Index, int MapNum);
void ClearMapItems(void);
void ClearMapNpc(int Index, int MapNum);
void ClearMapNpcs(void);
void ClearMap(int MapNum);
void ClearMaps(void);
void ClearShop(int Index);
void ClearShops(void);
void ClearSpell(int Index);
void ClearSpells(void);

const char *GetPlayerLogin(int Index);
void SetPlayerLogin(int Index, const char *Login);
const char *GetPlayerPassword(int Index);
void SetPlayerPassword(int Index, const char *Password);
const char *GetPlayerName(int Index);
void SetPlayerName(int Index, const char *Name);
int GetPlayerClass(int Index);
void SetPlayerClass(int Index, int ClassNum);
int GetPlayerSprite(int Index);
void SetPlayerSprite(int Index, int Sprite);
int GetPlayerLevel(int Index);
void SetPlayerLevel(int Index, int Level);
int GetPlayerNextLevel(int Index);
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
const char *GetClassName(int ClassNum);
int GetClassMaxHP(int ClassNum);
int GetClassMaxMP(int ClassNum);
int GetClassMaxSP(int ClassNum);
int GetClassSTR(int ClassNum);
int GetClassDEF(int ClassNum);
int GetClassSPEED(int ClassNum);
int GetClassMAGI(int ClassNum);
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
const char *GetPlayerIP(int Index);
int GetPlayerInvItemNum(int Index, int InvSlot);
void SetPlayerInvItemNum(int Index, int InvSlot, int ItemNum);
int GetPlayerInvItemValue(int Index, int InvSlot);
void SetPlayerInvItemValue(int Index, int InvSlot, int ItemValue);
int GetPlayerInvItemDur(int Index, int InvSlot);
void SetPlayerInvItemDur(int Index, int InvSlot, int ItemDur);
int GetPlayerSpell_(int Index, int SpellSlot);
void SetPlayerSpell_(int Index, int SpellSlot, int SpellNum);
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

void SavePlayer(int Index);
void LoadPlayer(int Index, const char *Name);
int AccountExist(const char *Name);
int CharExist(int Index, int CharNum);
int PasswordOK(const char *Name, const char *Password);
void AddAccount(int Index, const char *Name, const char *Password);
void AddChar(int Index, const char *Name, uint8_t Sex, uint8_t ClassNum, int CharNum);
void DelChar(int Index, int CharNum);
int FindChar(const char *Name);
void SaveAllPlayersOnline(void);
void LoadClasses(void);
void SaveClasses(void);
void CheckClasses(void);
void SaveItems(void);
void SaveItem(int ItemNum);
void LoadItems(void);
void CheckItems(void);
void SaveShops(void);
void SaveShop(int ShopNum);
void LoadShops(void);
void CheckShops(void);
void SaveSpell(int SpellNum);
void SaveSpells(void);
void LoadSpells(void);
void CheckSpells(void);
void SaveNpcs(void);
void SaveNpc(int NpcNum);
void LoadNpcs(void);
void CheckNpcs(void);
void SaveMap(int MapNum);
void SaveMaps(void);
void LoadMaps(void);
void CheckMaps(void);
void AddLog(const char *Text, const char *FN);
void BanIndex(int BanPlayerIndex, int BannedByIndex);
void DeleteName(const char *Name);

// ==================
// Network / ServerTCP
// ==================

void UpdateCaption(void);
int IsConnected(int Index);
int IsPlaying(int Index);
int IsLoggedIn(int Index);
int IsMultiAccounts(const char *Login);
int IsMultiIPOnline(const char *IP);
int IsBanned(const char *IP);
void SendDataTo(int Index, const char *Data);
void SendDataToAll(const char *Data);
void SendDataToAllBut(int Index, const char *Data);
void SendDataToMap(int MapNum, const char *Data);
void SendDataToMapBut(int Index, int MapNum, const char *Data);
void GlobalMsg(const char *Msg, uint8_t Color);
void AdminMsg(const char *Msg, uint8_t Color);
void PlayerMsg(int Index, const char *Msg, uint8_t Color);
void MapMsg(int MapNum, const char *Msg, uint8_t Color);
void AlertMsg(int Index, const char *Msg);
void HackingAttempt(int Index, const char *Reason);
void AcceptConnection(void);
void SocketConnected(int Index);
void IncomingData(int Index);
void HandleData(int Index, const char *Data);
void CloseSocket(int Index);
void SendWhosOnline(int Index);
void SendChars(int Index);
void SendJoinMap(int Index);
void SendLeaveMap(int Index, int MapNum);
void SendPlayerData(int Index);
void SendMap(int Index, int MapNum);
void SendMapItemsTo(int Index, int MapNum);
void SendMapItemsToAll(int MapNum);
void SendMapNpcsTo(int Index, int MapNum);
void SendMapNpcsToMap(int MapNum);
void SendItems(int Index);
void SendNpcs(int Index);
void SendInventory(int Index);
void SendInventoryUpdate(int Index, int InvSlot);
void SendWornEquipment(int Index);
void SendHP(int Index);
void SendMP(int Index);
void SendSP(int Index);
void SendStats(int Index);
void SendWelcome(int Index);
void SendClasses(int Index);
void SendNewCharClasses(int Index);
void SendLeftGame(int Index);
void SendPlayerXY(int Index);
void SendUpdateItemToAll(int ItemNum);
void SendUpdateItemTo(int Index, int ItemNum);
void SendEditItemTo(int Index, int ItemNum);
void SendUpdateNpcToAll(int NpcNum);
void SendUpdateNpcTo(int Index, int NpcNum);
void SendEditNpcTo(int Index, int NpcNum);
void SendShops_(int Index);
void SendUpdateShopToAll(int ShopNum);
void SendUpdateShopTo(int Index, int ShopNum);
void SendEditShopTo(int Index, int ShopNum);
void SendSpells_(int Index);
void SendUpdateSpellToAll(int SpellNum);
void SendUpdateSpellTo(int Index, int SpellNum);
void SendEditSpellTo(int Index, int SpellNum);
void SendTrade(int Index, int ShopNum);
void SendPlayerSpells(int Index);
void SendWeatherTo(int Index);
void SendWeatherToAll(void);
void SendTimeTo(int Index);
void SendTimeToAll(void);

// ==================
// Game Logic
// ==================

int GetPlayerDamage(int Index);
int GetPlayerProtection(int Index);
int FindOpenPlayerSlot(void);
int FindOpenInvSlot(int Index, int ItemNum);
int FindOpenMapItemSlot(int MapNum);
int FindOpenSpellSlot(int Index);
int HasSpell(int Index, int SpellNum);
int TotalOnlinePlayers(void);
int FindPlayer(const char *Name);
int HasItem(int Index, int ItemNum);
void TakeItem_(int Index, int ItemNum, int ItemVal);
void GiveItem_(int Index, int ItemNum, int ItemVal);
void SpawnItem(int ItemNum, int ItemVal, int MapNum, int x, int y);
void SpawnItemSlot(int MapItemSlot, int ItemNum, int ItemVal, int ItemDur, int MapNum, int x, int y);
void SpawnAllMapsItems(void);
void SpawnMapItems(int MapNum);
void PlayerMapGetItem(int Index);
void PlayerMapDropItem(int Index, int InvNum, int Amount);
void SpawnNpc_(int MapNpcNum, int MapNum);
void SpawnMapNpcs(int MapNum);
void SpawnAllMapNpcs(void);
int CanAttackPlayer(int Attacker, int Victim);
int CanAttackNpc(int Attacker, int MapNpcNum);
int CanNpcAttackPlayer(int MapNpcNum, int Index);
void AttackPlayer(int Attacker, int Victim, int Damage);
void NpcAttackPlayer(int MapNpcNum, int Victim, int Damage);
void AttackNpc(int Attacker, int MapNpcNum, int Damage);
void PlayerWarp(int Index, int MapNum, int x, int y);
void PlayerMove(int Index, int Dir, int Movement);
int CanNpcMove(int MapNum, int MapNpcNum, int Dir);
void NpcMove(int MapNum, int MapNpcNum, int Dir, int Movement);
void NpcDir(int MapNum, int MapNpcNum, int Dir);
void JoinGame(int Index);
void LeftGame(int Index);
int GetTotalMapPlayers(int MapNum);
int GetNpcMaxHP(int NpcNum);
int GetNpcMaxMP(int NpcNum);
int GetNpcMaxSP(int NpcNum);
int GetPlayerHPRegen(int Index);
int GetPlayerMPRegen(int Index);
int GetPlayerSPRegen(int Index);
int GetNpcHPRegen(int NpcNum);
void CheckPlayerLevelUp(int Index);
void CastSpell_(int Index, int SpellSlot);
int GetSpellReqLevel(int Index, int SpellNum);
int CanPlayerCriticalHit(int Index);
int CanPlayerBlockHit(int Index);
void CheckEquippedItems(int Index);

// ==================
// General / Main Loop
// ==================

void InitServer(void);
void DestroyServer(void);
void ServerLogic(void);
void CheckSpawnMapItems(void);
void GameAI(void);
void CheckGiveHP(void);
void PlayerSaveTimer(void);


#endif // SERVER_H
