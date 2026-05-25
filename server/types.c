#include "server.h"

// ========================
// Clear Functions
// ========================

void ClearTempTile(void) {
    int i, x, y;

    for (i = 1; i <= MAX_MAPS; i++) {
        TempTile[i].DoorTimer = 0;

        for (y = 0; y <= MAX_MAPY; y++) {
            for (x = 0; x <= MAX_MAPX; x++) {
                TempTile[i].DoorOpen[x][y] = NO;
            }
        }
    }
}

void ClearClasses(void) {
    int i;

    for (i = 0; i <= Max_Classes; i++) {
        memset(Class[i].Name, 0, sizeof(Class[i].Name));
        Class[i].Sprite = 0;
        Class[i].STR = 0;
        Class[i].DEF = 0;
        Class[i].SPEED = 0;
        Class[i].MAGI = 0;
    }
}

void ClearPlayer(int Index) {
    int i, n;

    memset(Player[Index].Login, 0, sizeof(Player[Index].Login));
    memset(Player[Index].Password, 0, sizeof(Player[Index].Password));

    for (i = 1; i <= MAX_CHARS; i++) {
        memset(Player[Index].Char[i].Name, 0, sizeof(Player[Index].Char[i].Name));
        Player[Index].Char[i].Sex = 0;
        Player[Index].Char[i].Class = 0;
        Player[Index].Char[i].Sprite = 0;
        Player[Index].Char[i].Level = 0;
        Player[Index].Char[i].Exp = 0;
        Player[Index].Char[i].Access = 0;
        Player[Index].Char[i].PK = NO;
        Player[Index].Char[i].POINTS = 0;
        Player[Index].Char[i].Guild = 0;

        Player[Index].Char[i].HP = 0;
        Player[Index].Char[i].MP = 0;
        Player[Index].Char[i].SP = 0;

        Player[Index].Char[i].STR = 0;
        Player[Index].Char[i].DEF = 0;
        Player[Index].Char[i].SPEED = 0;
        Player[Index].Char[i].MAGI = 0;

        for (n = 1; n <= MAX_INV; n++) {
            Player[Index].Char[i].Inv[n].Num = 0;
            Player[Index].Char[i].Inv[n].Value = 0;
            Player[Index].Char[i].Inv[n].Dur = 0;
        }

        for (n = 1; n <= MAX_PLAYER_SPELLS; n++) {
            Player[Index].Char[i].Spell[n] = 0;
        }

        Player[Index].Char[i].ArmorSlot = 0;
        Player[Index].Char[i].WeaponSlot = 0;
        Player[Index].Char[i].HelmetSlot = 0;
        Player[Index].Char[i].ShieldSlot = 0;

        Player[Index].Char[i].Map = 0;
        Player[Index].Char[i].x = 0;
        Player[Index].Char[i].y = 0;
        Player[Index].Char[i].Dir = 0;
    }

    // Temporary vars
    memset(Player[Index].Buffer, 0, sizeof(Player[Index].Buffer));
    memset(Player[Index].IncBuffer, 0, sizeof(Player[Index].IncBuffer));
    Player[Index].CharNum = 0;
    Player[Index].InGame = 0;
    Player[Index].AttackTimer = 0;
    Player[Index].DataTimer = 0;
    Player[Index].DataBytes = 0;
    Player[Index].DataPackets = 0;
    Player[Index].PartyPlayer = 0;
    Player[Index].InParty = 0;
    Player[Index].Target = 0;
    Player[Index].TargetType = 0;
    Player[Index].CastedSpell = NO;
    Player[Index].PartyStarter = NO;
    Player[Index].GettingMap = NO;
}

