#include "client.h"

sfTexture *texTiles = NULL;
sfTexture *texSprites = NULL;
sfTexture *texItems = NULL;
sfFont *g_font = NULL;
sfRenderTexture *g_backBuffer = NULL;

static sfTexture *LoadTextureWithColorKey(const char *path) {
    sfImage *img = sfImage_createFromFile(path);
    if (!img) return NULL;
    sfVector2u size = sfImage_getSize(img);
    for (unsigned int y = 0; y < size.y; y++) {
        for (unsigned int x = 0; x < size.x; x++) {
            sfColor c = sfImage_getPixel(img, x, y);
            if (c.r == 0 && c.g == 0 && c.b == 0) {
                sfImage_setPixel(img, x, y, sfColor_fromRGBA(0, 0, 0, 0));
            }
        }
    }
    sfTexture *tex = sfTexture_createFromImage(img, NULL);
    sfImage_destroy(img);
    return tex;
}

int GraphicsInit(void) {
    // Load textures with black color-key → alpha
    texTiles = LoadTextureWithColorKey("assets/Tiles.bmp");
    texSprites = LoadTextureWithColorKey("assets/Sprites.bmp");
    texItems = LoadTextureWithColorKey("assets/Items.bmp");

    if (!texTiles || !texSprites || !texItems) {
        fprintf(stderr, "Warning: failed to load some graphics files\n");
    }

    // Load font - try system fonts
    g_font = sfFont_createFromFile("/usr/share/fonts/truetype/dejavu/DejaVuSansMono.ttf");
    if (!g_font) g_font = sfFont_createFromFile("/usr/share/fonts/truetype/liberation/LiberationMono-Regular.ttf");
    if (!g_font) g_font = sfFont_createFromFile("/usr/share/fonts/truetype/freefont/FreeMono.ttf");
    if (!g_font) {
        fprintf(stderr, "Warning: no monospace font found, UI text may not render\n");
    }

    // Create back buffer (game viewport)
    g_backBuffer = sfRenderTexture_create((MAX_MAPX + 1) * PIC_X, (MAX_MAPY + 1) * PIC_Y, sfFalse);

    return 0;
}

void GraphicsDestroy(void) {
    if (g_backBuffer) sfRenderTexture_destroy(g_backBuffer);
    if (g_font) sfFont_destroy(g_font);
    if (texItems) sfTexture_destroy(texItems);
    if (texSprites) sfTexture_destroy(texSprites);
    if (texTiles) sfTexture_destroy(texTiles);
}

void GraphicsClear(void) {
    sfRenderWindow_clear(g_window, sfBlack);
}

void GraphicsDisplay(void) {
    sfRenderWindow_display(g_window);
}

void GraphicsDrawSprite(sfTexture *tex, int srcX, int srcY, int srcW, int srcH,
                        int dstX, int dstY, int dstW, int dstH, sfBool useKey) {
    (void)useKey;
    if (!tex) return;
    sfSprite *spr = sfSprite_create();
    sfSprite_setTexture(spr, tex, sfTrue);
    sfIntRect srcRect = {srcX, srcY, srcW, srcH};
    sfSprite_setTextureRect(spr, srcRect);
    sfSprite_setPosition(spr, (sfVector2f){(float)dstX, (float)dstY});
    if (dstW != srcW || dstH != srcH) {
        sfSprite_setScale(spr, (sfVector2f){(float)dstW / srcW, (float)dstH / srcH});
    }
    sfRenderWindow_drawSprite(g_window, spr, NULL);
    sfSprite_destroy(spr);
}

void GraphicsDrawRect(int x, int y, int w, int h, sfColor color) {
    sfRectangleShape *rect = sfRectangleShape_create();
    sfRectangleShape_setPosition(rect, (sfVector2f){(float)x, (float)y});
    sfRectangleShape_setSize(rect, (sfVector2f){(float)w, (float)h});
    sfRectangleShape_setFillColor(rect, color);
    sfRenderWindow_drawRectangleShape(g_window, rect, NULL);
    sfRectangleShape_destroy(rect);
}

void GraphicsDrawText(const char *text, int x, int y, int size, sfColor color) {
    if (!g_font || !text) return;
    sfText *t = sfText_create();
    sfText_setFont(t, g_font);
    sfText_setString(t, text);
    sfText_setCharacterSize(t, (unsigned int)size);
    sfText_setColor(t, color);
    sfText_setPosition(t, (sfVector2f){(float)x, (float)y});
    sfRenderWindow_drawText(g_window, t, NULL);
    sfText_destroy(t);
}
