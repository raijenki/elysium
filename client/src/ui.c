#include "client.h"

#define MAX_WIDGETS 256
#define MAX_SCREENS 16

typedef enum {
    WIDGET_LABEL,
    WIDGET_BUTTON,
    WIDGET_TEXTBOX,
    WIDGET_LISTBOX,
    WIDGET_PANEL
} WidgetType;

typedef struct {
    WidgetType type;
    int screen;
    int x, y, w, h;
    char text[256];
    sfColor fgColor;
    sfColor bgColor;
    int visible;
    int enabled;
    int focused;
    int hovered;
    int pressed;
    // Callback
    void (*onClick)(void);
    // Listbox items
    char items[64][128];
    int itemCount;
    int selectedIndex;
    // Textbox cursor
    int cursorPos;
    int password; // mask with *
} Widget;

Widget widgets[MAX_WIDGETS];
int widgetCount = 0;
int currentScreen = 0;
int activeTextbox = -1;

// Screen constants
#define SCREEN_NONE 0
#define SCREEN_MAINMENU 1
#define SCREEN_LOGIN 2
#define SCREEN_NEWACCOUNT 3
#define SCREEN_DELACCOUNT 4
#define SCREEN_CREDITS 5
#define SCREEN_CHARS 6
#define SCREEN_NEWCHAR 7
#define SCREEN_GAME 8

// Forward screen callbacks
static void OnLoginClick(void);
static void OnNewAccountClick(void);
static void OnDelAccountClick(void);
static void OnCreditsClick(void);
static void OnQuitClick(void);
static void OnConnectClick(void);
static void OnCancelLoginClick(void);
static void OnCreateAccountClick(void);
static void OnCancelNewAccountClick(void);
static void OnUseCharClick(void);
static void OnNewCharClick(void);
static void OnDelCharClick(void);
static void OnCancelCharsClick(void);
static void OnCreateCharClick(void);
static void OnCancelNewCharClick(void);
static void OnDeleteAccountClick(void);

static int AddWidget(int screen, WidgetType type, int x, int y, int width, int height,
                     const char *text, sfColor fg, sfColor bg, void (*onClick)(void)) {
    if (widgetCount >= MAX_WIDGETS) return -1;
    int id = widgetCount++;
    Widget *w = &widgets[id];
    w->screen = screen;
    w->type = type;
    w->x = x; w->y = y; w->w = width; w->h = height;
    strlcpy_safe(w->text, text ? text : "", sizeof(w->text));
    w->fgColor = fg;
    w->bgColor = bg;
    w->visible = 1;
    w->enabled = 1;
    w->focused = 0;
    w->hovered = 0;
    w->pressed = 0;
    w->onClick = onClick;
    w->itemCount = 0;
    w->selectedIndex = -1;
    w->cursorPos = 0;
    w->password = 0;
    return id;
}

static void ClearScreenWidgets(int screen) {
    for (int i = 0; i < widgetCount; i++) {
        if (widgets[i].screen == screen) {
            widgets[i].visible = 0;
        }
    }
}