void ClearChar(int Index, int CharNum) {
    int n;

    memset(Player[Index].Char[CharNum].Name, 0, sizeof(Player[Index].Char[CharNum].Name));
    Player[Index].Char[CharNum].Sex = 0;
    Player[Index].Char[CharNum].Class = 0;
    Player[Index].Char[CharNum].Sprite = 0;
    Player[Index].Char[CharNum].Level = 0;
    Player[Index].Char[CharNum].Exp = 0;
    Player[Index].Char[CharNum].Access = 0;
    Player[Index].Char[CharNum].PK = NO;
    Player[Index].Char[CharNum].POINTS = 0;
    Player[Index].Char[CharNum].Guild = 0;

    Player[Index].Char[CharNum].HP = 0;
    Player[Index].Char[CharNum].MP = 0;
    Player[Index].Char[CharNum].SP = 0;

    Player[Index].Char[CharNum].STR = 0;
    Player[Index].Char[CharNum].DEF = 0;
    Player[Index].Char[CharNum].SPEED = 0;
    Player[Index].Char[CharNum].MAGI = 0;

    for (n = 1; n <= MAX_INV; n++) {
        Player[Index].Char[CharNum].Inv[n].Num = 0;
        Player[Index].Char[CharNum].Inv[n].Value = 0;
        Player[Index].Char[CharNum].Inv[n].Dur = 0;
    }

    for (n = 1; n <= MAX_PLAYER_SPELLS; n++) {
        Player[Index].Char[CharNum].Spell[n] = 0;
    }

    Player[Index].Char[CharNum].ArmorSlot = 0;
    Player[Index].Char[CharNum].WeaponSlot = 0;
    Player[Index].Char[CharNum].HelmetSlot = 0;
    Player[Index].Char[CharNum].ShieldSlot = 0;

    Player[Index].Char[CharNum].Map = 0;
    Player[Index].Char[CharNum].x = 0;
    Player[Index].Char[CharNum].y = 0;
    Player[Index].Char[CharNum].Dir = 0;
}

void ClearItem(int Index) {
    memset(Item_[Index].Name, 0, sizeof(Item_[Index].Name));
    Item_[Index].Pic = 0;
    Item_[Index].Type = 0;
    Item_[Index].Data1 = 0;
    Item_[Index].Data2 = 0;
    Item_[Index].Data3 = 0;
}

void ClearItems(void) {
    int i;

    for (i = 1; i <= MAX_ITEMS; i++) {
        ClearItem(i);
    }
}

void ClearNpc(int Index) {
    memset(Npc_[Index].Name, 0, sizeof(Npc_[Index].Name));
    memset(Npc_[Index].AttackSay, 0, sizeof(Npc_[Index].AttackSay));
    Npc_[Index].Sprite = 0;
    Npc_[Index].SpawnSecs = 0;
    Npc_[Index].Behavior = 0;
    Npc_[Index].Range = 0;
    Npc_[Index].DropChance = 0;
    Npc_[Index].DropItem = 0;
    Npc_[Index].DropItemValue = 0;
    Npc_[Index].STR = 0;
    Npc_[Index].DEF = 0;
    Npc_[Index].SPEED = 0;
    Npc_[Index].MAGI = 0;
}

void ClearNpcs(void) {
    int i;

    for (i = 1; i <= MAX_NPCS; i++) {
        ClearNpc(i);
    }
}

void ClearMapItem(int Index, int MapNum) {
    MapItem_[MapNum][Index].Num = 0;
    MapItem_[MapNum][Index].Value = 0;
    MapItem_[MapNum][Index].Dur = 0;
    MapItem_[MapNum][Index].x = 0;
    MapItem_[MapNum][Index].y = 0;
}

void ClearMapItems(void) {
    int x, y;

    for (y = 1; y <= MAX_MAPS; y++) {
        for (x = 1; x <= MAX_MAP_ITEMS; x++) {
            ClearMapItem(x, y);
        }
    }
}

void ClearMapNpc(int Index, int MapNum) {
    MapNpc_[MapNum][Index].Num = 0;
    MapNpc_[MapNum][Index].Target = 0;
    MapNpc_[MapNum][Index].HP = 0;
    MapNpc_[MapNum][Index].MP = 0;
    MapNpc_[MapNum][Index].SP = 0;
    MapNpc_[MapNum][Index].x = 0;
    MapNpc_[MapNum][Index].y = 0;
    MapNpc_[MapNum][Index].Dir = 0;
    MapNpc_[MapNum][Index].SpawnWait = 0;
    MapNpc_[MapNum][Index].AttackTimer = 0;
}

void ClearMapNpcs(void) {
    int x, y;

    for (y = 1; y <= MAX_MAPS; y++) {
        for (x = 1; x <= MAX_MAP_NPCS; x++) {
            ClearMapNpc(x, y);
        }
    }
}

