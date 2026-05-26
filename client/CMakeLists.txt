cmake_minimum_required(VERSION 3.10)
project(MirageClient C)

set(CMAKE_C_STANDARD 11)
set(CMAKE_C_STANDARD_REQUIRED ON)

# Find CSFML
find_package(PkgConfig QUIET)
if(PKG_CONFIG_FOUND)
    pkg_check_modules(CSFML_GRAPHICS csfml-graphics)
    pkg_check_modules(CSFML_WINDOW csfml-window)
    pkg_check_modules(CSFML_SYSTEM csfml-system)
    pkg_check_modules(CSFML_NETWORK csfml-network)
    pkg_check_modules(CSFML_AUDIO csfml-audio)
endif()

if(NOT CSFML_GRAPHICS_FOUND)
    # Tier 2: find_path/find_library (Homebrew, MSYS2, system installs)
    find_path(CSFML_INCLUDE_DIR SFML/Graphics.h)
    find_library(CSFML_GFX_LIB csfml-graphics)

    if(CSFML_INCLUDE_DIR AND CSFML_GFX_LIB)
        message(STATUS "Found CSFML via find_path: ${CSFML_INCLUDE_DIR}")
        include_directories(${CSFML_INCLUDE_DIR})
        set(CSFML_LIBS csfml-graphics csfml-window csfml-system csfml-network csfml-audio)
    else()
        # Tier 3: local deps directory (Linux bundled deps)
        message(STATUS "CSFML not found, using local deps fallback")
        set(CSFML_INCLUDE_DIR "${CMAKE_SOURCE_DIR}/deps/usr/include" CACHE PATH "CSFML include dir")
        set(CSFML_LIB_DIR "${CMAKE_SOURCE_DIR}/deps/usr/lib/x86_64-linux-gnu" CACHE PATH "CSFML lib dir")
        include_directories(${CSFML_INCLUDE_DIR})
        link_directories(${CSFML_LIB_DIR})
        set(CSFML_LIBS csfml-graphics csfml-window csfml-system csfml-network csfml-audio)
    endif()
else()
    include_directories(${CSFML_GRAPHICS_INCLUDE_DIRS})
    link_directories(${CSFML_GRAPHICS_LIBRARY_DIRS})
    set(CSFML_LIBS ${CSFML_GRAPHICS_LIBRARIES} ${CSFML_WINDOW_LIBRARIES} ${CSFML_SYSTEM_LIBRARIES} ${CSFML_NETWORK_LIBRARIES} ${CSFML_AUDIO_LIBRARIES})
endif()

set(SOURCES
    src/main.c
    src/globals.c
    src/graphics.c
    src/network.c
    src/protocol.c
    src/packet_handler.c
    src/game_logic.c
    src/map_render.c
    src/ui.c
    src/screens.c
    src/sound.c
    src/database.c
    src/chat.c
    src/config.c
)

add_executable(client ${SOURCES})

if(WIN32)
    target_link_libraries(client ${CSFML_LIBS} ws2_32)
else()
    target_link_libraries(client ${CSFML_LIBS} stdc++ m)
endif()

if(CSFML_LIB_DIR)
    set_target_properties(client PROPERTIES
        BUILD_RPATH "${CSFML_LIB_DIR}"
        INSTALL_RPATH "${CSFML_LIB_DIR}"
    )
endif()

# Copy assets to build directory
add_custom_command(TARGET client POST_BUILD
    COMMAND ${CMAKE_COMMAND} -E copy_directory
    ${CMAKE_SOURCE_DIR}/assets $<TARGET_FILE_DIR:client>/assets
)
