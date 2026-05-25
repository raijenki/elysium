/*
 * game_logic.c - Game logic functions for Mirage Online C server
 * Converted from VB6 modGameLogic.bas
 */

#include "server.h"
#include <stdarg.h>

/* ===================== */
/* Packet building helper */
/* ===================== */

/*
 * Build packets with embedded null separators.
 * Format: "COMMAND\0field1\0field2\0\xED"
 * Returns new position after appending, or pos on error.
 * Uses pos tracking with memcpy since SEP_CHAR is '\0'.
 */
static int pkt_put(char *buf, int pos, int bufsize, const char *str)
{
    int len = (int)strlen(str);
    if (pos + len + 1 > bufsize) return pos;
    memcpy(buf + pos, str, len);
    pos += len;
    buf[pos++] = SEP_CHAR;
    return pos;
}

static int pkt_putint(char *buf, int pos, int bufsize, int val)
{
    char tmp[32];
    snprintf(tmp, sizeof(tmp), "%d", val);
    return pkt_put(buf, pos, bufsize, tmp);
}

static int pkt_end(char *buf, int pos, int bufsize)
{
    if (pos + 1 > bufsize) return pos;
    buf[pos++] = END_CHAR;
    return pos;
}

/* Send packet with length tracking (find END_CHAR to determine length) */
static void SendPacketToMap(int MapNum, const char *pkt, int len)
{
    /* SendDataToMap expects null-terminated but our packets have embedded nulls.
     * We'll pass the raw buffer; the network layer should handle length. */
    (void)len;
    SendDataToMap(MapNum, pkt);
}

/* ===================== */
/* Combat Functions      */
/* ===================== */

int GetPlayerDamage(int Index)
{
    int Damage = 0;
    int WeaponSlot;

    if (!IsPlaying(Index) || Index <= 0 || Index > MAX_PLAYERS)
        return 0;

    Damage = GetPlayerSTR(Index) / 2;
    if (Damage <= 0)
        Damage = 1;

    WeaponSlot = GetPlayerWeaponSlot(Index);
    if (WeaponSlot > 0) {
        int itemNum = GetPlayerInvItemNum(Index, WeaponSlot);
        Damage += Item_[itemNum].Data2;

        SetPlayerInvItemDur(Index, WeaponSlot, GetPlayerInvItemDur(Index, WeaponSlot) - 1);

        if (GetPlayerInvItemDur(Index, WeaponSlot) <= 0) {
            char msg[256];
            snprintf(msg, sizeof(msg), "Your %s has broken.", Item_[itemNum].Name);
            PlayerMsg(Index, msg, Yellow);
            TakeItem_(Index, itemNum, 0);
        } else if (GetPlayerInvItemDur(Index, WeaponSlot) <= 5) {
            char msg[256];
            snprintf(msg, sizeof(msg), "Your %s is about to break!", Item_[GetPlayerInvItemNum(Index, WeaponSlot)].Name);
            PlayerMsg(Index, msg, Yellow);
        }
    }

    return Damage;
}

int GetPlayerProtection(int Index)
{
    int Protection = 0;
    int ArmorSlot, HelmSlot;

    if (!IsPlaying(Index) || Index <= 0 || Index > MAX_PLAYERS)
        return 0;

    ArmorSlot = GetPlayerArmorSlot(Index);
    HelmSlot = GetPlayerHelmetSlot(Index);
    Protection = GetPlayerDEF(Index) / 5;

    if (ArmorSlot > 0) {
        int itemNum = GetPlayerInvItemNum(Index, ArmorSlot);
        Protection += Item_[itemNum].Data2;

        SetPlayerInvItemDur(Index, ArmorSlot, GetPlayerInvItemDur(Index, ArmorSlot) - 1);

        if (GetPlayerInvItemDur(Index, ArmorSlot) <= 0) {
            char msg[256];
            snprintf(msg, sizeof(msg), "Your %s has broken.", Item_[itemNum].Name);
            PlayerMsg(Index, msg, Yellow);
            TakeItem_(Index, itemNum, 0);
        } else if (GetPlayerInvItemDur(Index, ArmorSlot) <= 5) {
            char msg[256];
            snprintf(msg, sizeof(msg), "Your %s is about to break!", Item_[GetPlayerInvItemNum(Index, ArmorSlot)].Name);
            PlayerMsg(Index, msg, Yellow);
        }
    }

    if (HelmSlot > 0) {
        int itemNum = GetPlayerInvItemNum(Index, HelmSlot);
        Protection += Item_[itemNum].Data2;

        SetPlayerInvItemDur(Index, HelmSlot, GetPlayerInvItemDur(Index, HelmSlot) - 1);

        if (GetPlayerInvItemDur(Index, HelmSlot) <= 0) {
            char msg[256];
            snprintf(msg, sizeof(msg), "Your %s has broken.", Item_[itemNum].Name);
            PlayerMsg(Index, msg, Yellow);
            TakeItem_(Index, itemNum, 0);
        } else if (GetPlayerInvItemDur(Index, HelmSlot) <= 5) {
            char msg[256];
            snprintf(msg, sizeof(msg), "Your %s is about to break!", Item_[GetPlayerInvItemNum(Index, HelmSlot)].Name);
            PlayerMsg(Index, msg, Yellow);
        }
    }

    return Protection;
}

int CanAttackPlayer(int Attacker, int Victim)
{
    int ax, ay, vx, vy;
    int adjacent = 0;

    if (!IsPlaying(Attacker) || !IsPlaying(Victim))
        return 0;

    if (GetPlayerHP(Victim) <= 0)
        return 0;

    if (Player[Victim].GettingMap == YES)
        return 0;

    if (GetPlayerMap(Attacker) != GetPlayerMap(Victim))
        return 0;

    if (GetTickCount() <= Player[Attacker].AttackTimer + 950)
        return 0;

    ax = GetPlayerX(Attacker);
    ay = GetPlayerY(Attacker);
    vx = GetPlayerX(Victim);
    vy = GetPlayerY(Victim);

    /* Check adjacency based on attacker direction */
    switch (GetPlayerDir(Attacker)) {
        case DIR_UP:
            if (vy + 1 == ay && vx == ax) adjacent = 1;
            break;
        case DIR_DOWN:
            if (vy - 1 == ay && vx == ax) adjacent = 1;
            break;
        case DIR_LEFT:
            if (vy == ay && vx + 1 == ax) adjacent = 1;
            break;
        case DIR_RIGHT:
            if (vy == ay && vx - 1 == ax) adjacent = 1;
            break;
    }

    if (!adjacent)
        return 0;

    /* Check admin status */
    if (GetPlayerAccess(Attacker) > ADMIN_MONITER) {
        PlayerMsg(Attacker, "You cannot attack any player for thou art an admin!", BrightBlue);
        return 0;
    }

    if (GetPlayerAccess(Victim) > ADMIN_MONITER) {
        char msg[256];
        snprintf(msg, sizeof(msg), "You cannot attack %s!", GetPlayerName(Victim));
        PlayerMsg(Attacker, msg, BrightRed);
        return 0;
    }

    /* Check map moral */
    if (Map_[GetPlayerMap(Attacker)].Moral != MAP_MORAL_NONE && GetPlayerPK(Victim) != YES) {
        PlayerMsg(Attacker, "This is a safe zone!", BrightRed);
        return 0;
    }

    /* Check levels */
    if (GetPlayerLevel(Attacker) < 10) {
        PlayerMsg(Attacker, "You are below level 10, you cannot attack another player yet!", BrightRed);
        return 0;
    }

    if (GetPlayerLevel(Victim) < 10) {
        char msg[256];
        snprintf(msg, sizeof(msg), "%s is below level 10, you cannot attack this player yet!", GetPlayerName(Victim));
        PlayerMsg(Attacker, msg, BrightRed);
        return 0;
    }

    return 1;
}

int CanAttackNpc(int Attacker, int MapNpcNum)
{
    int MapNum, NpcNum;
    int adjacent = 0;

    if (!IsPlaying(Attacker) || MapNpcNum <= 0 || MapNpcNum > MAX_MAP_NPCS)
        return 0;

    if (MapNpc_[GetPlayerMap(Attacker)][MapNpcNum].Num <= 0)
        return 0;

    MapNum = GetPlayerMap(Attacker);
    NpcNum = MapNpc_[MapNum][MapNpcNum].Num;

    if (MapNpc_[MapNum][MapNpcNum].HP <= 0)
        return 0;

    if (!IsPlaying(Attacker))
        return 0;

    if (NpcNum <= 0 || GetTickCount() <= Player[Attacker].AttackTimer + 950)
        return 0;

    /* Check adjacency based on attacker direction */
    switch (GetPlayerDir(Attacker)) {
        case DIR_UP:
            if (MapNpc_[MapNum][MapNpcNum].y + 1 == GetPlayerY(Attacker) &&
                MapNpc_[MapNum][MapNpcNum].x == GetPlayerX(Attacker))
                adjacent = 1;
            break;
        case DIR_DOWN:
            if (MapNpc_[MapNum][MapNpcNum].y - 1 == GetPlayerY(Attacker) &&
                MapNpc_[MapNum][MapNpcNum].x == GetPlayerX(Attacker))
                adjacent = 1;
            break;
        case DIR_LEFT:
            if (MapNpc_[MapNum][MapNpcNum].y == GetPlayerY(Attacker) &&
                MapNpc_[MapNum][MapNpcNum].x + 1 == GetPlayerX(Attacker))
                adjacent = 1;
            break;
        case DIR_RIGHT:
            if (MapNpc_[MapNum][MapNpcNum].y == GetPlayerY(Attacker) &&
                MapNpc_[MapNum][MapNpcNum].x - 1 == GetPlayerX(Attacker))
                adjacent = 1;
            break;
    }

    if (!adjacent)
        return 0;

    if (Npc_[NpcNum].Behavior == NPC_BEHAVIOR_FRIENDLY ||
        Npc_[NpcNum].Behavior == NPC_BEHAVIOR_SHOPKEEPER) {
        char msg[256];
        snprintf(msg, sizeof(msg), "You cannot attack a %s!", Npc_[NpcNum].Name);
        PlayerMsg(Attacker, msg, BrightBlue);
        return 0;
    }

    return 1;
}

int CanNpcAttackPlayer(int MapNpcNum, int Index)
{
    int MapNum, NpcNum;

    if (MapNpcNum <= 0 || MapNpcNum > MAX_MAP_NPCS || !IsPlaying(Index))
        return 0;

    if (MapNpc_[GetPlayerMap(Index)][MapNpcNum].Num <= 0)
        return 0;

    MapNum = GetPlayerMap(Index);
    NpcNum = MapNpc_[MapNum][MapNpcNum].Num;

    if (MapNpc_[MapNum][MapNpcNum].HP <= 0)
        return 0;

    if (GetTickCount() < MapNpc_[MapNum][MapNpcNum].AttackTimer + 1000)
        return 0;

    if (Player[Index].GettingMap == YES)
        return 0;

    MapNpc_[MapNum][MapNpcNum].AttackTimer = GetTickCount();

    if (!IsPlaying(Index) || NpcNum <= 0)
        return 0;

    /* Check all four adjacent tiles (NPC can attack from any adjacent position) */
    if ((GetPlayerY(Index) + 1 == MapNpc_[MapNum][MapNpcNum].y &&
         GetPlayerX(Index) == MapNpc_[MapNum][MapNpcNum].x) ||
        (GetPlayerY(Index) - 1 == MapNpc_[MapNum][MapNpcNum].y &&
         GetPlayerX(Index) == MapNpc_[MapNum][MapNpcNum].x) ||
        (GetPlayerY(Index) == MapNpc_[MapNum][MapNpcNum].y &&
         GetPlayerX(Index) + 1 == MapNpc_[MapNum][MapNpcNum].x) ||
        (GetPlayerY(Index) == MapNpc_[MapNum][MapNpcNum].y &&
         GetPlayerX(Index) - 1 == MapNpc_[MapNum][MapNpcNum].x)) {
        return 1;
    }

    return 0;
}

