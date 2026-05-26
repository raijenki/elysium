#include "client.h"

void BltTile(int x, int y) {
    if (!texTiles) return;
    int Ground = Map.Tile[x][y].Ground;
    int Anim1 = Map.Tile[x][y].Mask;
    int Anim2 = Map.Tile[x][y].Anim;

    // Ground
    int srcX = (Ground % 7) * PIC_X;
    int srcY = (Ground / 7) * PIC_Y;
    GraphicsDrawSprite(texTiles, srcX, srcY, PIC_X, PIC_Y, x * PIC_X, y * PIC_Y, PIC_X, PIC_Y, false);

    // Mask/Anim
    if ((MapAnim == 0 || Anim2 <= 0) && Anim1 > 0 && TempTile[x][y].DoorOpen == NO) {
        srcX = (Anim1 % 7) * PIC_X;
        srcY = (Anim1 / 7) * PIC_Y;
        GraphicsDrawSprite(texTiles, srcX, srcY, PIC_X, PIC_Y, x * PIC_X, y * PIC_Y, PIC_X, PIC_Y, true);
    } else if (Anim2 > 0) {
        srcX = (Anim2 % 7) * PIC_X;
        srcY = (Anim2 / 7) * PIC_Y;
        GraphicsDrawSprite(texTiles, srcX, srcY, PIC_X, PIC_Y, x * PIC_X, y * PIC_Y, PIC_X, PIC_Y, true);
    }
}

void BltFringeTile(int x, int y) {
    if (!texTiles) return;
    int Fringe = Map.Tile[x][y].Fringe;
    if (Fringe > 0) {
        int srcX = (Fringe % 7) * PIC_X;
        int srcY = (Fringe / 7) * PIC_Y;
        GraphicsDrawSprite(texTiles, srcX, srcY, PIC_X, PIC_Y, x * PIC_X, y * PIC_Y, PIC_X, PIC_Y, true);
    }
}

void BltItem(int ItemNum) {
    if (!texItems) return;
    if (MapItem[ItemNum].Num <= 0) return;
    int itemPic = Item[MapItem[ItemNum].Num].Pic;
    GraphicsDrawSprite(texItems, 0, itemPic * PIC_Y, PIC_X, PIC_Y,
                       MapItem[ItemNum].x * PIC_X, MapItem[ItemNum].y * PIC_Y,
                       PIC_X, PIC_Y, true);
}

void BltPlayer(int Index) {
    if (!texSprites) return;
    if (GetPlayerSprite(Index) < 0) return;

    int Anim = 0;
    if (Player[Index].Attacking == 0) {
        switch (GetPlayerDir(Index)) {
            case DIR_UP: if (Player[Index].YOffset < PIC_Y / 2) Anim = 1; break;
            case DIR_DOWN: if (Player[Index].YOffset < -PIC_Y / 2) Anim = 1; break;
            case DIR_LEFT: if (Player[Index].XOffset < PIC_X / 2) Anim = 1; break;
            case DIR_RIGHT: if (Player[Index].XOffset < -PIC_X / 2) Anim = 1; break;
        }
    } else {
        if (Player[Index].AttackTimer + 500 > GetTickCount()) Anim = 2;
    }

    if (Player[Index].AttackTimer + 1000 < GetTickCount()) {
        Player[Index].Attacking = 0;
        Player[Index].AttackTimer = 0;
    }

    int srcY = GetPlayerSprite(Index) * PIC_Y;
    int srcX = (GetPlayerDir(Index) * 3 + Anim) * PIC_X;
    int dstX = GetPlayerX(Index) * PIC_X + Player[Index].XOffset;
    int dstY = GetPlayerY(Index) * PIC_Y + Player[Index].YOffset - 4;

    int clipY = 0;
    if (dstY < 0) {
        clipY = -dstY;
        dstY = 0;
    }

    GraphicsDrawSprite(texSprites, srcX, srcY + clipY, PIC_X, PIC_Y - clipY,
                       dstX, dstY, PIC_X, PIC_Y - clipY, true);
}

void BltNpc(int MapNpcNum) {
    if (!texSprites) return;
    if (MapNpc[MapNpcNum].Num <= 0) return;

    int Anim = 0;
    if (MapNpc[MapNpcNum].Attacking == 0) {
        switch (MapNpc[MapNpcNum].Dir) {
            case DIR_UP: if (MapNpc[MapNpcNum].YOffset < PIC_Y / 2) Anim = 1; break;
            case DIR_DOWN: if (MapNpc[MapNpcNum].YOffset < -PIC_Y / 2) Anim = 1; break;
            case DIR_LEFT: if (MapNpc[MapNpcNum].XOffset < PIC_X / 2) Anim = 1; break;
            case DIR_RIGHT: if (MapNpc[MapNpcNum].XOffset < -PIC_X / 2) Anim = 1; break;
        }
    } else {
        if (MapNpc[MapNpcNum].AttackTimer + 500 > GetTickCount()) Anim = 2;
    }

    if (MapNpc[MapNpcNum].AttackTimer + 1000 < GetTickCount()) {
        MapNpc[MapNpcNum].Attacking = 0;
        MapNpc[MapNpcNum].AttackTimer = 0;
    }

    int srcY = Npc[MapNpc[MapNpcNum].Num].Sprite * PIC_Y;
    int srcX = (MapNpc[MapNpcNum].Dir * 3 + Anim) * PIC_X;
    int dstX = MapNpc[MapNpcNum].x * PIC_X + MapNpc[MapNpcNum].XOffset;
    int dstY = MapNpc[MapNpcNum].y * PIC_Y + MapNpc[MapNpcNum].YOffset - 4;

    int clipY = 0;
    if (dstY < 0) {
        clipY = -dstY;
        dstY = 0;
    }

    GraphicsDrawSprite(texSprites, srcX, srcY + clipY, PIC_X, PIC_Y - clipY,
                       dstX, dstY, PIC_X, PIC_Y - clipY, true);
}

