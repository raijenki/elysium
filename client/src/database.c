#include "client.h"

void SaveLocalMap(int MapNum) {
    char path[256];
    snprintf(path, sizeof(path), "maps/map%d.dat", MapNum);
    FILE *f = fopen(path, "wb");
    if (!f) return;
    fwrite(&SaveMap, sizeof(SaveMap), 1, f);
    fclose(f);
}

void LoadMap(int MapNum) {
    char path[256];
    snprintf(path, sizeof(path), "maps/map%d.dat", MapNum);
    FILE *f = fopen(path, "rb");
    if (!f) return;
    fread(&SaveMap, sizeof(SaveMap), 1, f);
    fclose(f);
}

int GetMapRevision(int MapNum) {
    MapRec tmp;
    char path[256];
    snprintf(path, sizeof(path), "maps/map%d.dat", MapNum);
    FILE *f = fopen(path, "rb");
    if (!f) return 0;
    fread(&tmp, sizeof(tmp), 1, f);
    fclose(f);
    return tmp.Revision;
}
