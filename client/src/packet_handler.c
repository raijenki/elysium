#include "client.h"
#include <stdarg.h>

static int parse_packet(char *data, int datalen, char **parse, int maxparse) {
    int nparse = 0;
    if (datalen <= 0) return 0;
    parse[0] = data;
    nparse = 1;
    for (int i = 0; i < datalen && nparse < maxparse; i++) {
        if (data[i] == '\0') {
            if (i + 1 < datalen) {
                parse[nparse++] = data + i + 1;
            }
        }
    }
    return nparse;
}

#define P(n) ((n) < nparse ? parse[n] : "")
#define PVAL(n) ((n) < nparse ? atoi(parse[n]) : 0)

void HandleData(const char *Data, int DataLen) {
    char *datacopy = malloc(DataLen + 1);
    if (!datacopy) return;
    memcpy(datacopy, Data, DataLen);
    datacopy[DataLen] = '\0';

    char *parse[512];
    int nparse = parse_packet(datacopy, DataLen, parse, 512);
    if (nparse < 1) { free(datacopy); return; }

    char cmd[64];
    strlcpy_safe(cmd, parse[0], sizeof(cmd));
    for (char *p = cmd; *p; p++) *p = (char)tolower((unsigned char)*p);

    // :::::::::::::::::::::::::
    // :: Alert message packet ::
    // :::::::::::::::::::::::::
    if (strcmp(cmd, "alertmsg") == 0) {
        // Show alert
        printf("ALERT: %s\n", P(1));
        SetScreen(SCREEN_MAINMENU);
        free(datacopy);
        return;
    }

    // :::::::::::::::::::::::::::
    // :: All characters packet ::
    // :::::::::::::::::::::::::::
    if (strcmp(cmd, "allchars") == 0) {
        int n = 1;
        const char *items[MAX_CHARS];
        int itemCount = 0;
        for (int i = 1; i <= MAX_CHARS; i++) {
            const char *name = P(n);
            const char *className = P(n + 1);
            int level = PVAL(n + 2);
            static char buf[MAX_CHARS][256];
            if (strlen(name) == 0) {
                snprintf(buf[i-1], sizeof(buf[i-1]), "Free Character Slot");
            } else {
                snprintf(buf[i-1], sizeof(buf[i-1]), "%s a level %d %s", name, level, className);
            }
            items[itemCount++] = buf[i-1];
            n += 3;
        }
        UISetListItems(6, 0, items, itemCount);
        SetScreen(SCREEN_CHARS);
        free(datacopy);
        return;
    }

    // :::::::::::::::::::::::::::::::::
    // :: Login was successful packet ::
    // :::::::::::::::::::::::::::::::::
    if (strcmp(cmd, "loginok") == 0) {
        MyIndex = PVAL(1);
        free(datacopy);
        return;
    }

    // :::::::::::::::::::::::::::::::::::::::
    // :: New character classes data packet ::
    // :::::::::::::::::::::::::::::::::::::::
    if (strcmp(cmd, "newcharclasses") == 0) {
        int n = 1;
        Max_Classes = PVAL(n);
        n++;
        for (int i = 0; i <= Max_Classes; i++) {
            strlcpy_safe(Class[i].Name, P(n), sizeof(Class[i].Name));
            Class[i].HP = PVAL(n + 1);
            Class[i].MP = PVAL(n + 2);
            Class[i].SP = PVAL(n + 3);
            Class[i].STR = PVAL(n + 4);
            Class[i].DEF = PVAL(n + 5);
            Class[i].SPEED = PVAL(n + 6);
            Class[i].MAGI = PVAL(n + 7);
            n += 8;
        }
        // Populate class list in new char screen
        const char *items[256];
        for (int i = 0; i <= Max_Classes; i++) {
            items[i] = Class[i].Name;
        }
        UISetListItems(7, 0, items, Max_Classes + 1);
        SetScreen(SCREEN_NEWCHAR);
        free(datacopy);
        return;
    }

    // :::::::::::::::::::::::::
    // :: Classes data packet ::
    // :::::::::::::::::::::::::
    if (strcmp(cmd, "classesdata") == 0) {
        int n = 1;
        Max_Classes = PVAL(n);
        n++;
        for (int i = 0; i <= Max_Classes; i++) {
            strlcpy_safe(Class[i].Name, P(n), sizeof(Class[i].Name));
            Class[i].HP = PVAL(n + 1);
            Class[i].MP = PVAL(n + 2);
            Class[i].SP = PVAL(n + 3);
            Class[i].STR = PVAL(n + 4);
            Class[i].DEF = PVAL(n + 5);
            Class[i].SPEED = PVAL(n + 6);
            Class[i].MAGI = PVAL(n + 7);
            n += 8;
        }
        free(datacopy);
        return;
    }

    // ::::::::::::::::::::
    // :: In game packet ::
    // ::::::::::::::::::::
    if (strcmp(cmd, "ingame") == 0) {
        InGame = 1;
        GameInit();
        free(datacopy);
        return;
    }

    // :::::::::::::::::::::::::::::
    // :: Player inventory packet ::
    // :::::::::::::::::::::::::::::
    if (strcmp(cmd, "playerinv") == 0) {
        int n = 1;
        for (int i = 1; i <= MAX_INV; i++) {
            SetPlayerInvItemNum(MyIndex, i, PVAL(n));
            SetPlayerInvItemValue(MyIndex, i, PVAL(n + 1));
            SetPlayerInvItemDur(MyIndex, i, PVAL(n + 2));
            n += 3;
        }
        free(datacopy);
        return;
    }

    // ::::::::::::::::::::::::::::::::::::
    // :: Player inventory update packet ::
    // ::::::::::::::::::::::::::::::::::::
    if (strcmp(cmd, "playerinvupdate") == 0) {
        int n = PVAL(1);
        SetPlayerInvItemNum(MyIndex, n, PVAL(2));
        SetPlayerInvItemValue(MyIndex, n, PVAL(3));
        SetPlayerInvItemDur(MyIndex, n, PVAL(4));
        free(datacopy);
        return;
    }

    // ::::::::::::::::::::::::::::::::::
    // :: Player worn equipment packet ::
    // ::::::::::::::::::::::::::::::::::
    if (strcmp(cmd, "playerworneq") == 0) {
        SetPlayerArmorSlot(MyIndex, PVAL(1));
        SetPlayerWeaponSlot(MyIndex, PVAL(2));
        SetPlayerHelmetSlot(MyIndex, PVAL(3));
        SetPlayerShieldSlot(MyIndex, PVAL(4));
        free(datacopy);
        return;
    }

    // ::::::::::::::::::::::
    // :: Player hp packet ::
    // ::::::::::::::::::::::
    if (strcmp(cmd, "playerhp") == 0) {
        Player[MyIndex].MaxHP = PVAL(1);
        SetPlayerHP(MyIndex, PVAL(2));
        free(datacopy);
        return;
    }

    // ::::::::::::::::::::::
    // :: Player mp packet ::
    // ::::::::::::::::::::::
    if (strcmp(cmd, "playermp") == 0) {
        Player[MyIndex].MaxMP = PVAL(1);
        SetPlayerMP(MyIndex, PVAL(2));
        free(datacopy);
        return;
    }

    // ::::::::::::::::::::::
    // :: Player sp packet ::
    // ::::::::::::::::::::::
    if (strcmp(cmd, "playersp") == 0) {
        Player[MyIndex].MaxSP = PVAL(1);
        SetPlayerSP(MyIndex, PVAL(2));
        free(datacopy);
        return;
    }

    // ::::::::::::::::::::::::::
    // :: Player stats packet ::
    // ::::::::::::::::::::::::::
    if (strcmp(cmd, "playerstats") == 0) {
        SetPlayerSTR(MyIndex, PVAL(1));
        SetPlayerDEF(MyIndex, PVAL(2));
        SetPlayerSPEED(MyIndex, PVAL(3));
        SetPlayerMAGI(MyIndex, PVAL(4));
        free(datacopy);
        return;
    }

    // :::::::::::::::::::::::::::
    // :: Player data packet ::
    // :::::::::::::::::::::::::::
    if (strcmp(cmd, "playerdata") == 0) {
        int i = PVAL(1);
        SetPlayerName(i, P(2));
        SetPlayerSprite(i, PVAL(3));
        SetPlayerMap(i, PVAL(4));
        SetPlayerX(i, PVAL(5));
        SetPlayerY(i, PVAL(6));
        SetPlayerDir(i, PVAL(7));
        SetPlayerAccess(i, PVAL(8));
        SetPlayerPK(i, PVAL(9));
        Player[i].Moving = 0;
        Player[i].XOffset = 0;
        Player[i].YOffset = 0;
        if (i == MyIndex) {
            DirUp = DirDown = DirLeft = DirRight = 0;
        }
        free(datacopy);
        return;
    }

    // :::::::::::::::::::::::::::::
    // :: Player movement packet ::
    // :::::::::::::::::::::::::::::
    if (strcmp(cmd, "playermove") == 0) {
        int i = PVAL(1);
        SetPlayerX(i, PVAL(2));
        SetPlayerY(i, PVAL(3));
        SetPlayerDir(i, PVAL(4));
        Player[i].XOffset = 0;
        Player[i].YOffset = 0;
        Player[i].Moving = PVAL(5);
        switch (GetPlayerDir(i)) {
            case DIR_UP: Player[i].YOffset = PIC_Y; break;
            case DIR_DOWN: Player[i].YOffset = -PIC_Y; break;
            case DIR_LEFT: Player[i].XOffset = PIC_X; break;
            case DIR_RIGHT: Player[i].XOffset = -PIC_X; break;
        }
        free(datacopy);
        return;
    }

    // ::::::::::::::::::::::::::
    // :: Npc movement packet ::
    // ::::::::::::::::::::::::::
    if (strcmp(cmd, "npcmove") == 0) {
        int i = PVAL(1);
        MapNpc[i].x = PVAL(2);
        MapNpc[i].y = PVAL(3);
        MapNpc[i].Dir = PVAL(4);
        MapNpc[i].XOffset = 0;
        MapNpc[i].YOffset = 0;
        MapNpc[i].Moving = PVAL(5);
        switch (MapNpc[i].Dir) {
            case DIR_UP: MapNpc[i].YOffset = PIC_Y; break;
            case DIR_DOWN: MapNpc[i].YOffset = -PIC_Y; break;
            case DIR_LEFT: MapNpc[i].XOffset = PIC_X; break;
            case DIR_RIGHT: MapNpc[i].XOffset = -PIC_X; break;
        }
        free(datacopy);
        return;
    }

    // ::::::::::::::::::::::::::::::
    // :: Player direction packet ::
    // ::::::::::::::::::::::::::::::
    if (strcmp(cmd, "playerdir") == 0) {
        int i = PVAL(1);
        SetPlayerDir(i, PVAL(2));
        Player[i].XOffset = 0;
        Player[i].YOffset = 0;
        Player[i].Moving = 0;
        free(datacopy);
        return;
    }

    // ::::::::::::::::::::::::::
    // :: NPC direction packet ::
    // ::::::::::::::::::::::::::
    if (strcmp(cmd, "npcdir") == 0) {
        int i = PVAL(1);
        MapNpc[i].Dir = PVAL(2);
        MapNpc[i].XOffset = 0;
        MapNpc[i].YOffset = 0;
        MapNpc[i].Moving = 0;
        free(datacopy);
        return;
    }

    // :::::::::::::::::::::::::::::::
    // :: Player XY location packet ::
    // :::::::::::::::::::::::::::::::
    if (strcmp(cmd, "playerxy") == 0) {
        SetPlayerX(MyIndex, PVAL(1));
        SetPlayerY(MyIndex, PVAL(2));
        Player[MyIndex].Moving = 0;
        Player[MyIndex].XOffset = 0;
        Player[MyIndex].YOffset = 0;
        free(datacopy);
        return;
    }

    // ::::::::::::::::::::::::::
    // :: Player attack packet ::
    // ::::::::::::::::::::::::::
    if (strcmp(cmd, "attack") == 0) {
        int i = PVAL(1);
        Player[i].Attacking = 1;
        Player[i].AttackTimer = GetTickCount();
        free(datacopy);
        return;
    }

    // :::::::::::::::::::::::
    // :: NPC attack packet ::
    // :::::::::::::::::::::::
    if (strcmp(cmd, "npcattack") == 0) {
        int i = PVAL(1);
        MapNpc[i].Attacking = 1;
        MapNpc[i].AttackTimer = GetTickCount();
        free(datacopy);
        return;
    }

    // ::::::::::::::::::::::::::
    // :: Check for map packet ::
    // ::::::::::::::::::::::::::
    if (strcmp(cmd, "checkformap") == 0) {
        for (int i = 1; i <= MAX_PLAYERS; i++) {
            if (i != MyIndex) SetPlayerMap(i, 0);
        }
        // Clear temp tiles
        for (int x = 0; x <= MAX_MAPX; x++)
            for (int y = 0; y <= MAX_MAPY; y++)
                TempTile[x][y].DoorOpen = NO;

        int mapNum = PVAL(1);
        int revision = PVAL(2);
        {
            char path[256];
            snprintf(path, sizeof(path), "maps/map%d.dat", mapNum);
            if (file_exists(path) && GetMapRevision(mapNum) == revision) {
                LoadMap(mapNum);
                Map = SaveMap;
                PKT_INIT(pkt);
                PKT_S(pkt, "needmap"); PKT_S(pkt, "no"); PKT_END(pkt);
                SendData(pkt);
                free(datacopy);
                return;
            }
        }
        PKT_INIT(pkt);
        PKT_S(pkt, "needmap"); PKT_S(pkt, "yes"); PKT_END(pkt);
        SendData(pkt);
        free(datacopy);
        return;
    }

    // :::::::::::::::::::::
    // :: Map data packet ::
    // :::::::::::::::::::::
    if (strcmp(cmd, "mapdata") == 0) {
        int n = 1;
        strlcpy_safe(SaveMap.Name, P(n + 1), sizeof(SaveMap.Name));
        SaveMap.Revision = PVAL(n + 2);
        SaveMap.Moral = PVAL(n + 3);
        SaveMap.Up = PVAL(n + 4);
        SaveMap.Down = PVAL(n + 5);
        SaveMap.Left = PVAL(n + 6);
        SaveMap.Right = PVAL(n + 7);
        SaveMap.Music = PVAL(n + 8);
        SaveMap.BootMap = PVAL(n + 9);
        SaveMap.BootX = PVAL(n + 10);
        SaveMap.BootY = PVAL(n + 11);
        SaveMap.Shop = PVAL(n + 12);
        n += 13;
        for (int y = 0; y <= MAX_MAPY; y++) {
            for (int x = 0; x <= MAX_MAPX; x++) {
                SaveMap.Tile[x][y].Ground = PVAL(n);
                SaveMap.Tile[x][y].Mask = PVAL(n + 1);
                SaveMap.Tile[x][y].Anim = PVAL(n + 2);
                SaveMap.Tile[x][y].Fringe = PVAL(n + 3);
                SaveMap.Tile[x][y].Type = PVAL(n + 4);
                SaveMap.Tile[x][y].Data1 = PVAL(n + 5);
                SaveMap.Tile[x][y].Data2 = PVAL(n + 6);
                SaveMap.Tile[x][y].Data3 = PVAL(n + 7);
                n += 8;
            }
        }
        for (int x = 1; x <= MAX_MAP_NPCS; x++) {
            SaveMap.Npc[x] = PVAL(n);
            n++;
        }
        SaveLocalMap(PVAL(1));
        if (InEditor) {
            InEditor = 0;
        }
        free(datacopy);
        return;
    }

    // :::::::::::::::::::::::::::
    // :: Map items data packet ::
    // :::::::::::::::::::::::::::
    if (strcmp(cmd, "mapitemdata") == 0) {
        int n = 1;
        for (int i = 1; i <= MAX_MAP_ITEMS; i++) {
            SaveMapItem[i].Num = PVAL(n);
            SaveMapItem[i].Value = PVAL(n + 1);
            SaveMapItem[i].Dur = PVAL(n + 2);
            SaveMapItem[i].x = PVAL(n + 3);
            SaveMapItem[i].y = PVAL(n + 4);
            n += 5;
        }
        free(datacopy);
        return;
    }

    // :::::::::::::::::::::::::
    // :: Map npc data packet ::
    // :::::::::::::::::::::::::
    if (strcmp(cmd, "mapnpcdata") == 0) {
        int n = 1;
        for (int i = 1; i <= MAX_MAP_NPCS; i++) {
            SaveMapNpc[i].Num = PVAL(n);
            SaveMapNpc[i].x = PVAL(n + 1);
            SaveMapNpc[i].y = PVAL(n + 2);
            SaveMapNpc[i].Dir = PVAL(n + 3);
            n += 4;
        }
        free(datacopy);
        return;
    }

    // :::::::::::::::::::::::::::::::
    // :: Map send completed packet ::
    // :::::::::::::::::::::::::::::::
    if (strcmp(cmd, "mapdone") == 0) {
        Map = SaveMap;
        for (int i = 1; i <= MAX_MAP_ITEMS; i++) {
            MapItem[i] = SaveMapItem[i];
        }
        for (int i = 1; i <= MAX_MAP_NPCS; i++) {
            MapNpc[i] = SaveMapNpc[i];
        }
        GettingMap = 0;
        StopMidi();
        if (Map.Music > 0) {
            char song[64];
            snprintf(song, sizeof(song), "assets/music/music%d.mid", Map.Music);
            PlayMidi(song);
        }
        free(datacopy);
        return;
    }

    // ::::::::::::::::::::
    // :: Social packets ::
    // ::::::::::::::::::::
    if (strcmp(cmd, "saymsg") == 0 || strcmp(cmd, "broadcastmsg") == 0 ||
        strcmp(cmd, "globalmsg") == 0 || strcmp(cmd, "playermsg") == 0 ||
        strcmp(cmd, "mapmsg") == 0 || strcmp(cmd, "adminmsg") == 0) {
        AddText(P(1), PVAL(2));
        free(datacopy);
        return;
    }

    // :::::::::::::::::::::::
    // :: Item spawn packet ::
    // :::::::::::::::::::::::
    if (strcmp(cmd, "spawnitem") == 0) {
        int n = PVAL(1);
        MapItem[n].Num = PVAL(2);
        MapItem[n].Value = PVAL(3);
        MapItem[n].Dur = PVAL(4);
        MapItem[n].x = PVAL(5);
        MapItem[n].y = PVAL(6);
        free(datacopy);
        return;
    }

    // ::::::::::::::::::::::::::
    // :: Item editor packet ::
    // ::::::::::::::::::::::::::
    if (strcmp(cmd, "itemeditor") == 0) {
        InItemsEditor = 1;
        // TODO: show item editor screen
        free(datacopy);
        return;
    }

    // ::::::::::::::::::::::::::
    // :: Update item packet ::
    // ::::::::::::::::::::::::::
    if (strcmp(cmd, "updateitem") == 0) {
        int n = PVAL(1);
        strlcpy_safe(Item[n].Name, P(2), sizeof(Item[n].Name));
        Item[n].Pic = PVAL(3);
        Item[n].Type = PVAL(4);
        Item[n].Data1 = 0;
        Item[n].Data2 = 0;
        Item[n].Data3 = 0;
        free(datacopy);
        return;
    }

    // :::::::::::::::::::::::
    // :: Edit item packet ::
    // :::::::::::::::::::::::
    if (strcmp(cmd, "edititem") == 0) {
        int n = PVAL(1);
        strlcpy_safe(Item[n].Name, P(2), sizeof(Item[n].Name));
        Item[n].Pic = PVAL(3);
        Item[n].Type = PVAL(4);
        Item[n].Data1 = PVAL(5);
        Item[n].Data2 = PVAL(6);
        Item[n].Data3 = PVAL(7);
        // TODO: init item editor
        free(datacopy);
        return;
    }

    // :::::::::::::::::::::::
    // :: Npc spawn packet ::
    // :::::::::::::::::::::::
    if (strcmp(cmd, "spawnnpc") == 0) {
        int n = PVAL(1);
        MapNpc[n].Num = PVAL(2);
        MapNpc[n].x = PVAL(3);
        MapNpc[n].y = PVAL(4);
        MapNpc[n].Dir = PVAL(5);
        MapNpc[n].XOffset = 0;
        MapNpc[n].YOffset = 0;
        MapNpc[n].Moving = 0;
        free(datacopy);
        return;
    }

    // ::::::::::::::::::::::
    // :: Npc dead packet ::
    // ::::::::::::::::::::::
    if (strcmp(cmd, "npcdead") == 0) {
        int n = PVAL(1);
        MapNpc[n].Num = 0;
        MapNpc[n].x = 0;
        MapNpc[n].y = 0;
        MapNpc[n].Dir = 0;
        MapNpc[n].XOffset = 0;
        MapNpc[n].YOffset = 0;
        MapNpc[n].Moving = 0;
        free(datacopy);
        return;
    }

    // ::::::::::::::::::::::::::
    // :: Npc editor packet ::
    // ::::::::::::::::::::::::::
    if (strcmp(cmd, "npceditor") == 0) {
        InNpcEditor = 1;
        // TODO: show NPC editor
        free(datacopy);
        return;
    }

    // ::::::::::::::::::::::::::
    // :: Update npc packet ::
    // ::::::::::::::::::::::::::
    if (strcmp(cmd, "updatenpc") == 0) {
        int n = PVAL(1);
        strlcpy_safe(Npc[n].Name, P(2), sizeof(Npc[n].Name));
        Npc[n].AttackSay[0] = '\0';
        Npc[n].Sprite = PVAL(3);
        Npc[n].SpawnSecs = 0;
        Npc[n].Behavior = 0;
        Npc[n].Range = 0;
        Npc[n].DropChance = 0;
        Npc[n].DropItem = 0;
        Npc[n].DropItemValue = 0;
        Npc[n].STR = 0;
        Npc[n].DEF = 0;
        Npc[n].SPEED = 0;
        Npc[n].MAGI = 0;
        free(datacopy);
        return;
    }

    // :::::::::::::::::::::::
    // :: Edit npc packet ::
    // :::::::::::::::::::::::
    if (strcmp(cmd, "editnpc") == 0) {
        int n = PVAL(1);
        strlcpy_safe(Npc[n].Name, P(2), sizeof(Npc[n].Name));
        strlcpy_safe(Npc[n].AttackSay, P(3), sizeof(Npc[n].AttackSay));
        Npc[n].Sprite = PVAL(4);
        Npc[n].SpawnSecs = PVAL(5);
        Npc[n].Behavior = PVAL(6);
        Npc[n].Range = PVAL(7);
        Npc[n].DropChance = PVAL(8);
        Npc[n].DropItem = PVAL(9);
        Npc[n].DropItemValue = PVAL(10);
        Npc[n].STR = PVAL(11);
        Npc[n].DEF = PVAL(12);
        Npc[n].SPEED = PVAL(13);
        Npc[n].MAGI = PVAL(14);
        // TODO: init npc editor
        free(datacopy);
        return;
    }

    // ::::::::::::::::::::
    // :: Map key packet ::
    // ::::::::::::::::::::
    if (strcmp(cmd, "mapkey") == 0) {
        int x = PVAL(1);
        int y = PVAL(2);
        int n = PVAL(3);
        if (x >= 0 && x <= MAX_MAPX && y >= 0 && y <= MAX_MAPY)
            TempTile[x][y].DoorOpen = n;
        free(datacopy);
        return;
    }

    // :::::::::::::::::::::::
    // :: Edit map packet ::
    // :::::::::::::::::::::::
    if (strcmp(cmd, "editmap") == 0) {
        InEditor = 1;
        // TODO: init map editor
        free(datacopy);
        return;
    }

    // ::::::::::::::::::::::::::
    // :: Shop editor packet ::
    // ::::::::::::::::::::::::::
    if (strcmp(cmd, "shopeditor") == 0) {
        InShopEditor = 1;
        // TODO: show shop editor
        free(datacopy);
        return;
    }

    // ::::::::::::::::::::::::::
    // :: Update shop packet ::
    // ::::::::::::::::::::::::::
    if (strcmp(cmd, "updateshop") == 0) {
        int n = PVAL(1);
        strlcpy_safe(Shop[n].Name, P(2), sizeof(Shop[n].Name));
        free(datacopy);
        return;
    }

    // :::::::::::::::::::::::
    // :: Edit shop packet ::
    // :::::::::::::::::::::::
    if (strcmp(cmd, "editshop") == 0) {
        int shopNum = PVAL(1);
        strlcpy_safe(Shop[shopNum].Name, P(2), sizeof(Shop[shopNum].Name));
        strlcpy_safe(Shop[shopNum].JoinSay, P(3), sizeof(Shop[shopNum].JoinSay));
        strlcpy_safe(Shop[shopNum].LeaveSay, P(4), sizeof(Shop[shopNum].LeaveSay));
        Shop[shopNum].FixesItems = PVAL(5);
        int n = 6;
        for (int i = 1; i <= MAX_TRADES; i++) {
            Shop[shopNum].TradeItem[i].GiveItem = PVAL(n);
            Shop[shopNum].TradeItem[i].GiveValue = PVAL(n + 1);
            Shop[shopNum].TradeItem[i].GetItem = PVAL(n + 2);
            Shop[shopNum].TradeItem[i].GetValue = PVAL(n + 3);
            n += 4;
        }
        // TODO: init shop editor
        free(datacopy);
        return;
    }

    // :::::::::::::::::::::::::::
    // :: Spell editor packet ::
    // :::::::::::::::::::::::::::
    if (strcmp(cmd, "spelleditor") == 0) {
        InSpellEditor = 1;
        // TODO: show spell editor
        free(datacopy);
        return;
    }

    // ::::::::::::::::::::::::::
    // :: Update spell packet ::
    // ::::::::::::::::::::::::::
    if (strcmp(cmd, "updatespell") == 0) {
        int n = PVAL(1);
        strlcpy_safe(Spell[n].Name, P(2), sizeof(Spell[n].Name));
        free(datacopy);
        return;
    }

    // ::::::::::::::::::::::::
    // :: Edit spell packet ::
    // ::::::::::::::::::::::::
    if (strcmp(cmd, "editspell") == 0) {
        int n = PVAL(1);
        strlcpy_safe(Spell[n].Name, P(2), sizeof(Spell[n].Name));
        Spell[n].ClassReq = PVAL(3);
        Spell[n].LevelReq = PVAL(4);
        Spell[n].Type = PVAL(5);
        Spell[n].Data1 = PVAL(6);
        Spell[n].Data2 = PVAL(7);
        Spell[n].Data3 = PVAL(8);
        // TODO: init spell editor
        free(datacopy);
        return;
    }

    // :::::::::::::::::
    // :: Trade packet ::
    // :::::::::::::::::
    if (strcmp(cmd, "trade") == 0) {
        int shopNum = PVAL(1);
        int fixesItems = PVAL(2);
        (void)shopNum; (void)fixesItems;
        // TODO: show trade dialog
        free(datacopy);
        return;
    }

    // ::::::::::::::::::
    // :: Spells packet ::
    // ::::::::::::::::::
    if (strcmp(cmd, "spells") == 0) {
        for (int i = 1; i <= MAX_PLAYER_SPELLS; i++) {
            Player[MyIndex].Spell[i] = PVAL(i);
        }
        // TODO: show spells panel
        free(datacopy);
        return;
    }

    // :::::::::::::::::::::::::
    // :: Weather/time packet ::
    // :::::::::::::::::::::::::
    if (strcmp(cmd, "weather") == 0) {
        GameWeather = PVAL(1);
        free(datacopy);
        return;
    }
    if (strcmp(cmd, "time") == 0) {
        GameTime = PVAL(1);
        free(datacopy);
        return;
    }

    free(datacopy);
}