void ClearMap(int MapNum) {
    int x, y;

    memset(Map_[MapNum].Name, 0, sizeof(Map_[MapNum].Name));
    Map_[MapNum].Revision = 0;
    Map_[MapNum].Moral = 0;
    Map_[MapNum].Up = 0;
    Map_[MapNum].Down = 0;
    Map_[MapNum].Left = 0;
    Map_[MapNum].Right = 0;
    Map_[MapNum].Music = 0;
    Map_[MapNum].BootMap = 0;
    Map_[MapNum].BootX = 0;
    Map_[MapNum].BootY = 0;
    Map_[MapNum].Shop = 0;
    Map_[MapNum].Indoors = 0;

    for (y = 0; y <= MAX_MAPY; y++) {
        for (x = 0; x <= MAX_MAPX; x++) {
            Map_[MapNum].Tile[x][y].Ground = 0;
            Map_[MapNum].Tile[x][y].Mask = 0;
            Map_[MapNum].Tile[x][y].Anim = 0;
            Map_[MapNum].Tile[x][y].Fringe = 0;
            Map_[MapNum].Tile[x][y].Type = 0;
            Map_[MapNum].Tile[x][y].Data1 = 0;
            Map_[MapNum].Tile[x][y].Data2 = 0;
            Map_[MapNum].Tile[x][y].Data3 = 0;
        }
    }

    for (x = 1; x <= MAX_MAP_NPCS; x++) {
        Map_[MapNum].Npc[x] = 0;
    }

    PlayersOnMap[MapNum] = NO;
}

void ClearMaps(void) {
    int i;

    for (i = 1; i <= MAX_MAPS; i++) {
        ClearMap(i);
    }
}

void ClearShop(int Index) {
    int i;

    memset(Shop_[Index].Name, 0, sizeof(Shop_[Index].Name));
    memset(Shop_[Index].JoinSay, 0, sizeof(Shop_[Index].JoinSay));
    memset(Shop_[Index].LeaveSay, 0, sizeof(Shop_[Index].LeaveSay));
    Shop_[Index].FixesItems = 0;

    for (i = 1; i <= MAX_TRADES; i++) {
        Shop_[Index].TradeItem[i].GiveItem = 0;
        Shop_[Index].TradeItem[i].GiveValue = 0;
        Shop_[Index].TradeItem[i].GetItem = 0;
        Shop_[Index].TradeItem[i].GetValue = 0;
    }
}

void ClearShops(void) {
    int i;

    for (i = 1; i <= MAX_SHOPS; i++) {
        ClearShop(i);
    }
}

void ClearSpell(int Index) {
    memset(Spell_[Index].Name, 0, sizeof(Spell_[Index].Name));
    Spell_[Index].ClassReq = 0;
    Spell_[Index].LevelReq = 0;
    Spell_[Index].Type = 0;
    Spell_[Index].Data1 = 0;
    Spell_[Index].Data2 = 0;
    Spell_[Index].Data3 = 0;
}

void ClearSpells(void) {
    int i;

    for (i = 1; i <= MAX_SPELLS; i++) {
        ClearSpell(i);
    }
}

// ============================
// Player Getter/Setter Functions
// ============================

const char *GetPlayerLogin(int Index) {
    static char buf[NAME_LENGTH + 1];
    strncpy(buf, Player[Index].Login, NAME_LENGTH);
    buf[NAME_LENGTH] = '\0';
    str_trim(buf);
    return buf;
}

void SetPlayerLogin(int Index, const char *Login) {
    memset(Player[Index].Login, 0, sizeof(Player[Index].Login));
    strncpy(Player[Index].Login, Login, NAME_LENGTH);
}

const char *GetPlayerPassword(int Index) {
    static char buf[NAME_LENGTH + 1];
    strncpy(buf, Player[Index].Password, NAME_LENGTH);
    buf[NAME_LENGTH] = '\0';
    str_trim(buf);
    return buf;
}

void SetPlayerPassword(int Index, const char *Password) {
    memset(Player[Index].Password, 0, sizeof(Player[Index].Password));
    strncpy(Player[Index].Password, Password, NAME_LENGTH);
}

const char *GetPlayerName(int Index) {
    static char buf[NAME_LENGTH + 1];
    int CharNum = Player[Index].CharNum;
    strncpy(buf, Player[Index].Char[CharNum].Name, NAME_LENGTH);
    buf[NAME_LENGTH] = '\0';
    str_trim(buf);
    return buf;
}