void UIInit(void) {
    widgetCount = 0;

    // Main Menu
    AddWidget(SCREEN_MAINMENU, WIDGET_LABEL,  200, 50, 400, 40, "Mirage Online", QBColor(Pink), sfTransparent, NULL);
    AddWidget(SCREEN_MAINMENU, WIDGET_BUTTON, 300, 150, 200, 40, "Login", QBColor(White), QBColor(BrightBlue), OnLoginClick);
    AddWidget(SCREEN_MAINMENU, WIDGET_BUTTON, 300, 210, 200, 40, "New Account", QBColor(White), QBColor(BrightBlue), OnNewAccountClick);
    AddWidget(SCREEN_MAINMENU, WIDGET_BUTTON, 300, 270, 200, 40, "Delete Account", QBColor(White), QBColor(BrightBlue), OnDelAccountClick);
    AddWidget(SCREEN_MAINMENU, WIDGET_BUTTON, 300, 330, 200, 40, "Credits", QBColor(White), QBColor(BrightBlue), OnCreditsClick);
    AddWidget(SCREEN_MAINMENU, WIDGET_BUTTON, 300, 390, 200, 40, "Quit", QBColor(White), QBColor(BrightRed), OnQuitClick);

    // Delete Account
    AddWidget(SCREEN_DELACCOUNT, WIDGET_LABEL,  200, 50, 400, 40, "Delete Account", QBColor(Pink), sfTransparent, NULL);
    AddWidget(SCREEN_DELACCOUNT, WIDGET_LABEL,  200, 150, 100, 30, "Name:", QBColor(White), sfTransparent, NULL);
    AddWidget(SCREEN_DELACCOUNT, WIDGET_TEXTBOX, 320, 150, 300, 30, "", QBColor(White), QBColor(DarkGrey), NULL);
    AddWidget(SCREEN_DELACCOUNT, WIDGET_LABEL,  200, 200, 100, 30, "Password:", QBColor(White), sfTransparent, NULL);
    int delpw = AddWidget(SCREEN_DELACCOUNT, WIDGET_TEXTBOX, 320, 200, 300, 30, "", QBColor(White), QBColor(DarkGrey), NULL);
    widgets[delpw].password = 1;
    AddWidget(SCREEN_DELACCOUNT, WIDGET_BUTTON, 250, 280, 150, 40, "Delete", QBColor(White), QBColor(BrightRed), OnDeleteAccountClick);
    AddWidget(SCREEN_DELACCOUNT, WIDGET_BUTTON, 420, 280, 150, 40, "Cancel", QBColor(White), QBColor(BrightBlue), OnCancelLoginClick);

    // Login
    AddWidget(SCREEN_LOGIN, WIDGET_LABEL,  200, 50, 400, 40, "Login", QBColor(Pink), sfTransparent, NULL);
    AddWidget(SCREEN_LOGIN, WIDGET_LABEL,  200, 150, 100, 30, "Name:", QBColor(White), sfTransparent, NULL);
    AddWidget(SCREEN_LOGIN, WIDGET_TEXTBOX, 320, 150, 300, 30, "", QBColor(White), QBColor(DarkGrey), NULL);
    AddWidget(SCREEN_LOGIN, WIDGET_LABEL,  200, 200, 100, 30, "Password:", QBColor(White), sfTransparent, NULL);
    int pw = AddWidget(SCREEN_LOGIN, WIDGET_TEXTBOX, 320, 200, 300, 30, "", QBColor(White), QBColor(DarkGrey), NULL);
    widgets[pw].password = 1;
    AddWidget(SCREEN_LOGIN, WIDGET_BUTTON, 250, 280, 150, 40, "Connect", QBColor(White), QBColor(BrightGreen), OnConnectClick);
    AddWidget(SCREEN_LOGIN, WIDGET_BUTTON, 420, 280, 150, 40, "Cancel", QBColor(White), QBColor(BrightRed), OnCancelLoginClick);

    // New Account
    AddWidget(SCREEN_NEWACCOUNT, WIDGET_LABEL,  200, 50, 400, 40, "New Account", QBColor(Pink), sfTransparent, NULL);
    AddWidget(SCREEN_NEWACCOUNT, WIDGET_LABEL,  200, 150, 100, 30, "Name:", QBColor(White), sfTransparent, NULL);
    AddWidget(SCREEN_NEWACCOUNT, WIDGET_TEXTBOX, 320, 150, 300, 30, "", QBColor(White), QBColor(DarkGrey), NULL);
    AddWidget(SCREEN_NEWACCOUNT, WIDGET_LABEL,  200, 200, 100, 30, "Password:", QBColor(White), sfTransparent, NULL);
    int napw = AddWidget(SCREEN_NEWACCOUNT, WIDGET_TEXTBOX, 320, 200, 300, 30, "", QBColor(White), QBColor(DarkGrey), NULL);
    widgets[napw].password = 1;
    AddWidget(SCREEN_NEWACCOUNT, WIDGET_BUTTON, 250, 280, 150, 40, "Create", QBColor(White), QBColor(BrightGreen), OnCreateAccountClick);
    AddWidget(SCREEN_NEWACCOUNT, WIDGET_BUTTON, 420, 280, 150, 40, "Cancel", QBColor(White), QBColor(BrightRed), OnCancelNewAccountClick);

    // Credits
    AddWidget(SCREEN_CREDITS, WIDGET_LABEL, 100, 50, 600, 40, "Mirage Online - Credits", QBColor(Pink), sfTransparent, NULL);
    AddWidget(SCREEN_CREDITS, WIDGET_LABEL, 100, 150, 600, 200,
              "Original VB6 game by Majin Software.\n\n"
              "Converted to cross-platform C with CSFML.",
              QBColor(White), sfTransparent, NULL);
    AddWidget(SCREEN_CREDITS, WIDGET_BUTTON, 350, 400, 200, 40, "Back", QBColor(White), QBColor(BrightBlue), OnCancelLoginClick);

    // Character Select
    AddWidget(SCREEN_CHARS, WIDGET_LABEL,  200, 20, 400, 40, "Select Character", QBColor(Pink), sfTransparent, NULL);
    AddWidget(SCREEN_CHARS, WIDGET_LISTBOX, 250, 80, 400, 150, "", QBColor(White), QBColor(DarkGrey), NULL);
    AddWidget(SCREEN_CHARS, WIDGET_BUTTON, 250, 260, 120, 35, "Use", QBColor(White), QBColor(BrightGreen), OnUseCharClick);
    AddWidget(SCREEN_CHARS, WIDGET_BUTTON, 390, 260, 120, 35, "New", QBColor(White), QBColor(BrightBlue), OnNewCharClick);
    AddWidget(SCREEN_CHARS, WIDGET_BUTTON, 530, 260, 120, 35, "Delete", QBColor(White), QBColor(BrightRed), OnDelCharClick);
    AddWidget(SCREEN_CHARS, WIDGET_BUTTON, 350, 320, 200, 35, "Cancel", QBColor(White), QBColor(BrightRed), OnCancelCharsClick);

    // New Character
    AddWidget(SCREEN_NEWCHAR, WIDGET_LABEL,  200, 20, 400, 40, "New Character", QBColor(Pink), sfTransparent, NULL);
    AddWidget(SCREEN_NEWCHAR, WIDGET_LABEL,  150, 100, 100, 30, "Name:", QBColor(White), sfTransparent, NULL);
    AddWidget(SCREEN_NEWCHAR, WIDGET_TEXTBOX, 260, 100, 300, 30, "", QBColor(White), QBColor(DarkGrey), NULL);
    AddWidget(SCREEN_NEWCHAR, WIDGET_LABEL,  150, 150, 100, 30, "Sex:", QBColor(White), sfTransparent, NULL);
    AddWidget(SCREEN_NEWCHAR, WIDGET_LABEL,  150, 200, 100, 30, "Class:", QBColor(White), sfTransparent, NULL);
    AddWidget(SCREEN_NEWCHAR, WIDGET_LISTBOX, 260, 200, 300, 100, "", QBColor(White), QBColor(DarkGrey), NULL);
    AddWidget(SCREEN_NEWCHAR, WIDGET_BUTTON, 220, 350, 150, 35, "Create", QBColor(White), QBColor(BrightGreen), OnCreateCharClick);
    AddWidget(SCREEN_NEWCHAR, WIDGET_BUTTON, 400, 350, 150, 35, "Cancel", QBColor(White), QBColor(BrightRed), OnCancelNewCharClick);

    // Game sidebar buttons
    int sbX = 520;
    AddWidget(SCREEN_GAME, WIDGET_LABEL,  sbX, 10, 200, 30, GAME_NAME, QBColor(Pink), sfTransparent, NULL);
    AddWidget(SCREEN_GAME, WIDGET_BUTTON, sbX, 50, 120, 30, "Inventory", QBColor(White), QBColor(BrightBlue), NULL);
    AddWidget(SCREEN_GAME, WIDGET_BUTTON, sbX, 90, 120, 30, "Spells", QBColor(White), QBColor(BrightBlue), NULL);
    AddWidget(SCREEN_GAME, WIDGET_BUTTON, sbX, 130, 120, 30, "Stats", QBColor(White), QBColor(BrightBlue), NULL);
    AddWidget(SCREEN_GAME, WIDGET_BUTTON, sbX, 170, 120, 30, "Train", QBColor(White), QBColor(BrightBlue), NULL);
    AddWidget(SCREEN_GAME, WIDGET_BUTTON, sbX, 210, 120, 30, "Trade", QBColor(White), QBColor(BrightBlue), NULL);
    AddWidget(SCREEN_GAME, WIDGET_BUTTON, sbX, 250, 120, 30, "Quit", QBColor(White), QBColor(BrightRed), OnQuitClick);

    // Game chat area background
    AddWidget(SCREEN_GAME, WIDGET_PANEL, 0, 390, 640, 120, "", QBColor(White), QBColor(Black), NULL);
}

