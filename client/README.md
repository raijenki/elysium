# Elysium - Cross-Platform C Client

This is a cross-platform C rewrite of the original VB6 Mirage Online client, using **CSFML** (C bindings for SFML) for graphics, audio, networking, and input.

## Features

- Full game client with all menu screens (Main Menu, Login, New Account, Delete Account, Character Select, New Character)
- Real-time 2D tile-based map rendering with animated tiles
- Sprite rendering for players, NPCs, and items with color-key transparency
- Complete TCP networking compatible with the `server_c` server
- Chat system with commands (`/help`, `/who`, `/fps`, `/stats`, etc.)
- Admin command support (`/kick`, `/warpmeto`, `/warptome`, `/warpto`, `/mapeditor`, etc.)
- Map caching with local `.dat` files
- Cross-platform custom UI system built on CSFML primitives

## Dependencies

- GCC or Clang (C11)
- CSFML 2.6+ (Graphics, Window, System, Network, Audio)
- SFML 2.6+ (CSFML runtime dependency)
- GNU Make or CMake

### Installing Dependencies

**Ubuntu/Debian:**
```bash
sudo apt-get install libcsfml-dev libcsfml-graphics2.6 libcsfml-window2.6 \
                     libcsfml-system2.6 libcsfml-network2.6 libcsfml-audio2.6
```

**Windows (MSYS2):**
```bash
pacman -S mingw-w64-x86_64-csfml
```

**macOS (Homebrew):**
```bash
brew install csfml
```

## Building

### Using Make

```bash
cd client_c
make
```

### Using CMake

```bash
cd client_c
mkdir build && cd build
cmake ..
make
```

## Running

```bash
./mirage_client
```

The client connects to `127.0.0.1:4000` by default (the `server_c` server).

### Assets

Place the following files in `client_c/assets/`:
- `Tiles.bmp` - Tileset (32x32 tiles, 7 per row)
- `Sprites.bmp` - Character/NPC sprites (32x32, 4 directions x 3 frames)
- `Items.bmp` - Item icons (32x32)
- `music/*.mid` - Background music files (optional)

Create a `client/maps/` directory for cached map files.

## Controls

| Key | Action |
|-----|--------|
| Arrow Keys | Move |
| Shift | Run |
| Ctrl | Attack |
| Return | Toggle chat input |
| Escape | Cancel chat / Exit menus |

## Architecture

```
client_c/
├── src/
│   ├── main.c            # Entry point, event loop
│   ├── client.h          # Shared types, constants, globals
│   ├── globals.c         # Global variable definitions
│   ├── graphics.c/h      # CSFML texture/sprite/rendering
│   ├── ui.c/h            # Custom widget system and screens
│   ├── network.c/h       # TCP socket client
│   ├── protocol.c/h      # Packet encoding helpers
│   ├── packet_handler.c  # Incoming packet router
│   ├── game_logic.c/h    # Movement, attacking, commands
│   ├── map_render.c/h    # Tile and entity rendering
│   ├── database.c/h      # Local map file I/O
│   ├── sound.c/h         # Music and SFX (CSFML Audio)
│   ├── chat.c/h          # Chat commands and messages
│   └── screens.c/h       # Additional screen logic
├── assets/               # Graphics and music
├── deps/                 # Local CSFML libraries (if needed)
└── Makefile
```

## Protocol Compatibility

This client uses the same text-based protocol as the C server (`server_c/`):
- Field separator: `\0` (null byte)
- Packet terminator: `\xED`
- Port: 4000

No server modifications are required.

## Differences from VB6 Client

- **Graphics**: DirectDraw7 replaced with CSFML 2D sprite rendering
- **Audio**: WinMM MCI replaced with CSFML Audio (MIDI support varies by platform)
- **Networking**: MSWinsock replaced with BSD sockets + CSFML Network
- **UI**: VB6 Forms replaced with custom immediate/retained mode UI on CSFML
- **Text**: GDI text replaced with CSFML Text (FreeType-based)
- **Platform**: Windows-only VB6 → Cross-platform C

## License

This conversion preserves the spirit of the original Mirage Online codebase. The original VB6 game was created by Majin Software.
