#include "client.h"

void UIAddChatLine(const char *text, int color);

void BroadcastMsg(const char *msg) {
    PKT_INIT(pkt);
    PKT_S(pkt, "broadcastmsg"); PKT_S(pkt, msg); PKT_END(pkt);
    SendData(pkt);
}

void EmoteMsg(const char *msg) {
    PKT_INIT(pkt);
    PKT_S(pkt, "emotemsg"); PKT_S(pkt, msg); PKT_END(pkt);
    SendData(pkt);
}

void PlayerMsg(const char *msg, const char *to) {
    PKT_INIT(pkt);
    PKT_S(pkt, "playermsg"); PKT_S(pkt, to); PKT_S(pkt, msg); PKT_END(pkt);
    SendData(pkt);
}

void GlobalMsg(const char *msg) {
    PKT_INIT(pkt);
    PKT_S(pkt, "globalmsg"); PKT_S(pkt, msg); PKT_END(pkt);
    SendData(pkt);
}

void AdminMsg(const char *msg) {
    PKT_INIT(pkt);
    PKT_S(pkt, "adminmsg"); PKT_S(pkt, msg); PKT_END(pkt);
    SendData(pkt);
}

void SendWhosOnline(void) {
    PKT_INIT(pkt);
    PKT_S(pkt, "whosonline"); PKT_END(pkt);
    SendData(pkt);
}

void SendPartyRequest(const char *name) {
    PKT_INIT(pkt);
    PKT_S(pkt, "party"); PKT_S(pkt, name); PKT_END(pkt);
    SendData(pkt);
}

void SendJoinParty(void) {
    PKT_INIT(pkt);
    PKT_S(pkt, "joinparty"); PKT_END(pkt);
    SendData(pkt);
}

void SendLeaveParty(void) {
    PKT_INIT(pkt);
    PKT_S(pkt, "leaveparty"); PKT_END(pkt);
    SendData(pkt);
}

void SendKick(const char *name) {
    PKT_INIT(pkt);
    PKT_S(pkt, "kick"); PKT_S(pkt, name); PKT_END(pkt);
    SendData(pkt);
}

void WarpMeTo(const char *name) {
    PKT_INIT(pkt);
    PKT_S(pkt, "warpmeto"); PKT_S(pkt, name); PKT_END(pkt);
    SendData(pkt);
}

void WarpToMe(const char *name) {
    PKT_INIT(pkt);
    PKT_S(pkt, "warptome"); PKT_S(pkt, name); PKT_END(pkt);
    SendData(pkt);
}

void WarpTo(int MapNum) {
    PKT_INIT(pkt);
    PKT_S(pkt, "warpto"); PKT_I(pkt, MapNum); PKT_END(pkt);
    SendData(pkt);
}

void SendSetSprite(int Sprite) {
    PKT_INIT(pkt);
    PKT_S(pkt, "setsprite"); PKT_I(pkt, Sprite); PKT_END(pkt);
    SendData(pkt);
}

void SendMapRespawn(void) {
    PKT_INIT(pkt);
    PKT_S(pkt, "maprespawn"); PKT_END(pkt);
    SendData(pkt);
}

void SendMOTDChange(const char *msg) {
    PKT_INIT(pkt);
    PKT_S(pkt, "motdchange"); PKT_S(pkt, msg); PKT_END(pkt);
    SendData(pkt);
}

void SendBanList(void) {
    PKT_INIT(pkt);
    PKT_S(pkt, "banlist"); PKT_END(pkt);
    SendData(pkt);
}

void SendBan(const char *name) {
    PKT_INIT(pkt);
    PKT_S(pkt, "ban"); PKT_S(pkt, name); PKT_END(pkt);
    SendData(pkt);
}

void SendRequestEditItem(void) {
    PKT_INIT(pkt);
    PKT_S(pkt, "requestedititem"); PKT_END(pkt);
    SendData(pkt);
}

void SendRequestEditNpc(void) {
    PKT_INIT(pkt);
    PKT_S(pkt, "requesteditnpc"); PKT_END(pkt);
    SendData(pkt);
}

void SendRequestEditShop(void) {
    PKT_INIT(pkt);
    PKT_S(pkt, "requesteditshop"); PKT_END(pkt);
    SendData(pkt);
}

void SendRequestEditSpell(void) {
    PKT_INIT(pkt);
    PKT_S(pkt, "requesteditspell"); PKT_END(pkt);
    SendData(pkt);
}

void SendRequestLocation(void) {
    PKT_INIT(pkt);
    PKT_S(pkt, "requestlocation"); PKT_END(pkt);
    SendData(pkt);
}

void SendTradeRequest(void) {
    PKT_INIT(pkt);
    PKT_S(pkt, "trade"); PKT_END(pkt);
    SendData(pkt);
}

void SendAcceptTrade(void) {
    PKT_INIT(pkt);
    PKT_S(pkt, "accepttrade"); PKT_END(pkt);
    SendData(pkt);
}

void SendDeclineTrade(void) {
    PKT_INIT(pkt);
    PKT_S(pkt, "declinetrade"); PKT_END(pkt);
    SendData(pkt);
}

void SendDropItem(int InvNum, int Amount) {
    PKT_INIT(pkt);
    PKT_S(pkt, "dropitem"); PKT_I(pkt, InvNum); PKT_I(pkt, Amount); PKT_END(pkt);
    SendData(pkt);
}

void SendUseItem(int InvNum) {
    PKT_INIT(pkt);
    PKT_S(pkt, "useitem"); PKT_I(pkt, InvNum); PKT_END(pkt);
    SendData(pkt);
}

void SendCastSpell(int SpellSlot) {
    PKT_INIT(pkt);
    PKT_S(pkt, "castspell"); PKT_I(pkt, SpellSlot); PKT_END(pkt);
    SendData(pkt);
}

void SendUnequipItem(int EquipSlot) {
    PKT_INIT(pkt);
    PKT_S(pkt, "unequip"); PKT_I(pkt, EquipSlot); PKT_END(pkt);
    SendData(pkt);
}

void SendPlayerInfoRequest(const char *name) {
    PKT_INIT(pkt);
    PKT_S(pkt, "playerinforequest"); PKT_S(pkt, name); PKT_END(pkt);
    SendData(pkt);
}

void SendStatsRequest(void) {
    PKT_INIT(pkt);
    PKT_S(pkt, "getstats"); PKT_END(pkt);
    SendData(pkt);
}
