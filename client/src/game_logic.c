#include "client.h"

void GameInit(void) {
    InGame = 1;
    GettingMap = 1;
    SetScreen(8); // SCREEN_GAME
}

void GameLoop(void) {
    // Main game logic is now integrated into main.c event loop
}

void GameDestroy(void) {
    InGame = 0;
    TcpDestroy();
    exit(0);
}

void MenuState(int State) {
    switch (State) {
        case MENU_STATE_LOGIN:
            // Handled by UI
            break;
        case MENU_STATE_NEWACCOUNT:
            // Handled by UI
            break;
        case MENU_STATE_DELACCOUNT:
            // Handled by UI
            break;
        case MENU_STATE_GETCHARS:
            SendGetClasses();
            break;
        case MENU_STATE_ADDCHAR:
            // Handled by UI
            break;
        case MENU_STATE_DELCHAR:
            // Handled by UI
            break;
        case MENU_STATE_USECHAR:
            // Handled by UI
            break;
    }
}

void SetStatus(const char *Caption) {
    (void)Caption;
}

void CheckMovement(void) {
    if (!InGame || GettingMap || InChatMode) return;
    int moved = 0, dir = -1;

    if (DirUp) { dir = DIR_UP; moved = 1; }
    else if (DirDown) { dir = DIR_DOWN; moved = 1; }
    else if (DirLeft) { dir = DIR_LEFT; moved = 1; }
    else if (DirRight) { dir = DIR_RIGHT; moved = 1; }

    if (moved && Player[MyIndex].Moving == 0) {
        // Check map bounds and blocking
        int tx = Player[MyIndex].x;
        int ty = Player[MyIndex].y;
        if (dir == DIR_UP) ty--;
        if (dir == DIR_DOWN) ty++;
        if (dir == DIR_LEFT) tx--;
        if (dir == DIR_RIGHT) tx++;

        if (tx >= 0 && tx <= MAX_MAPX && ty >= 0 && ty <= MAX_MAPY) {
            if (Map.Tile[tx][ty].Type != TILE_TYPE_BLOCKED) {
                SendPlayerMove(dir, ShiftDown ? MOVING_RUNNING : MOVING_WALKING);
                SetPlayerDir(MyIndex, dir);
                Player[MyIndex].Moving = ShiftDown ? MOVING_RUNNING : MOVING_WALKING;
                Player[MyIndex].XOffset = 0;
                Player[MyIndex].YOffset = 0;
                if (dir == DIR_UP) Player[MyIndex].YOffset = PIC_Y;
                if (dir == DIR_DOWN) Player[MyIndex].YOffset = -PIC_Y;
                if (dir == DIR_LEFT) Player[MyIndex].XOffset = PIC_X;
                if (dir == DIR_RIGHT) Player[MyIndex].XOffset = -PIC_X;
            }
        }
    }
}

void CheckAttack(void) {
    if (!InGame || GettingMap) return;
    if (ControlDown && Player[MyIndex].Attacking == 0) {
        if (Player[MyIndex].AttackTimer + 1000 < GetTickCount()) {
            Player[MyIndex].Attacking = 1;
            Player[MyIndex].AttackTimer = GetTickCount();
            SendAttack();
        }
    }
}

void ProcessMovement(int Index) {
    if (Player[Index].Moving == MOVING_WALKING) {
        switch (Player[Index].Dir) {
            case DIR_UP: Player[Index].YOffset -= WALK_SPEED; break;
            case DIR_DOWN: Player[Index].YOffset += WALK_SPEED; break;
            case DIR_LEFT: Player[Index].XOffset -= WALK_SPEED; break;
            case DIR_RIGHT: Player[Index].XOffset += WALK_SPEED; break;
        }
        if (Player[Index].XOffset == 0 && Player[Index].YOffset == 0) {
            Player[Index].Moving = 0;
        }
    } else if (Player[Index].Moving == MOVING_RUNNING) {
        switch (Player[Index].Dir) {
            case DIR_UP: Player[Index].YOffset -= RUN_SPEED; break;
            case DIR_DOWN: Player[Index].YOffset += RUN_SPEED; break;
            case DIR_LEFT: Player[Index].XOffset -= RUN_SPEED; break;
            case DIR_RIGHT: Player[Index].XOffset += RUN_SPEED; break;
        }
        if (Player[Index].XOffset == 0 && Player[Index].YOffset == 0) {
            Player[Index].Moving = 0;
        }
    }
}