void SetPlayerName(int Index, const char *Name) {
    int CharNum = Player[Index].CharNum;
    memset(Player[Index].Char[CharNum].Name, 0, sizeof(Player[Index].Char[CharNum].Name));
    strncpy(Player[Index].Char[CharNum].Name, Name, NAME_LENGTH);
}

int GetPlayerClass(int Index) {
    int CharNum = Player[Index].CharNum;
    return Player[Index].Char[CharNum].Class;
}

void SetPlayerClass(int Index, int ClassNum) {
    int CharNum = Player[Index].CharNum;
    Player[Index].Char[CharNum].Class = ClassNum;
}

int GetPlayerSprite(int Index) {
    int CharNum = Player[Index].CharNum;
    return Player[Index].Char[CharNum].Sprite;
}

void SetPlayerSprite(int Index, int Sprite) {
    int CharNum = Player[Index].CharNum;
    Player[Index].Char[CharNum].Sprite = Sprite;
}

int GetPlayerLevel(int Index) {
    int CharNum = Player[Index].CharNum;
    return Player[Index].Char[CharNum].Level;
}

void SetPlayerLevel(int Index, int Level) {
    int CharNum = Player[Index].CharNum;
    Player[Index].Char[CharNum].Level = Level;
}

int GetPlayerNextLevel(int Index) {
    return (GetPlayerLevel(Index) + 1) * (GetPlayerSTR(Index) + GetPlayerDEF(Index) + GetPlayerMAGI(Index) + GetPlayerSPEED(Index) + GetPlayerPOINTS(Index)) * 25;
}

int GetPlayerExp(int Index) {
    int CharNum = Player[Index].CharNum;
    return Player[Index].Char[CharNum].Exp;
}

void SetPlayerExp(int Index, int Exp) {
    int CharNum = Player[Index].CharNum;
    Player[Index].Char[CharNum].Exp = Exp;
}

int GetPlayerAccess(int Index) {
    int CharNum = Player[Index].CharNum;
    return Player[Index].Char[CharNum].Access;
}

void SetPlayerAccess(int Index, int Access) {
    int CharNum = Player[Index].CharNum;
    Player[Index].Char[CharNum].Access = Access;
}

int GetPlayerPK(int Index) {
    int CharNum = Player[Index].CharNum;
    return Player[Index].Char[CharNum].PK;
}

void SetPlayerPK(int Index, int PK) {
    int CharNum = Player[Index].CharNum;
    Player[Index].Char[CharNum].PK = PK;
}

int GetPlayerHP(int Index) {
    int CharNum = Player[Index].CharNum;
    return Player[Index].Char[CharNum].HP;
}

void SetPlayerHP(int Index, int HP) {
    int CharNum = Player[Index].CharNum;
    Player[Index].Char[CharNum].HP = HP;

    if (GetPlayerHP(Index) > GetPlayerMaxHP(Index)) {
        Player[Index].Char[CharNum].HP = GetPlayerMaxHP(Index);
    }
    if (GetPlayerHP(Index) < 0) {
        Player[Index].Char[CharNum].HP = 0;
    }
}

int GetPlayerMP(int Index) {
    int CharNum = Player[Index].CharNum;
    return Player[Index].Char[CharNum].MP;
}

void SetPlayerMP(int Index, int MP) {
    int CharNum = Player[Index].CharNum;
    Player[Index].Char[CharNum].MP = MP;

    if (GetPlayerMP(Index) > GetPlayerMaxMP(Index)) {
        Player[Index].Char[CharNum].MP = GetPlayerMaxMP(Index);
    }
    if (GetPlayerMP(Index) < 0) {
        Player[Index].Char[CharNum].MP = 0;
    }
}

int GetPlayerSP(int Index) {
    int CharNum = Player[Index].CharNum;
    return Player[Index].Char[CharNum].SP;
}

void SetPlayerSP(int Index, int SP) {
    int CharNum = Player[Index].CharNum;
    Player[Index].Char[CharNum].SP = SP;

    if (GetPlayerSP(Index) > GetPlayerMaxSP(Index)) {
        Player[Index].Char[CharNum].SP = GetPlayerMaxSP(Index);
    }
    if (GetPlayerSP(Index) < 0) {
        Player[Index].Char[CharNum].SP = 0;
    }
}