void BltPlayerName(int Index) {
    sfColor color;
    if (GetPlayerPK(Index) == NO) {
        switch (GetPlayerAccess(Index)) {
            case 0: color = QBColor(Brown); break;
            case 1: color = QBColor(DarkGrey); break;
            case 2: color = QBColor(Cyan); break;
            case 3: color = QBColor(Blue); break;
            case 4: color = QBColor(Pink); break;
            default: color = QBColor(Brown); break;
        }
    } else {
        color = QBColor(BrightRed);
    }

    const char *name = GetPlayerName(Index);
    int textX = GetPlayerX(Index) * PIC_X + Player[Index].XOffset + PIC_X / 2 - ((int)strlen(name) * 4);
    int textY = GetPlayerY(Index) * PIC_Y + Player[Index].YOffset - PIC_Y / 2 - 4;

    // Shadow
    GraphicsDrawText(name, textX + 2, textY + 2, 14, sfBlack);
    // Main text
    GraphicsDrawText(name, textX, textY, 14, color);
}

void RenderGame(void) {
    if (!g_window) return;

    // Render to back buffer
    sfRenderTexture_clear(g_backBuffer, sfBlack);

    // Set back buffer as target
    // Note: CSFML doesn't expose setActive easily; we draw sprites to the window directly
    // For a true backbuffer we'd need sfRenderTexture. Let's draw tiles directly for now.

    // Tiles ground + mask/anim
    for (int y = 0; y <= MAX_MAPY; y++) {
        for (int x = 0; x <= MAX_MAPX; x++) {
            BltTile(x, y);
        }
    }

    // Items
    for (int i = 1; i <= MAX_MAP_ITEMS; i++) {
        if (MapItem[i].Num > 0) BltItem(i);
    }

    // NPCs
    for (int i = 1; i <= MAX_MAP_NPCS; i++) {
        BltNpc(i);
    }

    // Players
    for (int i = 1; i <= MAX_PLAYERS; i++) {
        if (i != MyIndex && GetPlayerMap(i) == GetPlayerMap(MyIndex)) {
            BltPlayer(i);
        }
    }
    if (MyIndex > 0) BltPlayer(MyIndex);

    // Fringe
    for (int y = 0; y <= MAX_MAPY; y++) {
        for (int x = 0; x <= MAX_MAPX; x++) {
            BltFringeTile(x, y);
        }
    }

    // Names
    for (int i = 1; i <= MAX_PLAYERS; i++) {
        if (GetPlayerMap(i) == GetPlayerMap(MyIndex)) {
            BltPlayerName(i);
        }
    }

    // Editor attributes
    if (InEditor) {
        for (int y = 0; y <= MAX_MAPY; y++) {
            for (int x = 0; x <= MAX_MAPX; x++) {
                char label = 0;
                switch (Map.Tile[x][y].Type) {
                    case TILE_TYPE_BLOCKED: label = 'B'; break;
                    case TILE_TYPE_WARP: label = 'W'; break;
                    case TILE_TYPE_ITEM: label = 'I'; break;
                    case TILE_TYPE_NPCAVOID: label = 'N'; break;
                    case TILE_TYPE_KEY: label = 'K'; break;
                    case TILE_TYPE_KEYOPEN: label = 'O'; break;
                }
                if (label) {
                    char buf[2] = {label, '\0'};
                    GraphicsDrawText(buf, x * PIC_X + 8, y * PIC_Y + 8, 14, sfWhite);
                }
            }
        }
    }

    // Chat history
    int chatY = 395;
    int linesToShow = 7;
    int startLine = ChatLineCount > linesToShow ? ChatLineCount - linesToShow : 0;
    for (int i = startLine; i < ChatLineCount; i++) {
        GraphicsDrawText(ChatLines[i].text, 5, chatY, 12, QBColor(ChatLines[i].color));
        chatY += 14;
    }

    // Chat input
    if (InChatMode) {
        char buf[300];
        snprintf(buf, sizeof(buf), "> %s", MyText);
        GraphicsDrawText(buf, 5, 505, 14, sfWhite);
    }

    // Map name
    {
        char mapName[NAME_LENGTH + 1];
        strlcpy_safe(mapName, Map.Name, sizeof(mapName));
        str_trim(mapName);
        int mx = ((MAX_MAPX + 1) * PIC_X) / 2 - ((int)strlen(mapName) * 4);
        sfColor mc = (Map.Moral == MAP_MORAL_NONE) ? QBColor(BrightRed) : QBColor(White);
        GraphicsDrawText(mapName, mx, 1, 16, mc);
    }
}