void AttackPlayer(int Attacker, int Victim, int Damage)
{
    int n;
    int Exp;
    char pkt[512];
    int pos;
    char msg[512];

    if (!IsPlaying(Attacker) || !IsPlaying(Victim) || Damage < 0)
        return;

    /* Check for weapon */
    if (GetPlayerWeaponSlot(Attacker) > 0)
        n = GetPlayerInvItemNum(Attacker, GetPlayerWeaponSlot(Attacker));
    else
        n = 0;

    /* Send attack animation packet */
    pos = 0;
    pos = pkt_put(pkt, pos, sizeof(pkt), "ATTACK");
    pos = pkt_putint(pkt, pos, sizeof(pkt), Attacker);
    pos = pkt_end(pkt, pos, sizeof(pkt));
    SendDataToMapBut(Attacker, GetPlayerMap(Attacker), pkt);

    if (Damage >= GetPlayerHP(Victim)) {
        /* Set HP to nothing */
        SetPlayerHP(Victim, 0);

        /* Announce damage */
        if (n == 0) {
            snprintf(msg, sizeof(msg), "You hit %s for %d hit points.", GetPlayerName(Victim), Damage);
            PlayerMsg(Attacker, msg, White);
            snprintf(msg, sizeof(msg), "%s hit you for %d hit points.", GetPlayerName(Attacker), Damage);
            PlayerMsg(Victim, msg, BrightRed);
        } else {
            snprintf(msg, sizeof(msg), "You hit %s with a %s for %d hit points.", GetPlayerName(Victim), Item_[n].Name, Damage);
            PlayerMsg(Attacker, msg, White);
            snprintf(msg, sizeof(msg), "%s hit you with a %s for %d hit points.", GetPlayerName(Attacker), Item_[n].Name, Damage);
            PlayerMsg(Victim, msg, BrightRed);
        }

        /* Player is dead */
        snprintf(msg, sizeof(msg), "%s has been killed by %s", GetPlayerName(Victim), GetPlayerName(Attacker));
        GlobalMsg(msg, BrightRed);

        /* Drop all worn items by victim */
        if (GetPlayerWeaponSlot(Victim) > 0)
            PlayerMapDropItem(Victim, GetPlayerWeaponSlot(Victim), 0);
        if (GetPlayerArmorSlot(Victim) > 0)
            PlayerMapDropItem(Victim, GetPlayerArmorSlot(Victim), 0);
        if (GetPlayerHelmetSlot(Victim) > 0)
            PlayerMapDropItem(Victim, GetPlayerHelmetSlot(Victim), 0);
        if (GetPlayerShieldSlot(Victim) > 0)
            PlayerMapDropItem(Victim, GetPlayerShieldSlot(Victim), 0);

        /* Calculate exp */
        Exp = GetPlayerExp(Victim) / 10;
        if (Exp < 0) Exp = 0;

        if (Exp == 0) {
            PlayerMsg(Victim, "You lost no experience points.", BrightRed);
            PlayerMsg(Attacker, "You received no experience points from that weak insignificant player.", BrightBlue);
        } else {
            SetPlayerExp(Victim, GetPlayerExp(Victim) - Exp);
            snprintf(msg, sizeof(msg), "You lost %d experience points.", Exp);
            PlayerMsg(Victim, msg, BrightRed);
            SetPlayerExp(Attacker, GetPlayerExp(Attacker) + Exp);
            snprintf(msg, sizeof(msg), "You got %d experience points for killing %s.", Exp, GetPlayerName(Victim));
            PlayerMsg(Attacker, msg, BrightBlue);
        }

        /* Warp player to start */
        PlayerWarp(Victim, START_MAP, START_X, START_Y);

        /* Restore vitals */
        SetPlayerHP(Victim, GetPlayerMaxHP(Victim));
        SetPlayerMP(Victim, GetPlayerMaxMP(Victim));
        SetPlayerSP(Victim, GetPlayerMaxSP(Victim));
        SendHP(Victim);
        SendMP(Victim);
        SendSP(Victim);

        /* Check for a level up */
        CheckPlayerLevelUp(Attacker);

        /* Clear target if it was the victim */
        if (Player[Attacker].TargetType == TARGET_TYPE_PLAYER && Player[Attacker].Target == Victim) {
            Player[Attacker].Target = 0;
            Player[Attacker].TargetType = 0;
        }

        /* Handle PK flagging */
        if (GetPlayerPK(Victim) == NO) {
            if (GetPlayerPK(Attacker) == NO) {
                SetPlayerPK(Attacker, YES);
                SendPlayerData(Attacker);
                snprintf(msg, sizeof(msg), "%s has been deemed a Player Killer!!!", GetPlayerName(Attacker));
                GlobalMsg(msg, BrightRed);
            }
        } else {
            SetPlayerPK(Victim, NO);
            SendPlayerData(Victim);
            snprintf(msg, sizeof(msg), "%s has paid the price for being a Player Killer!!!", GetPlayerName(Victim));
            GlobalMsg(msg, BrightRed);
        }
    } else {
        /* Player not dead, just do the damage */
        SetPlayerHP(Victim, GetPlayerHP(Victim) - Damage);
        SendHP(Victim);

        if (n == 0) {
            snprintf(msg, sizeof(msg), "You hit %s for %d hit points.", GetPlayerName(Victim), Damage);
            PlayerMsg(Attacker, msg, White);
            snprintf(msg, sizeof(msg), "%s hit you for %d hit points.", GetPlayerName(Attacker), Damage);
            PlayerMsg(Victim, msg, BrightRed);
        } else {
            snprintf(msg, sizeof(msg), "You hit %s with a %s for %d hit points.", GetPlayerName(Victim), Item_[n].Name, Damage);
            PlayerMsg(Attacker, msg, White);
            snprintf(msg, sizeof(msg), "%s hit you with a %s for %d hit points.", GetPlayerName(Attacker), Item_[n].Name, Damage);
            PlayerMsg(Victim, msg, BrightRed);
        }
    }

    /* Reset attack timer */
    Player[Attacker].AttackTimer = GetTickCount();
}

void NpcAttackPlayer(int MapNpcNum, int Victim, int Damage)
{
    int MapNum;
    int Exp;
    int NpcNum;
    char pkt[512];
    int pos;
    char msg[512];
    const char *Name;

    if (MapNpcNum <= 0 || MapNpcNum > MAX_MAP_NPCS || !IsPlaying(Victim) || Damage < 0)
        return;

    if (MapNpc_[GetPlayerMap(Victim)][MapNpcNum].Num <= 0)
        return;

    /* Send NPC attack animation */
    pos = 0;
    pos = pkt_put(pkt, pos, sizeof(pkt), "NPCATTACK");
    pos = pkt_putint(pkt, pos, sizeof(pkt), MapNpcNum);
    pos = pkt_end(pkt, pos, sizeof(pkt));
    SendDataToMap(GetPlayerMap(Victim), pkt);

    MapNum = GetPlayerMap(Victim);
    NpcNum = MapNpc_[MapNum][MapNpcNum].Num;
    Name = Npc_[NpcNum].Name;

    if (Damage >= GetPlayerHP(Victim)) {
        /* Say damage */
        snprintf(msg, sizeof(msg), "A %s hit you for %d hit points.", Name, Damage);
        PlayerMsg(Victim, msg, BrightRed);

        /* Player is dead */
        snprintf(msg, sizeof(msg), "%s has been killed by a %s", GetPlayerName(Victim), Name);
        GlobalMsg(msg, BrightRed);

        /* Drop all worn items */
        if (GetPlayerWeaponSlot(Victim) > 0)
            PlayerMapDropItem(Victim, GetPlayerWeaponSlot(Victim), 0);
        if (GetPlayerArmorSlot(Victim) > 0)
            PlayerMapDropItem(Victim, GetPlayerArmorSlot(Victim), 0);
        if (GetPlayerHelmetSlot(Victim) > 0)
            PlayerMapDropItem(Victim, GetPlayerHelmetSlot(Victim), 0);
        if (GetPlayerShieldSlot(Victim) > 0)
            PlayerMapDropItem(Victim, GetPlayerShieldSlot(Victim), 0);

        /* Calculate exp loss */
        Exp = GetPlayerExp(Victim) / 3;
        if (Exp < 0) Exp = 0;

        if (Exp == 0) {
            PlayerMsg(Victim, "You lost no experience points.", BrightRed);
        } else {
            SetPlayerExp(Victim, GetPlayerExp(Victim) - Exp);
            snprintf(msg, sizeof(msg), "You lost %d experience points.", Exp);
            PlayerMsg(Victim, msg, BrightRed);
        }

        /* Warp player to start */
        PlayerWarp(Victim, START_MAP, START_X, START_Y);

        /* Restore vitals */
        SetPlayerHP(Victim, GetPlayerMaxHP(Victim));
        SetPlayerMP(Victim, GetPlayerMaxMP(Victim));
        SetPlayerSP(Victim, GetPlayerMaxSP(Victim));
        SendHP(Victim);
        SendMP(Victim);
        SendSP(Victim);

        /* Set NPC target to 0 */
        MapNpc_[MapNum][MapNpcNum].Target = 0;

        /* If the victim was a PK, clear the flag */
        if (GetPlayerPK(Victim) == YES) {
            SetPlayerPK(Victim, NO);
            SendPlayerData(Victim);
        }
    } else {
        /* Player not dead, just do damage */
        SetPlayerHP(Victim, GetPlayerHP(Victim) - Damage);
        SendHP(Victim);

        snprintf(msg, sizeof(msg), "A %s hit you for %d hit points.", Name, Damage);
        PlayerMsg(Victim, msg, BrightRed);
    }
}