void UIDestroy(void) {
    widgetCount = 0;
}

void UIUpdate(void) {
    currentScreen = GetScreen();

    if (currentScreen == SCREEN_GAME && InGame) {
        // Game input processing
        if (Player[MyIndex].Moving > 0) {
            ProcessMovement(MyIndex);
        }
        for (int i = 1; i <= MAX_MAP_NPCS; i++) {
            if (MapNpc[i].Moving > 0) {
                ProcessNpcMovement(i);
            }
        }

        // Animation timer
        if (GetTickCount() > MapAnimTimer + 250) {
            MapAnim = !MapAnim;
            MapAnimTimer = GetTickCount();
        }

        CheckMovement();
        CheckAttack();
    }
}

static void DrawWidget(Widget *w) {
    if (!w->visible || w->screen != currentScreen) return;

    sfColor bg = w->bgColor;
    if (w->type == WIDGET_BUTTON) {
        if (w->pressed) bg = QBColor(BrightCyan);
        else if (w->hovered) bg = QBColor(BrightBlue);
    }
    if (w->type == WIDGET_TEXTBOX && w->focused) {
        bg = QBColor(Blue);
    }

    // Background
    if (bg.a > 0) {
        GraphicsDrawRect(w->x, w->y, w->w, w->h, bg);
    }

    if (w->type == WIDGET_PANEL) return;

    // Border for buttons and textboxes
    if (w->type == WIDGET_BUTTON || w->type == WIDGET_TEXTBOX || w->type == WIDGET_LISTBOX) {
        sfRectangleShape *rect = sfRectangleShape_create();
        sfRectangleShape_setPosition(rect, (sfVector2f){(float)w->x, (float)w->y});
        sfRectangleShape_setSize(rect, (sfVector2f){(float)w->w, (float)w->h});
        sfRectangleShape_setFillColor(rect, sfTransparent);
        sfRectangleShape_setOutlineColor(rect, QBColor(Grey));
        sfRectangleShape_setOutlineThickness(rect, 1);
        sfRenderWindow_drawRectangleShape(g_window, rect, NULL);
        sfRectangleShape_destroy(rect);
    }

    // Text
    if (w->text[0]) {
        int tx = w->x + 4;
        int ty = w->y + (w->h - 16) / 2;
        if (w->type == WIDGET_LABEL) {
            tx = w->x;
            ty = w->y;
        }

        char display[256];
        if (w->type == WIDGET_TEXTBOX && w->password) {
            int len = (int)strlen(w->text);
            int i;
            for (i = 0; i < len && i < 255; i++) display[i] = '*';
            display[i] = '\0';
        } else {
            strlcpy_safe(display, w->text, sizeof(display));
        }

        GraphicsDrawText(display, tx, ty, 14, w->fgColor);

        // Cursor
        if (w->type == WIDGET_TEXTBOX && w->focused) {
            int cx = tx + w->cursorPos * 8;
            GraphicsDrawRect(cx, ty, 2, 14, sfWhite);
        }
    }

    // Listbox items
    if (w->type == WIDGET_LISTBOX) {
        for (int i = 0; i < w->itemCount; i++) {
            int iy = w->y + 4 + i * 18;
            if (iy + 14 > w->y + w->h) break;
            sfColor itemColor = w->fgColor;
            if (i == w->selectedIndex) {
                GraphicsDrawRect(w->x + 2, iy, w->w - 4, 16, QBColor(BrightBlue));
                itemColor = sfWhite;
            }
            GraphicsDrawText(w->items[i], w->x + 4, iy, 12, itemColor);
        }
    }
}

