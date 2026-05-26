#include "client.h"

// CSFML globals
sfRenderWindow *g_window = NULL;
sfEvent g_event;
int g_running = 1;
int g_currentScreen = 0;

// Forward declarations for module init/destroy
extern int GraphicsInit(void);
extern void GraphicsDestroy(void);
extern void UIInit(void);
extern void UIDestroy(void);
extern void SoundInit(void);
extern void SoundDestroy(void);
extern void TcpInit(void);
extern void TcpDestroy(void);

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

void SetScreen(int screen) {
    g_currentScreen = screen;
}

int GetScreen(void) {
    return g_currentScreen;
}

int main(int argc, char *argv[]) {
    (void)argc;
    (void)argv;

    // Create window
    sfVideoMode mode = {{960, 720}, 32};
    g_window = sfRenderWindow_create(mode, GAME_NAME, sfClose | sfTitlebar, sfWindowed, NULL);
    if (!g_window) {
        fprintf(stderr, "Failed to create window\n");
        return 1;
    }
    sfRenderWindow_setFramerateLimit(g_window, 60);

    LoadConfig();
    GraphicsInit();
    UIInit();
    SoundInit();
    TcpInit();

    SetScreen(SCREEN_MAINMENU);

    while (g_running && sfRenderWindow_isOpen(g_window)) {
        while (sfRenderWindow_pollEvent(g_window, &g_event)) {
            if (g_event.type == sfEvtClosed) {
                g_running = 0;
            }
            if (g_event.type == sfEvtTextEntered) {
                // Filter out control characters
                if (g_event.text.unicode >= 32 && g_event.text.unicode < 127) {
                    if (GetScreen() == SCREEN_GAME && InGame && InChatMode) {
                        int len = (int)strlen(MyText);
                        if (len < 255) {
                            MyText[len] = (char)g_event.text.unicode;
                            MyText[len + 1] = '\0';
                        }
                    } else {
                        UIHandleText((int)g_event.text.unicode);
                    }
                }
            }
            if (g_event.type == sfEvtKeyPressed) {
                if (GetScreen() == SCREEN_GAME && InGame) {
                    if (g_event.key.code == sfKeyEnter) {
                        if (InChatMode) {
                            HandleKeypresses(13);
                        } else {
                            InChatMode = 1;
                            MyText[0] = '\0';
                        }
                    } else if (g_event.key.code == sfKeyEscape && InChatMode) {
                        HandleKeypresses(27);
                    } else if (InChatMode && g_event.key.code == sfKeyBackspace) {
                        int len = (int)strlen(MyText);
                        if (len > 0) MyText[len - 1] = '\0';
                    } else {
                        UIHandleKey(g_event.key.code);
                    }
                } else {
                    UIHandleKey(g_event.key.code);
                    if (g_event.key.code == sfKeyEscape) {
                        if (GetScreen() == SCREEN_MAINMENU) {
                            g_running = 0;
                        } else if (GetScreen() != SCREEN_GAME) {
                            SetScreen(SCREEN_MAINMENU);
                        }
                    }
                }
            }
            if (g_event.type == sfEvtKeyReleased) {
                if (GetScreen() == SCREEN_GAME && InGame) {
                    if (g_event.key.code == sfKeyUp) DirUp = 0;
                    if (g_event.key.code == sfKeyDown) DirDown = 0;
                    if (g_event.key.code == sfKeyLeft) DirLeft = 0;
                    if (g_event.key.code == sfKeyRight) DirRight = 0;
                    if (g_event.key.code == sfKeyLShift || g_event.key.code == sfKeyRShift) ShiftDown = 0;
                    if (g_event.key.code == sfKeyLControl || g_event.key.code == sfKeyRControl) ControlDown = 0;
                }
            }
            if (g_event.type == sfEvtMouseMoved) {
                UIHandleMouseMove(g_event.mouseMove.position.x, g_event.mouseMove.position.y);
            }
            if (g_event.type == sfEvtMouseButtonPressed) {
                UIHandleMouseButton(g_event.mouseButton.button, 1,
                                    g_event.mouseButton.position.x, g_event.mouseButton.position.y);
            }
            if (g_event.type == sfEvtMouseButtonReleased) {
                UIHandleMouseButton(g_event.mouseButton.button, 0,
                                    g_event.mouseButton.position.x, g_event.mouseButton.position.y);
            }
        }

        // Network polling
        if (IsConnected()) {
            IncomingData();
        }

        // Update
        UIUpdate();

        // Render
        sfRenderWindow_clear(g_window, sfBlack);
        UIDraw();
        sfRenderWindow_display(g_window);
    }

    TcpDestroy();
    SoundDestroy();
    UIDestroy();
    GraphicsDestroy();
    sfRenderWindow_destroy(g_window);
    return 0;
}