void AttackNpc(int Attacker, int MapNpcNum, int Damage)
{
    int n, i;
    int Exp;
    int MapNum, NpcNum;
    int npcSTR, npcDEF;
    char pkt[512];
    int pos;
    char msg[512];
    const char *Name;

    if (!IsPlaying(Attacker) || MapNpcNum <= 0 || MapNpcNum > MAX_MAP_NPCS || Damage < 0)
        return;

    /* Check for weapon */
    if (GetPlayerWeaponSlot(Attacker) > 0)
        n = GetPlayerInvItemNum(Attacker, GetPlayerWeaponSlot(Attacker));
    else
        n = 0;

    /* Send attack animation */
    pos = 0;
    pos = pkt_put(pkt, pos, sizeof(pkt), "ATTACK");
    pos = pkt_putint(pkt, pos, sizeof(pkt), Attacker);
    pos = pkt_end(pkt, pos, sizeof(pkt));
    SendDataToMapBut(Attacker, GetPlayerMap(Attacker), pkt);

    MapNum = GetPlayerMap(Attacker);
    NpcNum = MapNpc_[MapNum][MapNpcNum].Num;
    Name = Npc_[NpcNum].Name;

    if (Damage >= MapNpc_[MapNum][MapNpcNum].HP) {
        /* NPC is dead */
        if (n == 0) {
            snprintf(msg, sizeof(msg), "You hit a %s for %d hit points, killing it.", Name, Damage);
        } else {
            snprintf(msg, sizeof(msg), "You hit a %s with a %s for %d hit points, killing it.", Name, Item_[n].Name, Damage);
        }
        PlayerMsg(Attacker, msg, BrightRed);

        /* Calculate exp */
        npcSTR = Npc_[NpcNum].STR;
        npcDEF = Npc_[NpcNum].DEF;
        Exp = npcSTR * npcDEF * 2;
        if (Exp < 0) Exp = 1;

        /* Check if in party */
        if (Player[Attacker].InParty == NO) {
            SetPlayerExp(Attacker, GetPlayerExp(Attacker) + Exp);
            snprintf(msg, sizeof(msg), "You have gained %d experience points.", Exp);
            PlayerMsg(Attacker, msg, BrightBlue);
        } else {
            Exp = Exp / 2;
            if (Exp < 0) Exp = 1;

            SetPlayerExp(Attacker, GetPlayerExp(Attacker) + Exp);
            snprintf(msg, sizeof(msg), "You have gained %d party experience points.", Exp);
            PlayerMsg(Attacker, msg, BrightBlue);

            n = Player[Attacker].PartyPlayer;
            if (n > 0) {
                SetPlayerExp(n, GetPlayerExp(n) + Exp);
                snprintf(msg, sizeof(msg), "You have gained %d party experience points.", Exp);
                PlayerMsg(n, msg, BrightBlue);
            }
        }

        /* Drop items based on chance */
        n = (rand() % Npc_[NpcNum].DropChance) + 1;
        if (n == 1) {
            SpawnItem(Npc_[NpcNum].DropItem, Npc_[NpcNum].DropItemValue, MapNum,
                      MapNpc_[MapNum][MapNpcNum].x, MapNpc_[MapNum][MapNpcNum].y);
        }

        /* Kill the NPC */
        MapNpc_[MapNum][MapNpcNum].Num = 0;
        MapNpc_[MapNum][MapNpcNum].SpawnWait = GetTickCount();
        MapNpc_[MapNum][MapNpcNum].HP = 0;

        pos = 0;
        pos = pkt_put(pkt, pos, sizeof(pkt), "NPCDEAD");
        pos = pkt_putint(pkt, pos, sizeof(pkt), MapNpcNum);
        pos = pkt_end(pkt, pos, sizeof(pkt));
        SendDataToMap(MapNum, pkt);

        /* Check for level up */
        CheckPlayerLevelUp(Attacker);

        /* Check for party member level up */
        if (Player[Attacker].InParty == YES) {
            CheckPlayerLevelUp(Player[Attacker].PartyPlayer);
        }

        /* Clear target if it was this NPC */
        if (Player[Attacker].TargetType == TARGET_TYPE_NPC && Player[Attacker].Target == MapNpcNum) {
            Player[Attacker].Target = 0;
            Player[Attacker].TargetType = 0;
        }
    } else {
        /* NPC not dead, just do damage */
        MapNpc_[MapNum][MapNpcNum].HP -= Damage;

        if (n == 0) {
            snprintf(msg, sizeof(msg), "You hit a %s for %d hit points.", Name, Damage);
        } else {
            snprintf(msg, sizeof(msg), "You hit a %s with a %s for %d hit points.", Name, Item_[n].Name, Damage);
        }
        PlayerMsg(Attacker, msg, White);

        /* Check if we should send attack say */
        if (MapNpc_[MapNum][MapNpcNum].Target == 0 && MapNpc_[MapNum][MapNpcNum].Target != Attacker) {
            if (strlen(Npc_[NpcNum].AttackSay) > 0) {
                snprintf(msg, sizeof(msg), "A %s says, '%s' to you.", Npc_[NpcNum].Name, Npc_[NpcNum].AttackSay);
                PlayerMsg(Attacker, msg, SayColor);
            }
        }

        /* Set NPC target to attacker */
        MapNpc_[MapNum][MapNpcNum].Target = Attacker;

        /* Check for guard AI */
        if (Npc_[MapNpc_[MapNum][MapNpcNum].Num].Behavior == NPC_BEHAVIOR_GUARD) {
            for (i = 1; i <= MAX_MAP_NPCS; i++) {
                if (MapNpc_[MapNum][i].Num == MapNpc_[MapNum][MapNpcNum].Num) {
                    MapNpc_[MapNum][i].Target = Attacker;
                }
            }
        }
    }

    /* Reset attack timer */
    Player[Attacker].AttackTimer = GetTickCount();
}

int CanPlayerCriticalHit(int Index)
{
    int i, n;

    if (GetPlayerWeaponSlot(Index) <= 0)
        return 0;

    n = rand() % 2;
    if (n == 1) {
        i = (GetPlayerSTR(Index) / 2) + (GetPlayerLevel(Index) / 2);
        n = (rand() % 100) + 1;
        if (n <= i)
            return 1;
    }

    return 0;
}

int CanPlayerBlockHit(int Index)
{
    int i, n;
    int ShieldSlot;

    ShieldSlot = GetPlayerShieldSlot(Index);

    if (ShieldSlot <= 0)
        return 0;

    n = rand() % 2;
    if (n == 1) {
        i = (GetPlayerDEF(Index) / 2) + (GetPlayerLevel(Index) / 2);
        n = (rand() % 100) + 1;
        if (n <= i)
            return 1;
    }

    return 0;
}

/* ======================== */
/* Inventory Functions      */
/* ======================== */

int FindOpenPlayerSlot(void)
{
    int i;

    for (i = 1; i <= MAX_PLAYERS; i++) {
        if (!IsConnected(i))
            return i;
    }

    return 0;
}

int FindOpenInvSlot(int Index, int ItemNum)
{
    int i;

    if (!IsPlaying(Index) || ItemNum <= 0 || ItemNum > MAX_ITEMS)
        return 0;

    /* If currency, check if they already have one */
    if (Item_[ItemNum].Type == ITEM_TYPE_CURRENCY) {
        for (i = 1; i <= MAX_INV; i++) {
            if (GetPlayerInvItemNum(Index, i) == ItemNum)
                return i;
        }
    }

    /* Find an open slot */
    for (i = 1; i <= MAX_INV; i++) {
        if (GetPlayerInvItemNum(Index, i) == 0)
            return i;
    }

    return 0;
}

int FindOpenMapItemSlot(int MapNum)
{
    int i;

    if (MapNum <= 0 || MapNum > MAX_MAPS)
        return 0;

    for (i = 1; i <= MAX_MAP_ITEMS; i++) {
        if (MapItem_[MapNum][i].Num == 0)
            return i;
    }

    return 0;
}

int FindOpenSpellSlot(int Index)
{
    int i;

    for (i = 1; i <= MAX_PLAYER_SPELLS; i++) {
        if (GetPlayerSpell_(Index, i) == 0)
            return i;
    }

    return 0;
}

int HasSpell(int Index, int SpellNum)
{
    int i;

    for (i = 1; i <= MAX_PLAYER_SPELLS; i++) {
        if (GetPlayerSpell_(Index, i) == SpellNum)
            return 1;
    }

    return 0;
}

int TotalOnlinePlayers(void)
{
    int i, count = 0;

    for (i = 1; i <= MAX_PLAYERS; i++) {
        if (IsPlaying(i))
            count++;
    }

    return count;
}

int FindPlayer(const char *Name)
{
    int i;
    size_t namelen;
    char upperName[NAME_LENGTH + 1];
    char upperPlayer[NAME_LENGTH + 1];

    if (!Name) return 0;

    /* Trim and get length */
    namelen = strlen(Name);
    if (namelen == 0) return 0;

    /* Make uppercase copy of search name */
    for (i = 0; i < (int)namelen && i < NAME_LENGTH; i++)
        upperName[i] = toupper((unsigned char)Name[i]);
    upperName[namelen < NAME_LENGTH ? namelen : NAME_LENGTH] = '\0';

    for (i = 1; i <= MAX_PLAYERS; i++) {
        if (IsPlaying(i)) {
            const char *pname = GetPlayerName(i);
            size_t plen = strlen(pname);

            if (plen >= namelen) {
                int j;
                int match = 1;
                for (j = 0; j < (int)namelen; j++) {
                    if (toupper((unsigned char)pname[j]) != upperName[j]) {
                        match = 0;
                        break;
                    }
                }
                if (match)
                    return i;
            }
        }
    }

    return 0;
}

int HasItem(int Index, int ItemNum)
{
    int i;

    if (!IsPlaying(Index) || ItemNum <= 0 || ItemNum > MAX_ITEMS)
        return 0;

    for (i = 1; i <= MAX_INV; i++) {
        if (GetPlayerInvItemNum(Index, i) == ItemNum) {
            if (Item_[ItemNum].Type == ITEM_TYPE_CURRENCY)
                return GetPlayerInvItemValue(Index, i);
            else
                return 1;
        }
    }

    return 0;
}

void TakeItem_(int Index, int ItemNum, int ItemVal)
{
    int i, n;
    int doTake;

    if (!IsPlaying(Index) || ItemNum <= 0 || ItemNum > MAX_ITEMS)
        return;

    for (i = 1; i <= MAX_INV; i++) {
        if (GetPlayerInvItemNum(Index, i) != ItemNum)
            continue;

        doTake = 0;

        if (Item_[ItemNum].Type == ITEM_TYPE_CURRENCY) {
            if (ItemVal >= GetPlayerInvItemValue(Index, i)) {
                doTake = 1;
            } else {
                SetPlayerInvItemValue(Index, i, GetPlayerInvItemValue(Index, i) - ItemVal);
                SendInventoryUpdate(Index, i);
            }
        } else {
            int itemType = Item_[GetPlayerInvItemNum(Index, i)].Type;

            switch (itemType) {
                case ITEM_TYPE_WEAPON:
                    if (GetPlayerWeaponSlot(Index) > 0) {
                        if (i == GetPlayerWeaponSlot(Index)) {
                            SetPlayerWeaponSlot(Index, 0);
                            SendWornEquipment(Index);
                            doTake = 1;
                        } else {
                            if (ItemNum != GetPlayerInvItemNum(Index, GetPlayerWeaponSlot(Index)))
                                doTake = 1;
                        }
                    } else {
                        doTake = 1;
                    }
                    break;

                case ITEM_TYPE_ARMOR:
                    if (GetPlayerArmorSlot(Index) > 0) {
                        if (i == GetPlayerArmorSlot(Index)) {
                            SetPlayerArmorSlot(Index, 0);
                            SendWornEquipment(Index);
                            doTake = 1;
                        } else {
                            if (ItemNum != GetPlayerInvItemNum(Index, GetPlayerArmorSlot(Index)))
                                doTake = 1;
                        }
                    } else {
                        doTake = 1;
                    }
                    break;

                case ITEM_TYPE_HELMET:
                    if (GetPlayerHelmetSlot(Index) > 0) {
                        if (i == GetPlayerHelmetSlot(Index)) {
                            SetPlayerHelmetSlot(Index, 0);
                            SendWornEquipment(Index);
                            doTake = 1;
                        } else {
                            if (ItemNum != GetPlayerInvItemNum(Index, GetPlayerHelmetSlot(Index)))
                                doTake = 1;
                        }
                    } else {
                        doTake = 1;
                    }
                    break;

                case ITEM_TYPE_SHIELD:
                    if (GetPlayerShieldSlot(Index) > 0) {
                        if (i == GetPlayerShieldSlot(Index)) {
                            SetPlayerShieldSlot(Index, 0);
                            SendWornEquipment(Index);
                            doTake = 1;
                        } else {
                            if (ItemNum != GetPlayerInvItemNum(Index, GetPlayerShieldSlot(Index)))
                                doTake = 1;
                        }
                    } else {
                        doTake = 1;
                    }
                    break;

                default:
                    break;
            }

            /* If not an equipable type, just take it */
            n = Item_[GetPlayerInvItemNum(Index, i)].Type;
            if (n != ITEM_TYPE_WEAPON && n != ITEM_TYPE_ARMOR &&
                n != ITEM_TYPE_HELMET && n != ITEM_TYPE_SHIELD) {
                doTake = 1;
            }
        }

        if (doTake) {
            SetPlayerInvItemNum(Index, i, 0);
            SetPlayerInvItemValue(Index, i, 0);
            SetPlayerInvItemDur(Index, i, 0);
            SendInventoryUpdate(Index, i);
            return;
        }
    }
}

void GiveItem_(int Index, int ItemNum, int ItemVal)
{
    int i;

    if (!IsPlaying(Index) || ItemNum <= 0 || ItemNum > MAX_ITEMS)
        return;

    i = FindOpenInvSlot(Index, ItemNum);

    if (i != 0) {
        SetPlayerInvItemNum(Index, i, ItemNum);
        SetPlayerInvItemValue(Index, i, GetPlayerInvItemValue(Index, i) + ItemVal);

        if (Item_[ItemNum].Type == ITEM_TYPE_ARMOR || Item_[ItemNum].Type == ITEM_TYPE_WEAPON ||
            Item_[ItemNum].Type == ITEM_TYPE_HELMET || Item_[ItemNum].Type == ITEM_TYPE_SHIELD) {
            SetPlayerInvItemDur(Index, i, Item_[ItemNum].Data1);
        }

        SendInventoryUpdate(Index, i);
    } else {
        PlayerMsg(Index, "Your inventory is full.", BrightRed);
    }
}