void UIDraw(void) {
    if (currentScreen == SCREEN_GAME && InGame) {
        RenderGame();
        // Draw game UI panels (inventory, spells, etc.) as widgets
    }

    for (int i = 0; i < widgetCount; i++) {
        DrawWidget(&widgets[i]);
    }
}

void UIHandleText(int codepoint) {
    if (activeTextbox < 0 || activeTextbox >= widgetCount) return;
    Widget *w = &widgets[activeTextbox];
    if (w->type != WIDGET_TEXTBOX) return;

    int len = (int)strlen(w->text);
    if (len < 255) {
        // Insert at cursor
        for (int i = len; i >= w->cursorPos; i--) {
            w->text[i + 1] = w->text[i];
        }
        w->text[w->cursorPos] = (char)codepoint;
        w->cursorPos++;
    }
}

void UIHandleKey(int key) {
    if (activeTextbox >= 0 && activeTextbox < widgetCount) {
        Widget *w = &widgets[activeTextbox];
        if (w->type == WIDGET_TEXTBOX) {
            if (key == sfKeyBackspace) {
                if (w->cursorPos > 0) {
                    int len = (int)strlen(w->text);
                    for (int i = w->cursorPos - 1; i < len; i++) {
                        w->text[i] = w->text[i + 1];
                    }
                    w->cursorPos--;
                }
                return;
            }
            if (key == sfKeyLeft) {
                if (w->cursorPos > 0) w->cursorPos--;
                return;
            }
            if (key == sfKeyRight) {
                if (w->cursorPos < (int)strlen(w->text)) w->cursorPos++;
                return;
            }
            if (key == sfKeyReturn) {
                activeTextbox = -1;
                w->focused = 0;
                return;
            }
        }
    }

    if (GetScreen() == SCREEN_GAME && InGame) {
        if (key == sfKeyUp) DirUp = 1;
        if (key == sfKeyDown) DirDown = 1;
        if (key == sfKeyLeft) DirLeft = 1;
        if (key == sfKeyRight) DirRight = 1;
        if (key == sfKeyLShift || key == sfKeyRShift) ShiftDown = 1;
        if (key == sfKeyLControl || key == sfKeyRControl) ControlDown = 1;
        if (key == sfKeyReturn) {
            // Chat toggle
        }
    }
}