void ProcessNpcMovement(int MapNpcNum) {
    if (MapNpc[MapNpcNum].Moving == MOVING_WALKING) {
        switch (MapNpc[MapNpcNum].Dir) {
            case DIR_UP: MapNpc[MapNpcNum].YOffset -= WALK_SPEED; break;
            case DIR_DOWN: MapNpc[MapNpcNum].YOffset += WALK_SPEED; break;
            case DIR_LEFT: MapNpc[MapNpcNum].XOffset -= WALK_SPEED; break;
            case DIR_RIGHT: MapNpc[MapNpcNum].XOffset += WALK_SPEED; break;
        }
        if (MapNpc[MapNpcNum].XOffset == 0 && MapNpc[MapNpcNum].YOffset == 0) {
            MapNpc[MapNpcNum].Moving = 0;
        }
    }
}

void HandleKeypresses(int KeyAscii) {
    if (!InGame || GettingMap) return;
    if (!InChatMode) return;

    if (KeyAscii == 13) { // Return
        if (MyText[0]) {
            if (MyText[0] == '\'') {
                BroadcastMsg(MyText + 1);
            } else if (MyText[0] == '-') {
                EmoteMsg(MyText + 1);
            } else if (MyText[0] == '!') {
                char name[256], msg[256];
                if (sscanf(MyText + 1, "%s %255[^\n]", name, msg) == 2) {
                    PlayerMsg(msg, name);
                } else {
                    AddText("Usage: !playername message", AlertColor);
                }
            } else if (MyText[0] == '/') {
                if (strncasecmp(MyText, "/help", 5) == 0) {
                    AddText("Commands: /help, /who, /fps, /stats, /inv, /train, /trade", HelpColor);
                } else if (strncasecmp(MyText, "/who", 4) == 0) {
                    SendWhosOnline();
                } else if (strncasecmp(MyText, "/fps", 4) == 0) {
                    char buf[64];
                    snprintf(buf, sizeof(buf), "FPS: %d", GameFPS);
                    AddText(buf, Pink);
                } else if (strncasecmp(MyText, "/stats", 6) == 0) {
                    SendStatsRequest();
                } else if (strncasecmp(MyText, "/trade", 6) == 0) {
                    SendTradeRequest();
                } else if (strncasecmp(MyText, "/train", 6) == 0) {
                    AddText("Training not yet implemented.", AlertColor);
                } else if (strncasecmp(MyText, "/inv", 4) == 0) {
                    AddText("Inventory toggle not yet implemented.", AlertColor);
                } else if (GetPlayerAccess(MyIndex) > 0) {
                    // Admin commands
                    if (strncasecmp(MyText, "/kick ", 6) == 0) {
                        SendKick(MyText + 6);
                    } else if (strncasecmp(MyText, "/warpmeto ", 10) == 0) {
                        WarpMeTo(MyText + 10);
                    } else if (strncasecmp(MyText, "/warptome ", 10) == 0) {
                        WarpToMe(MyText + 10);
                    } else if (strncasecmp(MyText, "/warpto ", 8) == 0) {
                        WarpTo(atoi(MyText + 8));
                    } else if (strncasecmp(MyText, "/setsprite ", 11) == 0) {
                        SendSetSprite(atoi(MyText + 11));
                    } else if (strncasecmp(MyText, "/mapeditor", 10) == 0) {
                        SendRequestEditMap();
                    } else if (strncasecmp(MyText, "/respawn", 8) == 0) {
                        SendMapRespawn();
                    } else if (strncasecmp(MyText, "/edititem", 9) == 0) {
                        SendRequestEditItem();
                    } else if (strncasecmp(MyText, "/editnpc", 8) == 0) {
                        SendRequestEditNpc();
                    } else if (strncasecmp(MyText, "/editshop", 9) == 0) {
                        SendRequestEditShop();
                    } else if (strncasecmp(MyText, "/editspell", 10) == 0) {
                        SendRequestEditSpell();
                    }
                }
            } else {
                // Say message
                PKT_INIT(pkt);
                PKT_S(pkt, "saymsg"); PKT_S(pkt, MyText); PKT_END(pkt);
                SendData(pkt);
            }
        }
        MyText[0] = '\0';
        InChatMode = 0;
    } else if (KeyAscii == 27) { // Escape
        MyText[0] = '\0';
        InChatMode = 0;
    }
}

// Player getters/setters
const char *GetPlayerName(int Index) {
    static char buf[NAME_LENGTH + 1];
    strlcpy_safe(buf, Player[Index].Name, sizeof(buf));
    str_trim(buf);
    return buf;
}

void SetPlayerName(int Index, const char *Name) {
    strlcpy_safe(Player[Index].Name, Name, sizeof(Player[Index].Name));
}

int GetPlayerClass(int Index) { return Player[Index].Class; }
void SetPlayerClass(int Index, int ClassNum) { Player[Index].Class = ClassNum; }