/* ===================== */
/* Spawning Functions    */
/* ===================== */

void SpawnItem(int ItemNum, int ItemVal, int MapNum, int x, int y)
{
    int i;

    if (ItemNum < 0 || ItemNum > MAX_ITEMS || MapNum <= 0 || MapNum > MAX_MAPS)
        return;

    i = FindOpenMapItemSlot(MapNum);
    SpawnItemSlot(i, ItemNum, ItemVal, Item_[ItemNum].Data1, MapNum, x, y);
}

void SpawnItemSlot(int MapItemSlot, int ItemNum, int ItemVal, int ItemDur, int MapNum, int x, int y)
{
    char pkt[512];
    int pos;
    int i;

    if (MapItemSlot <= 0 || MapItemSlot > MAX_MAP_ITEMS ||
        ItemNum < 0 || ItemNum > MAX_ITEMS ||
        MapNum <= 0 || MapNum > MAX_MAPS)
        return;

    i = MapItemSlot;

    if (i != 0 && ItemNum >= 0 && ItemNum <= MAX_ITEMS) {
        MapItem_[MapNum][i].Num = ItemNum;
        MapItem_[MapNum][i].Value = ItemVal;

        if (ItemNum != 0) {
            if (Item_[ItemNum].Type >= ITEM_TYPE_WEAPON && Item_[ItemNum].Type <= ITEM_TYPE_SHIELD)
                MapItem_[MapNum][i].Dur = ItemDur;
            else
                MapItem_[MapNum][i].Dur = 0;
        } else {
            MapItem_[MapNum][i].Dur = 0;
        }

        MapItem_[MapNum][i].x = x;
        MapItem_[MapNum][i].y = y;

        pos = 0;
        pos = pkt_put(pkt, pos, sizeof(pkt), "SPAWNITEM");
        pos = pkt_putint(pkt, pos, sizeof(pkt), i);
        pos = pkt_putint(pkt, pos, sizeof(pkt), ItemNum);
        pos = pkt_putint(pkt, pos, sizeof(pkt), ItemVal);
        pos = pkt_putint(pkt, pos, sizeof(pkt), MapItem_[MapNum][i].Dur);
        pos = pkt_putint(pkt, pos, sizeof(pkt), x);
        pos = pkt_putint(pkt, pos, sizeof(pkt), y);
        pos = pkt_end(pkt, pos, sizeof(pkt));
        SendDataToMap(MapNum, pkt);
    }
}

void SpawnAllMapsItems(void)
{
    int i;
    for (i = 1; i <= MAX_MAPS; i++)
        SpawnMapItems(i);
}

void SpawnMapItems(int MapNum)
{
    int x, y;

    if (MapNum <= 0 || MapNum > MAX_MAPS)
        return;

    for (y = 0; y <= MAX_MAPY; y++) {
        for (x = 0; x <= MAX_MAPX; x++) {
            if (Map_[MapNum].Tile[x][y].Type == TILE_TYPE_ITEM) {
                int data1 = Map_[MapNum].Tile[x][y].Data1;
                int data2 = Map_[MapNum].Tile[x][y].Data2;

                if (Item_[data1].Type == ITEM_TYPE_CURRENCY && data2 <= 0)
                    SpawnItem(data1, 1, MapNum, x, y);
                else
                    SpawnItem(data1, data2, MapNum, x, y);
            }
        }
    }
}

void PlayerMapGetItem(int Index)
{
    int i, n;
    int MapNum;
    char msg[256];

    if (!IsPlaying(Index))
        return;

    MapNum = GetPlayerMap(Index);

    for (i = 1; i <= MAX_MAP_ITEMS; i++) {
        if (MapItem_[MapNum][i].Num > 0 && MapItem_[MapNum][i].Num <= MAX_ITEMS) {
            if (MapItem_[MapNum][i].x == GetPlayerX(Index) &&
                MapItem_[MapNum][i].y == GetPlayerY(Index)) {

                n = FindOpenInvSlot(Index, MapItem_[MapNum][i].Num);

                if (n != 0) {
                    SetPlayerInvItemNum(Index, n, MapItem_[MapNum][i].Num);

                    if (Item_[GetPlayerInvItemNum(Index, n)].Type == ITEM_TYPE_CURRENCY) {
                        SetPlayerInvItemValue(Index, n,
                            GetPlayerInvItemValue(Index, n) + MapItem_[MapNum][i].Value);
                        snprintf(msg, sizeof(msg), "You picked up %d %s.",
                            MapItem_[MapNum][i].Value,
                            Item_[GetPlayerInvItemNum(Index, n)].Name);
                    } else {
                        SetPlayerInvItemValue(Index, n, 0);
                        snprintf(msg, sizeof(msg), "You picked up a %s.",
                            Item_[GetPlayerInvItemNum(Index, n)].Name);
                    }

                    SetPlayerInvItemDur(Index, n, MapItem_[MapNum][i].Dur);

                    /* Erase item from map */
                    MapItem_[MapNum][i].Num = 0;
                    MapItem_[MapNum][i].Value = 0;
                    MapItem_[MapNum][i].Dur = 0;
                    MapItem_[MapNum][i].x = 0;
                    MapItem_[MapNum][i].y = 0;

                    SendInventoryUpdate(Index, n);
                    SpawnItemSlot(i, 0, 0, 0, GetPlayerMap(Index), GetPlayerX(Index), GetPlayerY(Index));
                    PlayerMsg(Index, msg, Yellow);
                    return;
                } else {
                    PlayerMsg(Index, "Your inventory is full.", BrightRed);
                    return;
                }
            }
        }
    }
}

void PlayerMapDropItem(int Index, int InvNum, int Amount)
{
    int i;
    int MapNum;
    int itemNum;
    int itemType;
    char msg[512];

    if (!IsPlaying(Index) || InvNum <= 0 || InvNum > MAX_INV)
        return;

    itemNum = GetPlayerInvItemNum(Index, InvNum);
    if (itemNum <= 0 || itemNum > MAX_ITEMS)
        return;

    MapNum = GetPlayerMap(Index);
    i = FindOpenMapItemSlot(MapNum);

    if (i != 0) {
        MapItem_[MapNum][i].Dur = 0;
        itemType = Item_[itemNum].Type;

        /* Check equipment slots */
        switch (itemType) {
            case ITEM_TYPE_ARMOR:
                if (InvNum == GetPlayerArmorSlot(Index)) {
                    SetPlayerArmorSlot(Index, 0);
                    SendWornEquipment(Index);
                }
                MapItem_[MapNum][i].Dur = GetPlayerInvItemDur(Index, InvNum);
                break;

            case ITEM_TYPE_WEAPON:
                if (InvNum == GetPlayerWeaponSlot(Index)) {
                    SetPlayerWeaponSlot(Index, 0);
                    SendWornEquipment(Index);
                }
                MapItem_[MapNum][i].Dur = GetPlayerInvItemDur(Index, InvNum);
                break;

            case ITEM_TYPE_HELMET:
                if (InvNum == GetPlayerHelmetSlot(Index)) {
                    SetPlayerHelmetSlot(Index, 0);
                    SendWornEquipment(Index);
                }
                MapItem_[MapNum][i].Dur = GetPlayerInvItemDur(Index, InvNum);
                break;

            case ITEM_TYPE_SHIELD:
                if (InvNum == GetPlayerShieldSlot(Index)) {
                    SetPlayerShieldSlot(Index, 0);
                    SendWornEquipment(Index);
                }
                MapItem_[MapNum][i].Dur = GetPlayerInvItemDur(Index, InvNum);
                break;
        }

        MapItem_[MapNum][i].Num = itemNum;
        MapItem_[MapNum][i].x = GetPlayerX(Index);
        MapItem_[MapNum][i].y = GetPlayerY(Index);

        if (Item_[itemNum].Type == ITEM_TYPE_CURRENCY) {
            if (Amount >= GetPlayerInvItemValue(Index, InvNum)) {
                MapItem_[MapNum][i].Value = GetPlayerInvItemValue(Index, InvNum);
                snprintf(msg, sizeof(msg), "%s drops %d %s.",
                    GetPlayerName(Index), GetPlayerInvItemValue(Index, InvNum), Item_[itemNum].Name);
                MapMsg(MapNum, msg, Yellow);
                SetPlayerInvItemNum(Index, InvNum, 0);
                SetPlayerInvItemValue(Index, InvNum, 0);
                SetPlayerInvItemDur(Index, InvNum, 0);
            } else {
                MapItem_[MapNum][i].Value = Amount;
                snprintf(msg, sizeof(msg), "%s drops %d %s.",
                    GetPlayerName(Index), Amount, Item_[itemNum].Name);
                MapMsg(MapNum, msg, Yellow);
                SetPlayerInvItemValue(Index, InvNum, GetPlayerInvItemValue(Index, InvNum) - Amount);
            }
        } else {
            MapItem_[MapNum][i].Value = 0;
            if (Item_[itemNum].Type >= ITEM_TYPE_WEAPON && Item_[itemNum].Type <= ITEM_TYPE_SHIELD) {
                snprintf(msg, sizeof(msg), "%s drops a %s %d/%d.",
                    GetPlayerName(Index), Item_[itemNum].Name,
                    GetPlayerInvItemDur(Index, InvNum), Item_[itemNum].Data1);
            } else {
                snprintf(msg, sizeof(msg), "%s drops a %s.",
                    GetPlayerName(Index), Item_[itemNum].Name);
            }
            MapMsg(MapNum, msg, Yellow);

            SetPlayerInvItemNum(Index, InvNum, 0);
            SetPlayerInvItemValue(Index, InvNum, 0);
            SetPlayerInvItemDur(Index, InvNum, 0);
        }

        SendInventoryUpdate(Index, InvNum);
        SpawnItemSlot(i, MapItem_[MapNum][i].Num, Amount, MapItem_[MapNum][i].Dur,
                      MapNum, GetPlayerX(Index), GetPlayerY(Index));
    } else {
        PlayerMsg(Index, "To many items already on the ground.", BrightRed);
    }
}

void SpawnNpc_(int MapNpcNum, int MapNum)
{
    int NpcNum;
    int i, x, y;
    int Spawned = 0;
    char pkt[512];
    int pos;

    if (MapNpcNum <= 0 || MapNpcNum > MAX_MAP_NPCS || MapNum <= 0 || MapNum > MAX_MAPS)
        return;

    NpcNum = Map_[MapNum].Npc[MapNpcNum];
    if (NpcNum > 0) {
        MapNpc_[MapNum][MapNpcNum].Num = NpcNum;
        MapNpc_[MapNum][MapNpcNum].Target = 0;
        MapNpc_[MapNum][MapNpcNum].HP = GetNpcMaxHP(NpcNum);
        MapNpc_[MapNum][MapNpcNum].MP = GetNpcMaxMP(NpcNum);
        MapNpc_[MapNum][MapNpcNum].SP = GetNpcMaxSP(NpcNum);
        MapNpc_[MapNum][MapNpcNum].Dir = rand() % 4;

        /* Try 100 times to randomly place */
        for (i = 1; i <= 100; i++) {
            x = rand() % MAX_MAPX;
            y = rand() % MAX_MAPY;

            if (Map_[MapNum].Tile[x][y].Type == TILE_TYPE_WALKABLE) {
                MapNpc_[MapNum][MapNpcNum].x = x;
                MapNpc_[MapNum][MapNpcNum].y = y;
                Spawned = 1;
                break;
            }
        }

        /* Fallback: find first walkable tile */
        if (!Spawned) {
            for (y = 0; y <= MAX_MAPY; y++) {
                for (x = 0; x <= MAX_MAPX; x++) {
                    if (Map_[MapNum].Tile[x][y].Type == TILE_TYPE_WALKABLE) {
                        MapNpc_[MapNum][MapNpcNum].x = x;
                        MapNpc_[MapNum][MapNpcNum].y = y;
                        Spawned = 1;
                    }
                }
            }
        }

        if (Spawned) {
            pos = 0;
            pos = pkt_put(pkt, pos, sizeof(pkt), "SPAWNNPC");
            pos = pkt_putint(pkt, pos, sizeof(pkt), MapNpcNum);
            pos = pkt_putint(pkt, pos, sizeof(pkt), MapNpc_[MapNum][MapNpcNum].Num);
            pos = pkt_putint(pkt, pos, sizeof(pkt), MapNpc_[MapNum][MapNpcNum].x);
            pos = pkt_putint(pkt, pos, sizeof(pkt), MapNpc_[MapNum][MapNpcNum].y);
            pos = pkt_putint(pkt, pos, sizeof(pkt), MapNpc_[MapNum][MapNpcNum].Dir);
            pos = pkt_end(pkt, pos, sizeof(pkt));
            SendDataToMap(MapNum, pkt);
        }
    }
}

