cmake_minimum_required(VERSION 3.22)
project(MirageClient C CXX)

set(CMAKE_C_STANDARD 11)
set(CMAKE_C_STANDARD_REQUIRED ON)

# Fetch SFML and CSFML from GitHub (same approach as cmake-sfml-project template)
include(FetchContent)

# Disable unnecessary SFML/CSFML targets
set(SFML_BUILD_EXAMPLES OFF CACHE BOOL "" FORCE)
set(SFML_BUILD_DOC OFF CACHE BOOL "" FORCE)
set(SFML_BUILD_TEST_SUITE OFF CACHE BOOL "" FORCE)
set(CSFML_BUILD_EXAMPLES OFF CACHE BOOL "" FORCE)
set(CSFML_BUILD_DOC OFF CACHE BOOL "" FORCE)
set(CSFML_BUILD_TEST_SUITE OFF CACHE BOOL "" FORCE)

FetchContent_Declare(SFML
    GIT_REPOSITORY https://github.com/SFML/SFML.git
    GIT_TAG 3.1.0
    GIT_SHALLOW ON
    EXCLUDE_FROM_ALL
    SYSTEM)

FetchContent_Declare(CSFML
    GIT_REPOSITORY https://github.com/SFML/CSFML.git
    GIT_TAG 3.0.0
    GIT_SHALLOW ON
    EXCLUDE_FROM_ALL
    SYSTEM)

# Make SFML available first. This creates SFML::System, SFML::Graphics, etc.
# Build SFML as shared libraries so CSFML can link against them.
set(BUILD_SHARED_LIBS ON)
FetchContent_MakeAvailable(SFML)

# CSFML does `find_package(SFML REQUIRED COMPONENTS ...)`. When SFML is a
# subdirectory, the targets exist but find_package won't find them via config.
# We prepend our custom cmake module directory so CMake finds FindSFML.cmake,
# which simply reports the already-existing targets as found.
list(INSERT CMAKE_MODULE_PATH 0 "${CMAKE_CURRENT_SOURCE_DIR}/cmake")

# Now make CSFML available. It will find our custom FindSFML.cmake and see that
# SFML targets are already present.
FetchContent_MakeAvailable(CSFML)

# Clean up module path
list(REMOVE_ITEM CMAKE_MODULE_PATH "${CMAKE_CURRENT_SOURCE_DIR}/cmake")

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

target_link_libraries(client PRIVATE
    csfml-graphics
    csfml-window
    csfml-system
    csfml-network
    csfml-audio
)

if(WIN32)
    target_link_libraries(client PRIVATE ws2_32)
    target_compile_definitions(client PRIVATE strncasecmp=_strnicmp strcasecmp=_stricmp)
else()
    target_link_libraries(client PRIVATE stdc++ m)
endif()

# Copy assets to build directory
add_custom_command(TARGET client POST_BUILD
    COMMAND ${CMAKE_COMMAND} -E copy_directory
    ${CMAKE_CURRENT_SOURCE_DIR}/assets $<TARGET_FILE_DIR:client>/assets
)