int GetPlayerMaxHP(int Index) {
    int CharNum = Player[Index].CharNum;
    return (Player[Index].Char[CharNum].Level + (GetPlayerSTR(Index) / 2) + Class[Player[Index].Char[CharNum].Class].STR) * 2;
}

int GetPlayerMaxMP(int Index) {
    int CharNum = Player[Index].CharNum;
    return (Player[Index].Char[CharNum].Level + (GetPlayerMAGI(Index) / 2) + Class[Player[Index].Char[CharNum].Class].MAGI) * 2;
}

int GetPlayerMaxSP(int Index) {
    int CharNum = Player[Index].CharNum;
    return (Player[Index].Char[CharNum].Level + (GetPlayerSPEED(Index) / 2) + Class[Player[Index].Char[CharNum].Class].SPEED) * 2;
}

// ============================
// Class Getter Functions
// ============================

const char *GetClassName(int ClassNum) {
    static char buf[NAME_LENGTH + 1];
    strncpy(buf, Class[ClassNum].Name, NAME_LENGTH);
    buf[NAME_LENGTH] = '\0';
    str_trim(buf);
    return buf;
}

int GetClassMaxHP(int ClassNum) {
    return (1 + (Class[ClassNum].STR / 2) + Class[ClassNum].STR) * 2;
}

int GetClassMaxMP(int ClassNum) {
    return (1 + (Class[ClassNum].MAGI / 2) + Class[ClassNum].MAGI) * 2;
}

int GetClassMaxSP(int ClassNum) {
    return (1 + (Class[ClassNum].SPEED / 2) + Class[ClassNum].SPEED) * 2;
}

int GetClassSTR(int ClassNum) {
    return Class[ClassNum].STR;
}

int GetClassDEF(int ClassNum) {
    return Class[ClassNum].DEF;
}

int GetClassSPEED(int ClassNum) {
    return Class[ClassNum].SPEED;
}

int GetClassMAGI(int ClassNum) {
    return Class[ClassNum].MAGI;
}

// ============================
// Player Stats Getter/Setter
// ============================

int GetPlayerSTR(int Index) {
    int CharNum = Player[Index].CharNum;
    return Player[Index].Char[CharNum].STR;
}

void SetPlayerSTR(int Index, int STR) {
    int CharNum = Player[Index].CharNum;
    Player[Index].Char[CharNum].STR = STR;
}

int GetPlayerDEF(int Index) {
    int CharNum = Player[Index].CharNum;
    return Player[Index].Char[CharNum].DEF;
}

void SetPlayerDEF(int Index, int DEF) {
    int CharNum = Player[Index].CharNum;
    Player[Index].Char[CharNum].DEF = DEF;
}

int GetPlayerSPEED(int Index) {
    int CharNum = Player[Index].CharNum;
    return Player[Index].Char[CharNum].SPEED;
}

void SetPlayerSPEED(int Index, int SPEED) {
    int CharNum = Player[Index].CharNum;
    Player[Index].Char[CharNum].SPEED = SPEED;
}

int GetPlayerMAGI(int Index) {
    int CharNum = Player[Index].CharNum;
    return Player[Index].Char[CharNum].MAGI;
}

void SetPlayerMAGI(int Index, int MAGI) {
    int CharNum = Player[Index].CharNum;
    Player[Index].Char[CharNum].MAGI = MAGI;
}

int GetPlayerPOINTS(int Index) {
    int CharNum = Player[Index].CharNum;
    return Player[Index].Char[CharNum].POINTS;
}

void SetPlayerPOINTS(int Index, int POINTS) {
    int CharNum = Player[Index].CharNum;
    Player[Index].Char[CharNum].POINTS = POINTS;
}

// ============================
// Player Position Getter/Setter
// ============================

int GetPlayerMap(int Index) {
    int CharNum = Player[Index].CharNum;
    return Player[Index].Char[CharNum].Map;
}

void SetPlayerMap(int Index, int MapNum) {
    if (MapNum > 0 && MapNum <= MAX_MAPS) {
        int CharNum = Player[Index].CharNum;
        Player[Index].Char[CharNum].Map = MapNum;
    }
}