void SpawnMapNpcs(int MapNum)
{
    int i;
    for (i = 1; i <= MAX_MAP_NPCS; i++)
        SpawnNpc_(i, MapNum);
}

void SpawnAllMapNpcs(void)
{
    int i;
    for (i = 1; i <= MAX_MAPS; i++)
        SpawnMapNpcs(i);
}

/* ===================== */
/* Movement Functions    */
/* ===================== */

void PlayerWarp(int Index, int MapNum, int x, int y)
{
    int ShopNum, OldMap;
    char pkt[512];
    int pos;

    if (!IsPlaying(Index) || MapNum <= 0 || MapNum > MAX_MAPS)
        return;

    /* Say goodbye from old shop */
    ShopNum = Map_[GetPlayerMap(Index)].Shop;
    if (ShopNum > 0) {
        if (strlen(Shop_[ShopNum].LeaveSay) > 0) {
            char msg[512];
            snprintf(msg, sizeof(msg), "%s says, '%s'", Shop_[ShopNum].Name, Shop_[ShopNum].LeaveSay);
            PlayerMsg(Index, msg, SayColor);
        }
    }

    /* Save old map and send leave */
    OldMap = GetPlayerMap(Index);
    SendLeaveMap(Index, OldMap);

    SetPlayerMap(Index, MapNum);
    SetPlayerX(Index, x);
    SetPlayerY(Index, y);

    /* Say hello from new shop */
    ShopNum = Map_[GetPlayerMap(Index)].Shop;
    if (ShopNum > 0) {
        if (strlen(Shop_[ShopNum].JoinSay) > 0) {
            char msg[512];
            snprintf(msg, sizeof(msg), "%s says, '%s'", Shop_[ShopNum].Name, Shop_[ShopNum].JoinSay);
            PlayerMsg(Index, msg, SayColor);
        }
    }

    /* Update PlayersOnMap tracking */
    if (GetTotalMapPlayers(OldMap) == 0)
        PlayersOnMap[OldMap] = NO;

    PlayersOnMap[MapNum] = YES;

    Player[Index].GettingMap = YES;

    pos = 0;
    pos = pkt_put(pkt, pos, sizeof(pkt), "CHECKFORMAP");
    pos = pkt_putint(pkt, pos, sizeof(pkt), MapNum);
    pos = pkt_putint(pkt, pos, sizeof(pkt), Map_[MapNum].Revision);
    pos = pkt_end(pkt, pos, sizeof(pkt));
    SendDataTo(Index, pkt);
}

void PlayerMove(int Index, int Dir, int Movement)
{
    int MapNum;
    int px, py;
    int nx, ny;
    int Moved = NO;
    int tileType;
    char pkt[512];
    int pos;

    if (!IsPlaying(Index) || Dir < DIR_UP || Dir > DIR_RIGHT || Movement < 1 || Movement > 2)
        return;

    SetPlayerDir(Index, Dir);

    MapNum = GetPlayerMap(Index);
    px = GetPlayerX(Index);
    py = GetPlayerY(Index);

    switch (Dir) {
        case DIR_UP:
            if (py > 0) {
                tileType = Map_[MapNum].Tile[px][py - 1].Type;
                if (tileType != TILE_TYPE_BLOCKED) {
                    if (tileType != TILE_TYPE_KEY ||
                        (tileType == TILE_TYPE_KEY && TempTile[MapNum].DoorOpen[px][py - 1] == YES)) {
                        SetPlayerY(Index, py - 1);

                        pos = 0;
                        pos = pkt_put(pkt, pos, sizeof(pkt), "PLAYERMOVE");
                        pos = pkt_putint(pkt, pos, sizeof(pkt), Index);
                        pos = pkt_putint(pkt, pos, sizeof(pkt), GetPlayerX(Index));
                        pos = pkt_putint(pkt, pos, sizeof(pkt), GetPlayerY(Index));
                        pos = pkt_putint(pkt, pos, sizeof(pkt), GetPlayerDir(Index));
                        pos = pkt_putint(pkt, pos, sizeof(pkt), Movement);
                        pos = pkt_end(pkt, pos, sizeof(pkt));
                        SendDataToMapBut(Index, MapNum, pkt);
                        Moved = YES;
                    }
                }
            } else {
                if (Map_[MapNum].Up > 0) {
                    PlayerWarp(Index, Map_[MapNum].Up, GetPlayerX(Index), MAX_MAPY);
                    Moved = YES;
                }
            }
            break;

        case DIR_DOWN:
            if (py < MAX_MAPY) {
                tileType = Map_[MapNum].Tile[px][py + 1].Type;
                if (tileType != TILE_TYPE_BLOCKED) {
                    if (tileType != TILE_TYPE_KEY ||
                        (tileType == TILE_TYPE_KEY && TempTile[MapNum].DoorOpen[px][py + 1] == YES)) {
                        SetPlayerY(Index, py + 1);

                        pos = 0;
                        pos = pkt_put(pkt, pos, sizeof(pkt), "PLAYERMOVE");
                        pos = pkt_putint(pkt, pos, sizeof(pkt), Index);
                        pos = pkt_putint(pkt, pos, sizeof(pkt), GetPlayerX(Index));
                        pos = pkt_putint(pkt, pos, sizeof(pkt), GetPlayerY(Index));
                        pos = pkt_putint(pkt, pos, sizeof(pkt), GetPlayerDir(Index));
                        pos = pkt_putint(pkt, pos, sizeof(pkt), Movement);
                        pos = pkt_end(pkt, pos, sizeof(pkt));
                        SendDataToMapBut(Index, MapNum, pkt);
                        Moved = YES;
                    }
                }
            } else {
                if (Map_[MapNum].Down > 0) {
                    PlayerWarp(Index, Map_[MapNum].Down, GetPlayerX(Index), 0);
                    Moved = YES;
                }
            }
            break;

        case DIR_LEFT:
            if (px > 0) {
                tileType = Map_[MapNum].Tile[px - 1][py].Type;
                if (tileType != TILE_TYPE_BLOCKED) {
                    if (tileType != TILE_TYPE_KEY ||
                        (tileType == TILE_TYPE_KEY && TempTile[MapNum].DoorOpen[px - 1][py] == YES)) {
                        SetPlayerX(Index, px - 1);

                        pos = 0;
                        pos = pkt_put(pkt, pos, sizeof(pkt), "PLAYERMOVE");
                        pos = pkt_putint(pkt, pos, sizeof(pkt), Index);
                        pos = pkt_putint(pkt, pos, sizeof(pkt), GetPlayerX(Index));
                        pos = pkt_putint(pkt, pos, sizeof(pkt), GetPlayerY(Index));
                        pos = pkt_putint(pkt, pos, sizeof(pkt), GetPlayerDir(Index));
                        pos = pkt_putint(pkt, pos, sizeof(pkt), Movement);
                        pos = pkt_end(pkt, pos, sizeof(pkt));
                        SendDataToMapBut(Index, MapNum, pkt);
                        Moved = YES;
                    }
                }
            } else {
                if (Map_[MapNum].Left > 0) {
                    PlayerWarp(Index, Map_[MapNum].Left, MAX_MAPX, GetPlayerY(Index));
                    Moved = YES;
                }
            }
            break;

        case DIR_RIGHT:
            if (px < MAX_MAPX) {
                tileType = Map_[MapNum].Tile[px + 1][py].Type;
                if (tileType != TILE_TYPE_BLOCKED) {
                    if (tileType != TILE_TYPE_KEY ||
                        (tileType == TILE_TYPE_KEY && TempTile[MapNum].DoorOpen[px + 1][py] == YES)) {
                        SetPlayerX(Index, px + 1);

                        pos = 0;
                        pos = pkt_put(pkt, pos, sizeof(pkt), "PLAYERMOVE");
                        pos = pkt_putint(pkt, pos, sizeof(pkt), Index);
                        pos = pkt_putint(pkt, pos, sizeof(pkt), GetPlayerX(Index));
                        pos = pkt_putint(pkt, pos, sizeof(pkt), GetPlayerY(Index));
                        pos = pkt_putint(pkt, pos, sizeof(pkt), GetPlayerDir(Index));
                        pos = pkt_putint(pkt, pos, sizeof(pkt), Movement);
                        pos = pkt_end(pkt, pos, sizeof(pkt));
                        SendDataToMapBut(Index, MapNum, pkt);
                        Moved = YES;
                    }
                }
            } else {
                if (Map_[MapNum].Right > 0) {
                    PlayerWarp(Index, Map_[MapNum].Right, 0, GetPlayerY(Index));
                    Moved = YES;
                }
            }
            break;
    }

    /* Re-read position after potential warp */
    MapNum = GetPlayerMap(Index);
    px = GetPlayerX(Index);
    py = GetPlayerY(Index);

    /* Check for warp tile */
    if (Map_[MapNum].Tile[px][py].Type == TILE_TYPE_WARP) {
        int wMapNum = Map_[MapNum].Tile[px][py].Data1;
        int wx = Map_[MapNum].Tile[px][py].Data2;
        int wy = Map_[MapNum].Tile[px][py].Data3;
        PlayerWarp(Index, wMapNum, wx, wy);
        Moved = YES;
    }

    /* Check for key trigger open */
    if (Map_[MapNum].Tile[px][py].Type == TILE_TYPE_KEYOPEN) {
        int kx = Map_[MapNum].Tile[px][py].Data1;
        int ky = Map_[MapNum].Tile[px][py].Data2;

        if (Map_[MapNum].Tile[kx][ky].Type == TILE_TYPE_KEY &&
            TempTile[MapNum].DoorOpen[kx][ky] == NO) {
            TempTile[MapNum].DoorOpen[kx][ky] = YES;
            TempTile[MapNum].DoorTimer = GetTickCount();

            pos = 0;
            pos = pkt_put(pkt, pos, sizeof(pkt), "MAPKEY");
            pos = pkt_putint(pkt, pos, sizeof(pkt), kx);
            pos = pkt_putint(pkt, pos, sizeof(pkt), ky);
            pos = pkt_putint(pkt, pos, sizeof(pkt), 1);
            pos = pkt_end(pkt, pos, sizeof(pkt));
            SendDataToMap(MapNum, pkt);
            MapMsg(MapNum, "A door has been unlocked.", White);
        }
    }

    /* If they didn't move, it's a hack attempt */
    if (Moved == NO) {
        HackingAttempt(Index, "Position Modification");
    }
}