void UIHandleMouseMove(int x, int y) {
    for (int i = 0; i < widgetCount; i++) {
        Widget *w = &widgets[i];
        if (w->screen != currentScreen || !w->visible) continue;
        w->hovered = (x >= w->x && x < w->x + w->w && y >= w->y && y < w->y + w->h);
    }
}

void UIHandleMouseButton(int button, int pressed, int x, int y) {
    (void)button;

    if (pressed) {
        activeTextbox = -1;
        for (int i = 0; i < widgetCount; i++) {
            Widget *w = &widgets[i];
            if (w->screen != currentScreen || !w->visible) continue;
            int inside = (x >= w->x && x < w->x + w->w && y >= w->y && y < w->y + w->h);
            if (inside) {
                w->pressed = 1;
                if (w->type == WIDGET_TEXTBOX) {
                    w->focused = 1;
                    activeTextbox = i;
                    w->cursorPos = (int)strlen(w->text);
                } else if (w->type == WIDGET_LISTBOX) {
                    int idx = (y - w->y - 4) / 18;
                    if (idx >= 0 && idx < w->itemCount) {
                        w->selectedIndex = idx;
                    }
                }
            } else {
                w->focused = 0;
            }
        }
    } else {
        for (int i = 0; i < widgetCount; i++) {
            Widget *w = &widgets[i];
            if (w->screen != currentScreen || !w->visible) continue;
            if (w->pressed) {
                w->pressed = 0;
                int inside = (x >= w->x && x < w->x + w->w && y >= w->y && y < w->y + w->h);
                if (inside && w->onClick) {
                    w->onClick();
                }
            }
        }
    }
}

// ==================
// Screen callbacks
// ==================

static Widget *FindWidget(int screen, WidgetType type, int index) {
    int count = 0;
    for (int i = 0; i < widgetCount; i++) {
        if (widgets[i].screen == screen && widgets[i].type == type) {
            if (count == index) return &widgets[i];
            count++;
        }
    }
    return NULL;
}

