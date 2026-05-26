#include "client.h"

static sfMusic *currentMusic = NULL;

void SoundInit(void) {
    currentMusic = NULL;
}

void SoundDestroy(void) {
    if (currentMusic) {
        sfMusic_stop(currentMusic);
        sfMusic_destroy(currentMusic);
        currentMusic = NULL;
    }
}

void PlayMidi(const char *song) {
    (void)song;
    // TODO: load and play MIDI/OGG file
}

void StopMidi(void) {
    if (currentMusic) {
        sfMusic_stop(currentMusic);
        sfMusic_destroy(currentMusic);
        currentMusic = NULL;
    }
}

void PlayGameSound(const char *sound) {
    (void)sound;
    // TODO: play WAV sound effect
}