int CanNpcMove(int MapNum, int MapNpcNum, int Dir)
{
    int i, n;
    int x, y;

    if (MapNum <= 0 || MapNum > MAX_MAPS || MapNpcNum <= 0 || MapNpcNum > MAX_MAP_NPCS ||
        Dir < DIR_UP || Dir > DIR_RIGHT)
        return 0;

    x = MapNpc_[MapNum][MapNpcNum].x;
    y = MapNpc_[MapNum][MapNpcNum].y;

    switch (Dir) {
        case DIR_UP:
            if (y > 0) {
                n = Map_[MapNum].Tile[x][y - 1].Type;
                if (n != TILE_TYPE_WALKABLE && n != TILE_TYPE_ITEM)
                    return 0;

                for (i = 1; i <= MAX_PLAYERS; i++) {
                    if (IsPlaying(i) && GetPlayerMap(i) == MapNum &&
                        GetPlayerX(i) == x && GetPlayerY(i) == y - 1)
                        return 0;
                }

                for (i = 1; i <= MAX_MAP_NPCS; i++) {
                    if (i != MapNpcNum && MapNpc_[MapNum][i].Num > 0 &&
                        MapNpc_[MapNum][i].x == x && MapNpc_[MapNum][i].y == y - 1)
                        return 0;
                }
            } else {
                return 0;
            }
            break;

        case DIR_DOWN:
            if (y < MAX_MAPY) {
                n = Map_[MapNum].Tile[x][y + 1].Type;
                if (n != TILE_TYPE_WALKABLE && n != TILE_TYPE_ITEM)
                    return 0;

                for (i = 1; i <= MAX_PLAYERS; i++) {
                    if (IsPlaying(i) && GetPlayerMap(i) == MapNum &&
                        GetPlayerX(i) == x && GetPlayerY(i) == y + 1)
                        return 0;
                }

                for (i = 1; i <= MAX_MAP_NPCS; i++) {
                    if (i != MapNpcNum && MapNpc_[MapNum][i].Num > 0 &&
                        MapNpc_[MapNum][i].x == x && MapNpc_[MapNum][i].y == y + 1)
                        return 0;
                }
            } else {
                return 0;
            }
            break;

        case DIR_LEFT:
            if (x > 0) {
                n = Map_[MapNum].Tile[x - 1][y].Type;
                if (n != TILE_TYPE_WALKABLE && n != TILE_TYPE_ITEM)
                    return 0;

                for (i = 1; i <= MAX_PLAYERS; i++) {
                    if (IsPlaying(i) && GetPlayerMap(i) == MapNum &&
                        GetPlayerX(i) == x - 1 && GetPlayerY(i) == y)
                        return 0;
                }

                for (i = 1; i <= MAX_MAP_NPCS; i++) {
                    if (i != MapNpcNum && MapNpc_[MapNum][i].Num > 0 &&
                        MapNpc_[MapNum][i].x == x - 1 && MapNpc_[MapNum][i].y == y)
                        return 0;
                }
            } else {
                return 0;
            }
            break;

        case DIR_RIGHT:
            if (x < MAX_MAPX) {
                n = Map_[MapNum].Tile[x + 1][y].Type;
                if (n != TILE_TYPE_WALKABLE && n != TILE_TYPE_ITEM)
                    return 0;

                for (i = 1; i <= MAX_PLAYERS; i++) {
                    if (IsPlaying(i) && GetPlayerMap(i) == MapNum &&
                        GetPlayerX(i) == x + 1 && GetPlayerY(i) == y)
                        return 0;
                }

                for (i = 1; i <= MAX_MAP_NPCS; i++) {
                    if (i != MapNpcNum && MapNpc_[MapNum][i].Num > 0 &&
                        MapNpc_[MapNum][i].x == x + 1 && MapNpc_[MapNum][i].y == y)
                        return 0;
                }
            } else {
                return 0;
            }
            break;
    }

    return 1;
}

void NpcMove(int MapNum, int MapNpcNum, int Dir, int Movement)
{
    char pkt[512];
    int pos;

    if (MapNum <= 0 || MapNum > MAX_MAPS || MapNpcNum <= 0 || MapNpcNum > MAX_MAP_NPCS ||
        Dir < DIR_UP || Dir > DIR_RIGHT || Movement < 1 || Movement > 2)
        return;

    MapNpc_[MapNum][MapNpcNum].Dir = Dir;

    switch (Dir) {
        case DIR_UP:
            MapNpc_[MapNum][MapNpcNum].y--;
            break;
        case DIR_DOWN:
            MapNpc_[MapNum][MapNpcNum].y++;
            break;
        case DIR_LEFT:
            MapNpc_[MapNum][MapNpcNum].x--;
            break;
        case DIR_RIGHT:
            MapNpc_[MapNum][MapNpcNum].x++;
            break;
    }

    pos = 0;
    pos = pkt_put(pkt, pos, sizeof(pkt), "NPCMOVE");
    pos = pkt_putint(pkt, pos, sizeof(pkt), MapNpcNum);
    pos = pkt_putint(pkt, pos, sizeof(pkt), MapNpc_[MapNum][MapNpcNum].x);
    pos = pkt_putint(pkt, pos, sizeof(pkt), MapNpc_[MapNum][MapNpcNum].y);
    pos = pkt_putint(pkt, pos, sizeof(pkt), MapNpc_[MapNum][MapNpcNum].Dir);
    pos = pkt_putint(pkt, pos, sizeof(pkt), Movement);
    pos = pkt_end(pkt, pos, sizeof(pkt));
    SendDataToMap(MapNum, pkt);
}

void NpcDir(int MapNum, int MapNpcNum, int Dir)
{
    char pkt[512];
    int pos;

    if (MapNum <= 0 || MapNum > MAX_MAPS || MapNpcNum <= 0 || MapNpcNum > MAX_MAP_NPCS ||
        Dir < DIR_UP || Dir > DIR_RIGHT)
        return;

    MapNpc_[MapNum][MapNpcNum].Dir = Dir;

    pos = 0;
    pos = pkt_put(pkt, pos, sizeof(pkt), "NPCDIR");
    pos = pkt_putint(pkt, pos, sizeof(pkt), MapNpcNum);
    pos = pkt_putint(pkt, pos, sizeof(pkt), Dir);
    pos = pkt_end(pkt, pos, sizeof(pkt));
    SendDataToMap(MapNum, pkt);
}

/* ===================== */
/* Game Flow Functions   */
/* ===================== */

void JoinGame(int Index)
{
    char pkt[512];
    int pos;
    char msg[256];

    /* Set in-game flag */
    Player[Index].InGame = 1;

    /* Send global join message */
    snprintf(msg, sizeof(msg), "%s has joined %s!", GetPlayerName(Index), GAME_NAME);
    if (GetPlayerAccess(Index) <= ADMIN_MONITER)
        GlobalMsg(msg, JoinLeftColor);
    else
        GlobalMsg(msg, White);

    /* Send login OK */
    pos = 0;
    pos = pkt_put(pkt, pos, sizeof(pkt), "LOGINOK");
    pos = pkt_putint(pkt, pos, sizeof(pkt), Index);
    pos = pkt_end(pkt, pos, sizeof(pkt));
    SendDataTo(Index, pkt);

    /* Send all game data */
    CheckEquippedItems(Index);
    SendClasses(Index);
    SendItems(Index);
    SendNpcs(Index);
    SendShops_(Index);
    SendSpells_(Index);
    SendInventory(Index);
    SendWornEquipment(Index);
    SendHP(Index);
    SendMP(Index);
    SendSP(Index);
    SendStats(Index);
    SendWeatherTo(Index);
    SendTimeTo(Index);

    /* Warp player to saved location */
    PlayerWarp(Index, GetPlayerMap(Index), GetPlayerX(Index), GetPlayerY(Index));

    /* Send welcome messages */
    SendWelcome(Index);

    /* Send in-game flag */
    pos = 0;
    pos = pkt_put(pkt, pos, sizeof(pkt), "INGAME");
    pos = pkt_end(pkt, pos, sizeof(pkt));
    SendDataTo(Index, pkt);
}

void LeftGame(int Index)
{
    int n;
    char msg[256];

    if (Player[Index].InGame) {
        Player[Index].InGame = 0;

        /* Check if player was only one on map */
        if (GetTotalMapPlayers(GetPlayerMap(Index)) == 1)
            PlayersOnMap[GetPlayerMap(Index)] = NO;

        /* Check for boot map */
        if (Map_[GetPlayerMap(Index)].BootMap > 0) {
            SetPlayerX(Index, Map_[GetPlayerMap(Index)].BootX);
            SetPlayerY(Index, Map_[GetPlayerMap(Index)].BootY);
            SetPlayerMap(Index, Map_[GetPlayerMap(Index)].BootMap);
        }

        /* Handle party cleanup */
        if (Player[Index].InParty == YES) {
            n = Player[Index].PartyPlayer;
            snprintf(msg, sizeof(msg), "%s has left %s, disbanning party.", GetPlayerName(Index), GAME_NAME);
            PlayerMsg(n, msg, Pink);
            Player[n].InParty = NO;
            Player[n].PartyPlayer = 0;
        }

        SavePlayer(Index);

        /* Send global leave message */
        snprintf(msg, sizeof(msg), "%s has left %s!", GetPlayerName(Index), GAME_NAME);
        if (GetPlayerAccess(Index) <= ADMIN_MONITER)
            GlobalMsg(msg, JoinLeftColor);
        else
            GlobalMsg(msg, White);

        snprintf(msg, sizeof(msg), "%s has disconnected from %s.", GetPlayerName(Index), GAME_NAME);
        text_add(msg);

        SendLeftGame(Index);
    }

    ClearPlayer(Index);
}

int GetTotalMapPlayers(int MapNum)
{
    int i, n = 0;

    for (i = 1; i <= MAX_PLAYERS; i++) {
        if (IsPlaying(i) && GetPlayerMap(i) == MapNum)
            n++;
    }

    return n;
}

/* ======================= */
/* Stat / Regen Functions  */
/* ======================= */

int GetNpcMaxHP(int NpcNum)
{
    if (NpcNum <= 0 || NpcNum > MAX_NPCS)
        return 0;
    return Npc_[NpcNum].STR * Npc_[NpcNum].DEF;
}

int GetNpcMaxMP(int NpcNum)
{
    if (NpcNum <= 0 || NpcNum > MAX_NPCS)
        return 0;
    return Npc_[NpcNum].MAGI * 2;
}

int GetNpcMaxSP(int NpcNum)
{
    if (NpcNum <= 0 || NpcNum > MAX_NPCS)
        return 0;
    return Npc_[NpcNum].SPEED * 2;
}

int GetPlayerHPRegen(int Index)
{
    int i;

    if (!IsPlaying(Index) || Index <= 0 || Index > MAX_PLAYERS)
        return 0;

    i = GetPlayerDEF(Index) / 2;
    if (i < 2) i = 2;
    return i;
}

int GetPlayerMPRegen(int Index)
{
    int i;

    if (!IsPlaying(Index) || Index <= 0 || Index > MAX_PLAYERS)
        return 0;

    i = GetPlayerMAGI(Index) / 2;
    if (i < 2) i = 2;
    return i;
}

int GetPlayerSPRegen(int Index)
{
    int i;

    if (!IsPlaying(Index) || Index <= 0 || Index > MAX_PLAYERS)
        return 0;

    i = GetPlayerSPEED(Index) / 2;
    if (i < 2) i = 2;
    return i;
}

int GetNpcHPRegen(int NpcNum)
{
    int i;

    if (NpcNum <= 0 || NpcNum > MAX_NPCS)
        return 0;

    i = Npc_[NpcNum].DEF / 3;
    if (i < 1) i = 1;
    return i;
}

void CheckPlayerLevelUp(int Index)
{
    int i;

    if (GetPlayerExp(Index) >= GetPlayerNextLevel(Index)) {
        SetPlayerLevel(Index, GetPlayerLevel(Index) + 1);

        i = GetPlayerSPEED(Index) / 10;
        if (i < 1) i = 1;
        if (i > 3) i = 3;

        SetPlayerPOINTS(Index, GetPlayerPOINTS(Index) + i);
        SetPlayerExp(Index, 0);

        {
            char msg[256];
            snprintf(msg, sizeof(msg), "%s has gained a level!", GetPlayerName(Index));
            GlobalMsg(msg, Brown);
            snprintf(msg, sizeof(msg), "You have gained a level!  You now have %d stat points to distribute.", GetPlayerPOINTS(Index));
            PlayerMsg(Index, msg, BrightBlue);
        }
    }
}