int GetPlayerSprite(int Index) { return Player[Index].Sprite; }
void SetPlayerSprite(int Index, int Sprite) { Player[Index].Sprite = Sprite; }

int GetPlayerLevel(int Index) { return Player[Index].Level; }
void SetPlayerLevel(int Index, int Level) { Player[Index].Level = Level; }

int GetPlayerExp(int Index) { return Player[Index].Exp; }
void SetPlayerExp(int Index, int Exp) { Player[Index].Exp = Exp; }

int GetPlayerAccess(int Index) { return Player[Index].Access; }
void SetPlayerAccess(int Index, int Access) { Player[Index].Access = Access; }

int GetPlayerPK(int Index) { return Player[Index].PK; }
void SetPlayerPK(int Index, int PK) { Player[Index].PK = PK; }

int GetPlayerHP(int Index) { return Player[Index].HP; }
void SetPlayerHP(int Index, int HP) { Player[Index].HP = HP; }

int GetPlayerMP(int Index) { return Player[Index].MP; }
void SetPlayerMP(int Index, int MP) { Player[Index].MP = MP; }

int GetPlayerSP(int Index) { return Player[Index].SP; }
void SetPlayerSP(int Index, int SP) { Player[Index].SP = SP; }

int GetPlayerMaxHP(int Index) { return Player[Index].MaxHP; }
int GetPlayerMaxMP(int Index) { return Player[Index].MaxMP; }
int GetPlayerMaxSP(int Index) { return Player[Index].MaxSP; }

int GetPlayerSTR(int Index) { return Player[Index].STR; }
void SetPlayerSTR(int Index, int STR) { Player[Index].STR = STR; }

int GetPlayerDEF(int Index) { return Player[Index].DEF; }
void SetPlayerDEF(int Index, int DEF) { Player[Index].DEF = DEF; }

int GetPlayerSPEED(int Index) { return Player[Index].SPEED; }
void SetPlayerSPEED(int Index, int SPEED) { Player[Index].SPEED = SPEED; }

int GetPlayerMAGI(int Index) { return Player[Index].MAGI; }
void SetPlayerMAGI(int Index, int MAGI) { Player[Index].MAGI = MAGI; }

int GetPlayerPOINTS(int Index) { return Player[Index].POINTS; }
void SetPlayerPOINTS(int Index, int POINTS) { Player[Index].POINTS = POINTS; }

int GetPlayerMap(int Index) { return Player[Index].Map; }
void SetPlayerMap(int Index, int MapNum) { Player[Index].Map = MapNum; }

int GetPlayerX(int Index) { return Player[Index].x; }
void SetPlayerX(int Index, int x) { Player[Index].x = x; }

int GetPlayerY(int Index) { return Player[Index].y; }
void SetPlayerY(int Index, int y) { Player[Index].y = y; }

int GetPlayerDir(int Index) { return Player[Index].Dir; }
void SetPlayerDir(int Index, int Dir) { Player[Index].Dir = Dir; }

int GetPlayerInvItemNum(int Index, int InvSlot) { return Player[Index].Inv[InvSlot].Num; }
void SetPlayerInvItemNum(int Index, int InvSlot, int ItemNum) { Player[Index].Inv[InvSlot].Num = ItemNum; }

int GetPlayerInvItemValue(int Index, int InvSlot) { return Player[Index].Inv[InvSlot].Value; }
void SetPlayerInvItemValue(int Index, int InvSlot, int ItemValue) { Player[Index].Inv[InvSlot].Value = ItemValue; }

int GetPlayerInvItemDur(int Index, int InvSlot) { return Player[Index].Inv[InvSlot].Dur; }
void SetPlayerInvItemDur(int Index, int InvSlot, int ItemDur) { Player[Index].Inv[InvSlot].Dur = ItemDur; }

int GetPlayerArmorSlot(int Index) { return Player[Index].ArmorSlot; }
void SetPlayerArmorSlot(int Index, int InvNum) { Player[Index].ArmorSlot = InvNum; }

int GetPlayerWeaponSlot(int Index) { return Player[Index].WeaponSlot; }
void SetPlayerWeaponSlot(int Index, int InvNum) { Player[Index].WeaponSlot = InvNum; }

int GetPlayerHelmetSlot(int Index) { return Player[Index].HelmetSlot; }
void SetPlayerHelmetSlot(int Index, int InvNum) { Player[Index].HelmetSlot = InvNum; }

int GetPlayerShieldSlot(int Index) { return Player[Index].ShieldSlot; }
void SetPlayerShieldSlot(int Index, int InvNum) { Player[Index].ShieldSlot = InvNum; }