int GetPlayerX(int Index) {
    int CharNum = Player[Index].CharNum;
    return Player[Index].Char[CharNum].x;
}

void SetPlayerX(int Index, int x) {
    int CharNum = Player[Index].CharNum;
    Player[Index].Char[CharNum].x = x;
}

int GetPlayerY(int Index) {
    int CharNum = Player[Index].CharNum;
    return Player[Index].Char[CharNum].y;
}

void SetPlayerY(int Index, int y) {
    int CharNum = Player[Index].CharNum;
    Player[Index].Char[CharNum].y = y;
}

int GetPlayerDir(int Index) {
    int CharNum = Player[Index].CharNum;
    return Player[Index].Char[CharNum].Dir;
}

void SetPlayerDir(int Index, int Dir) {
    int CharNum = Player[Index].CharNum;
    Player[Index].Char[CharNum].Dir = Dir;
}

const char *GetPlayerIP(int Index) {
    return Player[Index].remote_ip;
}

// ============================
// Player Inventory Getter/Setter
// ============================

int GetPlayerInvItemNum(int Index, int InvSlot) {
    int CharNum = Player[Index].CharNum;
    return Player[Index].Char[CharNum].Inv[InvSlot].Num;
}

void SetPlayerInvItemNum(int Index, int InvSlot, int ItemNum) {
    int CharNum = Player[Index].CharNum;
    Player[Index].Char[CharNum].Inv[InvSlot].Num = ItemNum;
}

int GetPlayerInvItemValue(int Index, int InvSlot) {
    int CharNum = Player[Index].CharNum;
    return Player[Index].Char[CharNum].Inv[InvSlot].Value;
}

void SetPlayerInvItemValue(int Index, int InvSlot, int ItemValue) {
    int CharNum = Player[Index].CharNum;
    Player[Index].Char[CharNum].Inv[InvSlot].Value = ItemValue;
}

int GetPlayerInvItemDur(int Index, int InvSlot) {
    int CharNum = Player[Index].CharNum;
    return Player[Index].Char[CharNum].Inv[InvSlot].Dur;
}

void SetPlayerInvItemDur(int Index, int InvSlot, int ItemDur) {
    int CharNum = Player[Index].CharNum;
    Player[Index].Char[CharNum].Inv[InvSlot].Dur = ItemDur;
}

// ============================
// Player Spell Getter/Setter
// ============================

int GetPlayerSpell_(int Index, int SpellSlot) {
    int CharNum = Player[Index].CharNum;
    return Player[Index].Char[CharNum].Spell[SpellSlot];
}

void SetPlayerSpell_(int Index, int SpellSlot, int SpellNum) {
    int CharNum = Player[Index].CharNum;
    Player[Index].Char[CharNum].Spell[SpellSlot] = SpellNum;
}

// ============================
// Player Equipment Getter/Setter
// ============================

int GetPlayerArmorSlot(int Index) {
    int CharNum = Player[Index].CharNum;
    return Player[Index].Char[CharNum].ArmorSlot;
}

void SetPlayerArmorSlot(int Index, int InvNum) {
    int CharNum = Player[Index].CharNum;
    Player[Index].Char[CharNum].ArmorSlot = InvNum;
}

int GetPlayerWeaponSlot(int Index) {
    int CharNum = Player[Index].CharNum;
    return Player[Index].Char[CharNum].WeaponSlot;
}

void SetPlayerWeaponSlot(int Index, int InvNum) {
    int CharNum = Player[Index].CharNum;
    Player[Index].Char[CharNum].WeaponSlot = InvNum;
}

int GetPlayerHelmetSlot(int Index) {
    int CharNum = Player[Index].CharNum;
    return Player[Index].Char[CharNum].HelmetSlot;
}

void SetPlayerHelmetSlot(int Index, int InvNum) {
    int CharNum = Player[Index].CharNum;
    Player[Index].Char[CharNum].HelmetSlot = InvNum;
}

int GetPlayerShieldSlot(int Index) {
    int CharNum = Player[Index].CharNum;
    return Player[Index].Char[CharNum].ShieldSlot;
}

void SetPlayerShieldSlot(int Index, int InvNum) {
    int CharNum = Player[Index].CharNum;
    Player[Index].Char[CharNum].ShieldSlot = InvNum;
}