void CastSpell_(int Index, int SpellSlot)
{
    int SpellNum, MPReq, i, n, Damage;
    int Casted = 0;
    int MapNum;
    char msg[512];

    if (SpellSlot <= 0 || SpellSlot > MAX_PLAYER_SPELLS)
        return;

    SpellNum = GetPlayerSpell_(Index, SpellSlot);

    if (!HasSpell(Index, SpellNum)) {
        PlayerMsg(Index, "You do not have this spell!", BrightRed);
        return;
    }

    i = GetSpellReqLevel(Index, SpellNum);
    MPReq = i + Spell_[SpellNum].Data1 + Spell_[SpellNum].Data2 + Spell_[SpellNum].Data3;

    if (GetPlayerMP(Index) < MPReq) {
        PlayerMsg(Index, "Not enough mana points!", BrightRed);
        return;
    }

    if (i > GetPlayerLevel(Index)) {
        snprintf(msg, sizeof(msg), "You must be level %d to cast this spell.", i);
        PlayerMsg(Index, msg, BrightRed);
        return;
    }

    if (GetTickCount() < Player[Index].AttackTimer + 1000)
        return;

    MapNum = GetPlayerMap(Index);

    /* Give item spell type */
    if (Spell_[SpellNum].Type == SPELL_TYPE_GIVEITEM) {
        n = FindOpenInvSlot(Index, Spell_[SpellNum].Data1);

        if (n > 0) {
            GiveItem_(Index, Spell_[SpellNum].Data1, Spell_[SpellNum].Data2);
            snprintf(msg, sizeof(msg), "%s casts %s.", GetPlayerName(Index), Spell_[SpellNum].Name);
            MapMsg(MapNum, msg, BrightBlue);

            SetPlayerMP(Index, GetPlayerMP(Index) - MPReq);
            SendMP(Index);
            Casted = 1;
        } else {
            PlayerMsg(Index, "Your inventory is full!", BrightRed);
        }

        goto cast_done;
    }

    n = Player[Index].Target;

    if (Player[Index].TargetType == TARGET_TYPE_PLAYER) {
        if (IsPlaying(n)) {
            if (GetPlayerHP(n) > 0 && GetPlayerMap(Index) == GetPlayerMap(n) &&
                GetPlayerLevel(Index) >= 10 && GetPlayerLevel(n) >= 10 &&
                Map_[MapNum].Moral == MAP_MORAL_NONE &&
                GetPlayerAccess(Index) <= 0 && GetPlayerAccess(n) <= 0) {

                snprintf(msg, sizeof(msg), "%s casts %s on %s.", GetPlayerName(Index), Spell_[SpellNum].Name, GetPlayerName(n));
                MapMsg(MapNum, msg, BrightBlue);

                switch (Spell_[SpellNum].Type) {
                    case SPELL_TYPE_SUBHP:
                        Damage = (GetPlayerMAGI(Index) / 4 + Spell_[SpellNum].Data1) - GetPlayerProtection(n);
                        if (Damage > 0) {
                            AttackPlayer(Index, n, Damage);
                        } else {
                            snprintf(msg, sizeof(msg), "The spell was to weak to hurt %s!", GetPlayerName(n));
                            PlayerMsg(Index, msg, BrightRed);
                        }
                        break;

                    case SPELL_TYPE_SUBMP:
                        SetPlayerMP(n, GetPlayerMP(n) - Spell_[SpellNum].Data1);
                        SendMP(n);
                        break;

                    case SPELL_TYPE_SUBSP:
                        SetPlayerSP(n, GetPlayerSP(n) - Spell_[SpellNum].Data1);
                        SendSP(n);
                        break;
                }

                SetPlayerMP(Index, GetPlayerMP(Index) - MPReq);
                SendMP(Index);
                Casted = 1;
            } else {
                /* Check for healing spells on same map */
                if (GetPlayerMap(Index) == GetPlayerMap(n) &&
                    Spell_[SpellNum].Type >= SPELL_TYPE_ADDHP &&
                    Spell_[SpellNum].Type <= SPELL_TYPE_ADDSP) {

                    switch (Spell_[SpellNum].Type) {
                        case SPELL_TYPE_ADDHP:
                            snprintf(msg, sizeof(msg), "%s casts %s on %s.", GetPlayerName(Index), Spell_[SpellNum].Name, GetPlayerName(n));
                            MapMsg(MapNum, msg, BrightBlue);
                            SetPlayerHP(n, GetPlayerHP(n) + Spell_[SpellNum].Data1);
                            SendHP(n);
                            break;

                        case SPELL_TYPE_ADDMP:
                            snprintf(msg, sizeof(msg), "%s casts %s on %s.", GetPlayerName(Index), Spell_[SpellNum].Name, GetPlayerName(n));
                            MapMsg(MapNum, msg, BrightBlue);
                            SetPlayerMP(n, GetPlayerMP(n) + Spell_[SpellNum].Data1);
                            SendMP(n);
                            break;

                        case SPELL_TYPE_ADDSP:
                            snprintf(msg, sizeof(msg), "%s casts %s on %s.", GetPlayerName(Index), Spell_[SpellNum].Name, GetPlayerName(n));
                            MapMsg(MapNum, msg, BrightBlue);
                            /* Note: VB6 original had a bug here (SetPlayerMP instead of SetPlayerSP) - preserving it */
                            SetPlayerMP(n, GetPlayerSP(n) + Spell_[SpellNum].Data1);
                            SendMP(n);
                            break;
                    }

                    SetPlayerMP(Index, GetPlayerMP(Index) - MPReq);
                    SendMP(Index);
                    Casted = 1;
                } else {
                    PlayerMsg(Index, "Could not cast spell!", BrightRed);
                }
            }
        } else {
            PlayerMsg(Index, "Could not cast spell!", BrightRed);
        }
    } else {
        /* Target is NPC */
        if (n > 0 && n <= MAX_MAP_NPCS && MapNpc_[MapNum][n].Num > 0) {
            int npcNum = MapNpc_[MapNum][n].Num;

            if (Npc_[npcNum].Behavior != NPC_BEHAVIOR_FRIENDLY &&
                Npc_[npcNum].Behavior != NPC_BEHAVIOR_SHOPKEEPER) {

                snprintf(msg, sizeof(msg), "%s casts %s on a %s.", GetPlayerName(Index), Spell_[SpellNum].Name, Npc_[npcNum].Name);
                MapMsg(MapNum, msg, BrightBlue);

                switch (Spell_[SpellNum].Type) {
                    case SPELL_TYPE_ADDHP:
                        MapNpc_[MapNum][n].HP += Spell_[SpellNum].Data1;
                        break;

                    case SPELL_TYPE_SUBHP:
                        Damage = (GetPlayerMAGI(Index) / 4 + Spell_[SpellNum].Data1) - (Npc_[npcNum].DEF / 2);
                        if (Damage > 0) {
                            AttackNpc(Index, n, Damage);
                        } else {
                            snprintf(msg, sizeof(msg), "The spell was to weak to hurt %s!", Npc_[npcNum].Name);
                            PlayerMsg(Index, msg, BrightRed);
                        }
                        break;

                    case SPELL_TYPE_ADDMP:
                        MapNpc_[MapNum][n].MP += Spell_[SpellNum].Data1;
                        break;

                    case SPELL_TYPE_SUBMP:
                        MapNpc_[MapNum][n].MP -= Spell_[SpellNum].Data1;
                        break;

                    case SPELL_TYPE_ADDSP:
                        MapNpc_[MapNum][n].SP += Spell_[SpellNum].Data1;
                        break;

                    case SPELL_TYPE_SUBSP:
                        MapNpc_[MapNum][n].SP -= Spell_[SpellNum].Data1;
                        break;
                }

                SetPlayerMP(Index, GetPlayerMP(Index) - MPReq);
                SendMP(Index);
                Casted = 1;
            } else {
                PlayerMsg(Index, "Could not cast spell!", BrightRed);
            }
        } else {
            PlayerMsg(Index, "Could not cast spell!", BrightRed);
        }
    }

cast_done:
    if (Casted) {
        Player[Index].AttackTimer = GetTickCount();
        Player[Index].CastedSpell = YES;
    }
}

int GetSpellReqLevel(int Index, int SpellNum)
{
    return Spell_[SpellNum].Data1 - (GetClassMAGI(GetPlayerClass(Index)) / 4);
}

void CheckEquippedItems(int Index)
{
    int Slot, ItemNum;

    /* Weapon */
    Slot = GetPlayerWeaponSlot(Index);
    if (Slot > 0) {
        ItemNum = GetPlayerInvItemNum(Index, Slot);
        if (ItemNum > 0) {
            if (Item_[ItemNum].Type != ITEM_TYPE_WEAPON)
                SetPlayerWeaponSlot(Index, 0);
        } else {
            SetPlayerWeaponSlot(Index, 0);
        }
    }

    /* Armor */
    Slot = GetPlayerArmorSlot(Index);
    if (Slot > 0) {
        ItemNum = GetPlayerInvItemNum(Index, Slot);
        if (ItemNum > 0) {
            if (Item_[ItemNum].Type != ITEM_TYPE_ARMOR)
                SetPlayerArmorSlot(Index, 0);
        } else {
            SetPlayerArmorSlot(Index, 0);
        }
    }

    /* Helmet */
    Slot = GetPlayerHelmetSlot(Index);
    if (Slot > 0) {
        ItemNum = GetPlayerInvItemNum(Index, Slot);
        if (ItemNum > 0) {
            if (Item_[ItemNum].Type != ITEM_TYPE_HELMET)
                SetPlayerHelmetSlot(Index, 0);
        } else {
            SetPlayerHelmetSlot(Index, 0);
        }
    }

    /* Shield */
    Slot = GetPlayerShieldSlot(Index);
    if (Slot > 0) {
        ItemNum = GetPlayerInvItemNum(Index, Slot);
        if (ItemNum > 0) {
            if (Item_[ItemNum].Type != ITEM_TYPE_SHIELD)
                SetPlayerShieldSlot(Index, 0);
        } else {
            SetPlayerShieldSlot(Index, 0);
        }
    }
}


/* ===================== */
/* GameAI - NPC AI, weather, day/night, doors */
/* Converted from VB6 modGeneral.bas GameAI() */
/* ===================== */

