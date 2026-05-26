# FindSFML.cmake
# Custom module for when SFML is already available as a CMake subdirectory target
# (e.g. via FetchContent or add_subdirectory).
#
# This satisfies CSFML's find_package(SFML REQUIRED COMPONENTS ...) call.

include(FindPackageHandleStandardArgs)

if(NOT TARGET SFML::System)
    set(SFML_FOUND FALSE)
    set(SFML_NOT_FOUND_MESSAGE "SFML targets not available. SFML must be added via add_subdirectory or FetchContent before CSFML.")
else()
    set(SFML_FOUND TRUE)
    set(SFML_VERSION "3.1.0")

    foreach(component System Window Graphics Audio Network Main)
        if(TARGET SFML::${component})
            set(SFML_${component}_FOUND TRUE)
        else()
            set(SFML_${component}_FOUND FALSE)
        endif()
    endforeach()
endif()

find_package_handle_standard_args(SFML
    REQUIRED_VARS SFML_FOUND
    VERSION_VAR SFML_VERSION
)