static void OnLoginClick(void) {
    SetScreen(SCREEN_LOGIN);
}

static void OnNewAccountClick(void) {
    SetScreen(SCREEN_NEWACCOUNT);
}

static void OnDelAccountClick(void) {
    SetScreen(SCREEN_DELACCOUNT);
}

static void OnCreditsClick(void) {
    SetScreen(SCREEN_CREDITS);
}

static void OnQuitClick(void) {
    GameDestroy();
}

static void OnConnectClick(void) {
    Widget *nameW = FindWidget(SCREEN_LOGIN, WIDGET_TEXTBOX, 0);
    Widget *passW = FindWidget(SCREEN_LOGIN, WIDGET_TEXTBOX, 1);
    if (!nameW || !passW) return;
    if (nameW->text[0] && passW->text[0]) {
        if (ConnectToServer(ConfigServerIP, GAME_PORT)) {
            SendLogin(nameW->text, passW->text);
        }
    }
}

static void OnCancelLoginClick(void) {
    SetScreen(SCREEN_MAINMENU);
}

static void OnCreateAccountClick(void) {
    Widget *nameW = FindWidget(SCREEN_NEWACCOUNT, WIDGET_TEXTBOX, 0);
    Widget *passW = FindWidget(SCREEN_NEWACCOUNT, WIDGET_TEXTBOX, 1);
    if (!nameW || !passW) return;
    if (nameW->text[0] && passW->text[0]) {
        if (ConnectToServer(ConfigServerIP, GAME_PORT)) {
            SendNewAccount(nameW->text, passW->text);
        }
    }
}

static void OnCancelNewAccountClick(void) {
    SetScreen(SCREEN_MAINMENU);
}

static void OnUseCharClick(void) {
    Widget *list = FindWidget(SCREEN_CHARS, WIDGET_LISTBOX, 0);
    if (!list) return;
    if (list->selectedIndex >= 0) {
        SendUseChar(list->selectedIndex + 1);
    }
}

static void OnNewCharClick(void) {
    SendGetClasses();
    SetScreen(SCREEN_NEWCHAR);
}

static void OnDelCharClick(void) {
    Widget *list = FindWidget(SCREEN_CHARS, WIDGET_LISTBOX, 0);
    if (!list) return;
    if (list->selectedIndex >= 0) {
        SendDelChar(list->selectedIndex + 1);
    }
}

static void OnCancelCharsClick(void) {
    TcpDestroy();
    SetScreen(SCREEN_MAINMENU);
}

static void OnCreateCharClick(void) {
    Widget *nameW = FindWidget(SCREEN_NEWCHAR, WIDGET_TEXTBOX, 0);
    Widget *classList = FindWidget(SCREEN_NEWCHAR, WIDGET_LISTBOX, 0);
    if (!nameW || !classList) return;
    if (nameW->text[0] && classList->selectedIndex >= 0) {
        SendAddChar(nameW->text, 0, classList->selectedIndex, 1); // default slot 1 for now
    }
}

static void OnCancelNewCharClick(void) {
    SetScreen(SCREEN_CHARS);
}

static void OnDeleteAccountClick(void) {
    Widget *nameW = FindWidget(SCREEN_DELACCOUNT, WIDGET_TEXTBOX, 0);
    Widget *passW = FindWidget(SCREEN_DELACCOUNT, WIDGET_TEXTBOX, 1);
    if (!nameW || !passW) return;
    if (nameW->text[0] && passW->text[0]) {
        if (ConnectToServer(ConfigServerIP, GAME_PORT)) {
            SendDelAccount(nameW->text, passW->text);
        }
    }
}

// ==================
// Public UI helpers
// ==================

void UISetListItems(int screen, int listIndex, const char **items, int count) {
    Widget *w = FindWidget(screen, WIDGET_LISTBOX, listIndex);
    if (!w) return;
    w->itemCount = 0;
    w->selectedIndex = -1;
    for (int i = 0; i < count && i < 64; i++) {
        strlcpy_safe(w->items[i], items[i], sizeof(w->items[i]));
        w->itemCount++;
    }
    if (w->itemCount > 0) w->selectedIndex = 0;
}

void UIAddChatLine(const char *text, int color) {
    (void)text;
    (void)color;
}