void GameAI(void)
{
    int i, x, y, n, x1, y1;
    int32_t TickCount;
    int Damage, DistanceX, DistanceY, NpcNum, Target;
    int DidWalk;
    char pkt[512];
    int pos;
    char msg[512];

    WeatherSeconds++;
    TimeSeconds++;

    /* Change weather if it's time */
    if (WeatherSeconds >= 60) {
        i = rand() % 3;
        if (i != GameWeather) {
            GameWeather = i;
            SendWeatherToAll();
        }
        WeatherSeconds = 0;
    }

    /* Switch day/night */
    if (TimeSeconds >= 60) {
        if (GameTime_ == TIME_DAY)
            GameTime_ = TIME_NIGHT;
        else
            GameTime_ = TIME_DAY;
        SendTimeToAll();
        TimeSeconds = 0;
    }

    for (y = 1; y <= MAX_MAPS; y++) {
        if (PlayersOnMap[y] == YES) {
            TickCount = GetTickCount();

            /* Close unlocked key doors after 5 seconds */
            if (TickCount > TempTile[y].DoorTimer + 5000) {
                for (y1 = 0; y1 <= MAX_MAPY; y1++) {
                    for (x1 = 0; x1 <= MAX_MAPX; x1++) {
                        if (Map_[y].Tile[x1][y1].Type == TILE_TYPE_KEY && TempTile[y].DoorOpen[x1][y1] == YES) {
                            TempTile[y].DoorOpen[x1][y1] = NO;
                            pos = 0;
                            pos = pkt_put(pkt, pos, sizeof(pkt), "MAPKEY");
                            pos = pkt_putint(pkt, pos, sizeof(pkt), x1);
                            pos = pkt_putint(pkt, pos, sizeof(pkt), y1);
                            pos = pkt_putint(pkt, pos, sizeof(pkt), 0);
                            pos = pkt_end(pkt, pos, sizeof(pkt));
                            SendDataToMap(y, pkt);
                        }
                    }
                }
            }

            for (x = 1; x <= MAX_MAP_NPCS; x++) {
                NpcNum = MapNpc_[y][x].Num;

                /* Attack on sight / guard behavior */
                if (Map_[y].Npc[x] > 0 && MapNpc_[y][x].Num > 0) {
                    if (Npc_[NpcNum].Behavior == NPC_BEHAVIOR_ATTACKONSIGHT || Npc_[NpcNum].Behavior == NPC_BEHAVIOR_GUARD) {
                        for (i = 1; i <= MAX_PLAYERS; i++) {
                            if (IsPlaying(i)) {
                                if (GetPlayerMap(i) == y && MapNpc_[y][x].Target == 0 && GetPlayerAccess(i) <= ADMIN_MONITER) {
                                    n = Npc_[NpcNum].Range;
                                    DistanceX = MapNpc_[y][x].x - GetPlayerX(i);
                                    DistanceY = MapNpc_[y][x].y - GetPlayerY(i);
                                    if (DistanceX < 0) DistanceX = -DistanceX;
                                    if (DistanceY < 0) DistanceY = -DistanceY;

                                    if (DistanceX <= n && DistanceY <= n) {
                                        if (Npc_[NpcNum].Behavior == NPC_BEHAVIOR_ATTACKONSIGHT || GetPlayerPK(i) == YES) {
                                            if (Npc_[NpcNum].AttackSay[0] != '\0') {
                                                snprintf(msg, sizeof(msg), "A %s says, '%s' to you.", Npc_[NpcNum].Name, Npc_[NpcNum].AttackSay);
                                                PlayerMsg(i, msg, SayColor);
                                            }
                                            MapNpc_[y][x].Target = i;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                /* NPC walking / targeting */
                if (Map_[y].Npc[x] > 0 && MapNpc_[y][x].Num > 0) {
                    Target = MapNpc_[y][x].Target;
                    if (Npc_[NpcNum].Behavior != NPC_BEHAVIOR_SHOPKEEPER) {
                        if (Target > 0) {
                            if (IsPlaying(Target) && GetPlayerMap(Target) == y) {
                                DidWalk = 0;
                                i = rand() % 5;

                                switch (i) {
                                    case 0:
                                        if (MapNpc_[y][x].y > GetPlayerY(Target) && !DidWalk) {
                                            if (CanNpcMove(y, x, DIR_UP)) {
                                                NpcMove(y, x, DIR_UP, MOVING_WALKING);
                                                DidWalk = 1;
                                            }
                                        }
                                        if (MapNpc_[y][x].y < GetPlayerY(Target) && !DidWalk) {
                                            if (CanNpcMove(y, x, DIR_DOWN)) {
                                                NpcMove(y, x, DIR_DOWN, MOVING_WALKING);
                                                DidWalk = 1;
                                            }
                                        }
                                        if (MapNpc_[y][x].x > GetPlayerX(Target) && !DidWalk) {
                                            if (CanNpcMove(y, x, DIR_LEFT)) {
                                                NpcMove(y, x, DIR_LEFT, MOVING_WALKING);
                                                DidWalk = 1;
                                            }
                                        }
                                        if (MapNpc_[y][x].x < GetPlayerX(Target) && !DidWalk) {
                                            if (CanNpcMove(y, x, DIR_RIGHT)) {
                                                NpcMove(y, x, DIR_RIGHT, MOVING_WALKING);
                                                DidWalk = 1;
                                            }
                                        }
                                        break;

                                    case 1:
                                        if (MapNpc_[y][x].x < GetPlayerX(Target) && !DidWalk) {
                                            if (CanNpcMove(y, x, DIR_RIGHT)) {
                                                NpcMove(y, x, DIR_RIGHT, MOVING_WALKING);
                                                DidWalk = 1;
                                            }
                                        }
                                        if (MapNpc_[y][x].x > GetPlayerX(Target) && !DidWalk) {
                                            if (CanNpcMove(y, x, DIR_LEFT)) {
                                                NpcMove(y, x, DIR_LEFT, MOVING_WALKING);
                                                DidWalk = 1;
                                            }
                                        }
                                        if (MapNpc_[y][x].y < GetPlayerY(Target) && !DidWalk) {
                                            if (CanNpcMove(y, x, DIR_DOWN)) {
                                                NpcMove(y, x, DIR_DOWN, MOVING_WALKING);
                                                DidWalk = 1;
                                            }
                                        }
                                        if (MapNpc_[y][x].y > GetPlayerY(Target) && !DidWalk) {
                                            if (CanNpcMove(y, x, DIR_UP)) {
                                                NpcMove(y, x, DIR_UP, MOVING_WALKING);
                                                DidWalk = 1;
                                            }
                                        }
                                        break;

                                    case 2:
                                        if (MapNpc_[y][x].y < GetPlayerY(Target) && !DidWalk) {
                                            if (CanNpcMove(y, x, DIR_DOWN)) {
                                                NpcMove(y, x, DIR_DOWN, MOVING_WALKING);
                                                DidWalk = 1;
                                            }
                                        }
                                        if (MapNpc_[y][x].y > GetPlayerY(Target) && !DidWalk) {
                                            if (CanNpcMove(y, x, DIR_UP)) {
                                                NpcMove(y, x, DIR_UP, MOVING_WALKING);
                                                DidWalk = 1;
                                            }
                                        }
                                        if (MapNpc_[y][x].x < GetPlayerX(Target) && !DidWalk) {
                                            if (CanNpcMove(y, x, DIR_RIGHT)) {
                                                NpcMove(y, x, DIR_RIGHT, MOVING_WALKING);
                                                DidWalk = 1;
                                            }
                                        }
                                        if (MapNpc_[y][x].x > GetPlayerX(Target) && !DidWalk) {
                                            if (CanNpcMove(y, x, DIR_LEFT)) {
                                                NpcMove(y, x, DIR_LEFT, MOVING_WALKING);
                                                DidWalk = 1;
                                            }
                                        }
                                        break;

                                    case 3:
                                        if (MapNpc_[y][x].x > GetPlayerX(Target) && !DidWalk) {
                                            if (CanNpcMove(y, x, DIR_LEFT)) {
                                                NpcMove(y, x, DIR_LEFT, MOVING_WALKING);
                                                DidWalk = 1;
                                            }
                                        }
                                        if (MapNpc_[y][x].x < GetPlayerX(Target) && !DidWalk) {
                                            if (CanNpcMove(y, x, DIR_RIGHT)) {
                                                NpcMove(y, x, DIR_RIGHT, MOVING_WALKING);
                                                DidWalk = 1;
                                            }
                                        }
                                        if (MapNpc_[y][x].y > GetPlayerY(Target) && !DidWalk) {
                                            if (CanNpcMove(y, x, DIR_UP)) {
                                                NpcMove(y, x, DIR_UP, MOVING_WALKING);
                                                DidWalk = 1;
                                            }
                                        }
                                        if (MapNpc_[y][x].y < GetPlayerY(Target) && !DidWalk) {
                                            if (CanNpcMove(y, x, DIR_DOWN)) {
                                                NpcMove(y, x, DIR_DOWN, MOVING_WALKING);
                                                DidWalk = 1;
                                            }
                                        }
                                        break;
                                }

                                /* Can't move - try to face player if adjacent */
                                if (!DidWalk) {
                                    if (MapNpc_[y][x].x - 1 == GetPlayerX(Target) && MapNpc_[y][x].y == GetPlayerY(Target)) {
                                        if (MapNpc_[y][x].Dir != DIR_LEFT)
                                            NpcDir(y, x, DIR_LEFT);
                                        DidWalk = 1;
                                    }
                                    if (MapNpc_[y][x].x + 1 == GetPlayerX(Target) && MapNpc_[y][x].y == GetPlayerY(Target)) {
                                        if (MapNpc_[y][x].Dir != DIR_RIGHT)
                                            NpcDir(y, x, DIR_RIGHT);
                                        DidWalk = 1;
                                    }
                                    if (MapNpc_[y][x].x == GetPlayerX(Target) && MapNpc_[y][x].y - 1 == GetPlayerY(Target)) {
                                        if (MapNpc_[y][x].Dir != DIR_UP)
                                            NpcDir(y, x, DIR_UP);
                                        DidWalk = 1;
                                    }
                                    if (MapNpc_[y][x].x == GetPlayerX(Target) && MapNpc_[y][x].y + 1 == GetPlayerY(Target)) {
                                        if (MapNpc_[y][x].Dir != DIR_DOWN)
                                            NpcDir(y, x, DIR_DOWN);
                                        DidWalk = 1;
                                    }

                                    /* Still couldn't move - walk randomly */
                                    if (!DidWalk) {
                                        i = rand() % 2;
                                        if (i == 1) {
                                            i = rand() % 4;
                                            if (CanNpcMove(y, x, i))
                                                NpcMove(y, x, i, MOVING_WALKING);
                                        }
                                    }
                                }
                            } else {
                                MapNpc_[y][x].Target = 0;
                            }
                        } else {
                            /* No target - wander randomly */
                            i = rand() % 4;
                            if (i == 1) {
                                i = rand() % 4;
                                if (CanNpcMove(y, x, i))
                                    NpcMove(y, x, i, MOVING_WALKING);
                            }
                        }
                    }
                }

                /* NPC attacking players */
                if (Map_[y].Npc[x] > 0 && MapNpc_[y][x].Num > 0) {
                    Target = MapNpc_[y][x].Target;
                    if (Target > 0) {
                        if (IsPlaying(Target) && GetPlayerMap(Target) == y) {
                            if (CanNpcAttackPlayer(x, Target)) {
                                if (!CanPlayerBlockHit(Target)) {
                                    Damage = Npc_[NpcNum].STR - GetPlayerProtection(Target);
                                    if (Damage > 0) {
                                        NpcAttackPlayer(x, Target, Damage);
                                    } else {
                                        snprintf(msg, sizeof(msg), "The %s's hit didn't even phase you!", Npc_[NpcNum].Name);
                                        PlayerMsg(Target, msg, BrightBlue);
                                    }
                                } else {
                                    snprintf(msg, sizeof(msg), "Your %s blocks the %s's hit!", Item_[GetPlayerInvItemNum(Target, GetPlayerShieldSlot(Target))].Name, Npc_[NpcNum].Name);
                                    PlayerMsg(Target, msg, BrightCyan);
                                }
                            }
                        } else {
                            MapNpc_[y][x].Target = 0;
                        }
                    }
                }

                /* Regenerate NPC HP every 10 seconds */
                if (MapNpc_[y][x].Num > 0 && TickCount > GiveNPCHPTimer + 10000) {
                    if (MapNpc_[y][x].HP > 0) {
                        MapNpc_[y][x].HP += GetNpcHPRegen(NpcNum);
                        if (MapNpc_[y][x].HP > GetNpcMaxHP(NpcNum))
                            MapNpc_[y][x].HP = GetNpcMaxHP(NpcNum);
                    }
                }

                /* Respawn dead NPCs */
                if (MapNpc_[y][x].Num == 0 && Map_[y].Npc[x] > 0) {
                    if (TickCount > MapNpc_[y][x].SpawnWait + (Npc_[Map_[y].Npc[x]].SpawnSecs * 1000)) {
                        SpawnNpc_(x, y);
                    }
                }
            }
        }
    }

    if (GetTickCount() > GiveNPCHPTimer + 10000)
        GiveNPCHPTimer = GetTickCount();

    if (GetTickCount() > KeyTimer + 15000)
        KeyTimer = GetTickCount();
}
