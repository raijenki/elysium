#include "server.h"

// ============================================================
// INI File Functions
// ============================================================

// Simple INI file reader. Returns allocated string (caller must free).
// INI format: [HEADER]\nVar=Value\n
char *get_var(const char *file, const char *header, const char *var) {
    FILE *fp;
    char line[5000];
    char section[256];
    int in_section = 0;

    fp = fopen(file, "r");
    if (!fp) {
        return strdup("");
    }

    snprintf(section, sizeof(section), "[%s]", header);

    while (fgets(line, sizeof(line), fp)) {
        // Strip trailing newline/carriage return
        size_t len = strlen(line);
        while (len > 0 && (line[len - 1] == '\n' || line[len - 1] == '\r'))
            line[--len] = '\0';

        // Check for section header
        if (line[0] == '[') {
            if (strcasecmp(line, section) == 0) {
                in_section = 1;
            } else {
                if (in_section) {
                    // We left our section without finding the var
                    break;
                }
            }
            continue;
        }

        if (in_section) {
            // Look for Var=Value
            char *eq = strchr(line, '=');
            if (eq) {
                *eq = '\0';
                char *key = line;
                char *value = eq + 1;

                // Trim key
                str_trim(key);

                if (strcasecmp(key, var) == 0) {
                    fclose(fp);
                    // Trim value
                    char *ret = str_trim_ret(value);
                    return strdup(ret);
                }
            }
        }
    }

    fclose(fp);
    return strdup("");
}

// Write/update a value in an INI file.
// If the section doesn't exist, it is appended.
// If the key doesn't exist in the section, it is added at the end of the section.
// If the key exists, its value is updated in place.
void put_var(const char *file, const char *header, const char *var, const char *value) {
    FILE *fp;
    char **lines = NULL;
    int line_count = 0;
    int line_cap = 0;
    char buf[5000];
    char section[256];
    int section_start = -1;
    int section_end = -1;
    int key_line = -1;

    snprintf(section, sizeof(section), "[%s]", header);

    // Read existing file
    fp = fopen(file, "r");
    if (fp) {
        while (fgets(buf, sizeof(buf), fp)) {
            // Strip trailing newline
            size_t len = strlen(buf);
            while (len > 0 && (buf[len - 1] == '\n' || buf[len - 1] == '\r'))
                buf[--len] = '\0';

            if (line_count >= line_cap) {
                line_cap = line_cap == 0 ? 256 : line_cap * 2;
                lines = realloc(lines, sizeof(char *) * line_cap);
            }
            lines[line_count] = strdup(buf);
            line_count++;
        }
        fclose(fp);
    }

    // Find section and key
    int in_section = 0;
    for (int i = 0; i < line_count; i++) {
        if (lines[i][0] == '[') {
            if (in_section) {
                // We left our section
                section_end = i;
                break;
            }
            if (strcasecmp(lines[i], section) == 0) {
                section_start = i;
                in_section = 1;
            }
        } else if (in_section) {
            char *eq = strchr(lines[i], '=');
            if (eq) {
                // Temporarily split to compare key
                char temp[5000];
                strncpy(temp, lines[i], (size_t)(eq - lines[i]));
                temp[eq - lines[i]] = '\0';
                str_trim(temp);
                if (strcasecmp(temp, var) == 0) {
                    key_line = i;
                }
            }
        }
    }
    if (in_section && section_end == -1) {
        section_end = line_count;
    }

    // Build the new key=value line
    char new_line[5000];
    snprintf(new_line, sizeof(new_line), "%s=%s", var, value);

    if (key_line >= 0) {
        // Update existing key
        free(lines[key_line]);
        lines[key_line] = strdup(new_line);
    } else if (section_start >= 0) {
        // Section exists but key doesn't - insert before section_end
        if (line_count >= line_cap) {
            line_cap = line_cap == 0 ? 256 : line_cap * 2;
            lines = realloc(lines, sizeof(char *) * line_cap);
        }
        // Shift lines down
        for (int i = line_count; i > section_end; i--) {
            lines[i] = lines[i - 1];
        }
        lines[section_end] = strdup(new_line);
        line_count++;
    } else {
        // Section doesn't exist - append
        // Add blank line separator if file is non-empty
        if (line_count > 0) {
            if (line_count >= line_cap) {
                line_cap = line_cap == 0 ? 256 : line_cap * 2;
                lines = realloc(lines, sizeof(char *) * line_cap);
            }
            lines[line_count++] = strdup("");
        }
        if (line_count >= line_cap) {
            line_cap += 4;
            lines = realloc(lines, sizeof(char *) * line_cap);
        }
        lines[line_count++] = strdup(section);
        if (line_count >= line_cap) {
            line_cap += 4;
            lines = realloc(lines, sizeof(char *) * line_cap);
        }
        lines[line_count++] = strdup(new_line);
    }

    // Write file back
    fp = fopen(file, "w");
    if (fp) {
        for (int i = 0; i < line_count; i++) {
            fprintf(fp, "%s\n", lines[i]);
        }
        fclose(fp);
    }

    // Free memory
    for (int i = 0; i < line_count; i++) {
        free(lines[i]);
    }
    free(lines);
}

// ============================================================
// File Exists
// ============================================================

int file_exists(const char *path) {
    return (access(path, F_OK) == 0) ? 1 : 0;
}

// ============================================================
// Save / Load Player
// ============================================================

void SavePlayer(int Index) {
    char FileName[1024];
    char section[32];
    char key[64];
    char val[64];
    int i, n;

    snprintf(FileName, sizeof(FileName), "%s/accounts/%s.ini", app_path, Player[Index].Login);

    put_var(FileName, "GENERAL", "Login", Player[Index].Login);
    put_var(FileName, "GENERAL", "Password", Player[Index].Password);

    for (i = 1; i <= MAX_CHARS; i++) {
        snprintf(section, sizeof(section), "CHAR%d", i);

        // General
        put_var(FileName, section, "Name", Player[Index].Char[i].Name);

        snprintf(val, sizeof(val), "%d", Player[Index].Char[i].Class);
        put_var(FileName, section, "Class", val);

        snprintf(val, sizeof(val), "%d", Player[Index].Char[i].Sex);
        put_var(FileName, section, "Sex", val);

        snprintf(val, sizeof(val), "%d", Player[Index].Char[i].Sprite);
        put_var(FileName, section, "Sprite", val);

        snprintf(val, sizeof(val), "%d", Player[Index].Char[i].Level);
        put_var(FileName, section, "Level", val);

        snprintf(val, sizeof(val), "%d", Player[Index].Char[i].Exp);
        put_var(FileName, section, "Exp", val);

        snprintf(val, sizeof(val), "%d", Player[Index].Char[i].Access);
        put_var(FileName, section, "Access", val);

        snprintf(val, sizeof(val), "%d", Player[Index].Char[i].PK);
        put_var(FileName, section, "PK", val);

        snprintf(val, sizeof(val), "%d", Player[Index].Char[i].Guild);
        put_var(FileName, section, "Guild", val);

        // Vitals
        snprintf(val, sizeof(val), "%d", Player[Index].Char[i].HP);
        put_var(FileName, section, "HP", val);

        snprintf(val, sizeof(val), "%d", Player[Index].Char[i].MP);
        put_var(FileName, section, "MP", val);

        snprintf(val, sizeof(val), "%d", Player[Index].Char[i].SP);
        put_var(FileName, section, "SP", val);

        // Stats
        snprintf(val, sizeof(val), "%d", Player[Index].Char[i].STR);
        put_var(FileName, section, "STR", val);

        snprintf(val, sizeof(val), "%d", Player[Index].Char[i].DEF);
        put_var(FileName, section, "DEF", val);

        snprintf(val, sizeof(val), "%d", Player[Index].Char[i].SPEED);
        put_var(FileName, section, "SPEED", val);

        snprintf(val, sizeof(val), "%d", Player[Index].Char[i].MAGI);
        put_var(FileName, section, "MAGI", val);

        snprintf(val, sizeof(val), "%d", Player[Index].Char[i].POINTS);
        put_var(FileName, section, "POINTS", val);

        // Worn equipment
        snprintf(val, sizeof(val), "%d", Player[Index].Char[i].ArmorSlot);
        put_var(FileName, section, "ArmorSlot", val);

        snprintf(val, sizeof(val), "%d", Player[Index].Char[i].WeaponSlot);
        put_var(FileName, section, "WeaponSlot", val);

        snprintf(val, sizeof(val), "%d", Player[Index].Char[i].HelmetSlot);
        put_var(FileName, section, "HelmetSlot", val);

        snprintf(val, sizeof(val), "%d", Player[Index].Char[i].ShieldSlot);
        put_var(FileName, section, "ShieldSlot", val);

        // Check to make sure that they aren't on map 0
        if (Player[Index].Char[i].Map == 0) {
            Player[Index].Char[i].Map = START_MAP;
            Player[Index].Char[i].x = START_X;
            Player[Index].Char[i].y = START_Y;
        }

        // Position
        snprintf(val, sizeof(val), "%d", Player[Index].Char[i].Map);
        put_var(FileName, section, "Map", val);

        snprintf(val, sizeof(val), "%d", Player[Index].Char[i].x);
        put_var(FileName, section, "X", val);

        snprintf(val, sizeof(val), "%d", Player[Index].Char[i].y);
        put_var(FileName, section, "Y", val);

        snprintf(val, sizeof(val), "%d", Player[Index].Char[i].Dir);
        put_var(FileName, section, "Dir", val);

        // Inventory
        for (n = 1; n <= MAX_INV; n++) {
            snprintf(key, sizeof(key), "InvItemNum%d", n);
            snprintf(val, sizeof(val), "%d", Player[Index].Char[i].Inv[n].Num);
            put_var(FileName, section, key, val);

            snprintf(key, sizeof(key), "InvItemVal%d", n);
            snprintf(val, sizeof(val), "%d", Player[Index].Char[i].Inv[n].Value);
            put_var(FileName, section, key, val);

            snprintf(key, sizeof(key), "InvItemDur%d", n);
            snprintf(val, sizeof(val), "%d", Player[Index].Char[i].Inv[n].Dur);
            put_var(FileName, section, key, val);
        }

        // Spells
        for (n = 1; n <= MAX_PLAYER_SPELLS; n++) {
            snprintf(key, sizeof(key), "Spell%d", n);
            snprintf(val, sizeof(val), "%d", Player[Index].Char[i].Spell[n]);
            put_var(FileName, section, key, val);
        }
    }
}

void LoadPlayer(int Index, const char *Name) {
    char FileName[1024];
    char section[32];
    char key[64];
    char *tmp;
    int i, n;

    ClearPlayer(Index);

    snprintf(FileName, sizeof(FileName), "%s/accounts/%s.ini", app_path, Name);

    tmp = get_var(FileName, "GENERAL", "Login");
    strlcpy_safe(Player[Index].Login, tmp, sizeof(Player[Index].Login));
    free(tmp);

    tmp = get_var(FileName, "GENERAL", "Password");
    strlcpy_safe(Player[Index].Password, tmp, sizeof(Player[Index].Password));
    free(tmp);

    for (i = 1; i <= MAX_CHARS; i++) {
        snprintf(section, sizeof(section), "CHAR%d", i);

        // General
        tmp = get_var(FileName, section, "Name");
        strlcpy_safe(Player[Index].Char[i].Name, tmp, sizeof(Player[Index].Char[i].Name));
        free(tmp);

        tmp = get_var(FileName, section, "Sex");
        Player[Index].Char[i].Sex = (uint8_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "Class");
        Player[Index].Char[i].Class = (uint8_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "Sprite");
        Player[Index].Char[i].Sprite = (int16_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "Level");
        Player[Index].Char[i].Level = (uint8_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "Exp");
        Player[Index].Char[i].Exp = (int32_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "Access");
        Player[Index].Char[i].Access = (uint8_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "PK");
        Player[Index].Char[i].PK = (uint8_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "Guild");
        Player[Index].Char[i].Guild = (uint8_t)atoi(tmp);
        free(tmp);

        // Vitals
        tmp = get_var(FileName, section, "HP");
        Player[Index].Char[i].HP = (int32_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "MP");
        Player[Index].Char[i].MP = (int32_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "SP");
        Player[Index].Char[i].SP = (int32_t)atoi(tmp);
        free(tmp);

        // Stats
        tmp = get_var(FileName, section, "STR");
        Player[Index].Char[i].STR = (uint8_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "DEF");
        Player[Index].Char[i].DEF = (uint8_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "SPEED");
        Player[Index].Char[i].SPEED = (uint8_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "MAGI");
        Player[Index].Char[i].MAGI = (uint8_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "POINTS");
        Player[Index].Char[i].POINTS = (uint8_t)atoi(tmp);
        free(tmp);

        // Worn equipment
        tmp = get_var(FileName, section, "ArmorSlot");
        Player[Index].Char[i].ArmorSlot = (uint8_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "WeaponSlot");
        Player[Index].Char[i].WeaponSlot = (uint8_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "HelmetSlot");
        Player[Index].Char[i].HelmetSlot = (uint8_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "ShieldSlot");
        Player[Index].Char[i].ShieldSlot = (uint8_t)atoi(tmp);
        free(tmp);

        // Position
        tmp = get_var(FileName, section, "Map");
        Player[Index].Char[i].Map = (int16_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "X");
        Player[Index].Char[i].x = (uint8_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "Y");
        Player[Index].Char[i].y = (uint8_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "Dir");
        Player[Index].Char[i].Dir = (uint8_t)atoi(tmp);
        free(tmp);

        // Check to make sure that they aren't on map 0
        if (Player[Index].Char[i].Map == 0) {
            Player[Index].Char[i].Map = START_MAP;
            Player[Index].Char[i].x = START_X;
            Player[Index].Char[i].y = START_Y;
        }

        // Inventory
        for (n = 1; n <= MAX_INV; n++) {
            snprintf(key, sizeof(key), "InvItemNum%d", n);
            tmp = get_var(FileName, section, key);
            Player[Index].Char[i].Inv[n].Num = (uint8_t)atoi(tmp);
            free(tmp);

            snprintf(key, sizeof(key), "InvItemVal%d", n);
            tmp = get_var(FileName, section, key);
            Player[Index].Char[i].Inv[n].Value = (int32_t)atoi(tmp);
            free(tmp);

            snprintf(key, sizeof(key), "InvItemDur%d", n);
            tmp = get_var(FileName, section, key);
            Player[Index].Char[i].Inv[n].Dur = (int16_t)atoi(tmp);
            free(tmp);
        }

        // Spells
        for (n = 1; n <= MAX_PLAYER_SPELLS; n++) {
            snprintf(key, sizeof(key), "Spell%d", n);
            tmp = get_var(FileName, section, key);
            Player[Index].Char[i].Spell[n] = (uint8_t)atoi(tmp);
            free(tmp);
        }
    }
}

// ============================================================
// Account / Character helpers
// ============================================================

int AccountExist(const char *Name) {
    char FileName[1024];
    snprintf(FileName, sizeof(FileName), "%s/accounts/%s.ini", app_path, Name);
    return file_exists(FileName);
}

int CharExist(int Index, int CharNum) {
    if (strlen(Player[Index].Char[CharNum].Name) > 0) {
        // Check it's not all whitespace
        char *trimmed = str_trim_ret(Player[Index].Char[CharNum].Name);
        int exists = (strlen(trimmed) > 0) ? 1 : 0;
        return exists;
    }
    return 0;
}

int PasswordOK(const char *Name, const char *Password) {
    char FileName[1024];
    char *right_password;

    if (!AccountExist(Name))
        return 0;

    snprintf(FileName, sizeof(FileName), "%s/accounts/%s.ini", app_path, Name);
    right_password = get_var(FileName, "GENERAL", "Password");

    // Case-insensitive compare (trimmed)
    char *trim_input = str_trim_ret(Password);
    char *trim_stored = str_trim_ret(right_password);
    free(right_password);

    to_lower(trim_input);
    to_lower(trim_stored);

    int result = (strcmp(trim_input, trim_stored) == 0) ? 1 : 0;

    return result;
}

void AddAccount(int Index, const char *Name, const char *Password) {
    int i;

    strlcpy_safe(Player[Index].Login, Name, sizeof(Player[Index].Login));
    strlcpy_safe(Player[Index].Password, Password, sizeof(Player[Index].Password));

    for (i = 1; i <= MAX_CHARS; i++) {
        ClearChar(Index, i);
    }

    SavePlayer(Index);
}

void AddChar(int Index, const char *Name, uint8_t Sex, uint8_t ClassNum, int CharNum) {
    FILE *fp;
    char path[1024];

    if (strlen(Player[Index].Char[CharNum].Name) == 0 ||
        strlen(str_trim_ret(Player[Index].Char[CharNum].Name)) == 0) {

        Player[Index].CharNum = CharNum;

        strlcpy_safe(Player[Index].Char[CharNum].Name, Name, sizeof(Player[Index].Char[CharNum].Name));
        Player[Index].Char[CharNum].Sex = Sex;
        Player[Index].Char[CharNum].Class = ClassNum;
        Player[Index].Char[CharNum].Sprite = Class[ClassNum].Sprite;
        Player[Index].Char[CharNum].Level = 1;

        Player[Index].Char[CharNum].STR = Class[ClassNum].STR;
        Player[Index].Char[CharNum].DEF = Class[ClassNum].DEF;
        Player[Index].Char[CharNum].SPEED = Class[ClassNum].SPEED;
        Player[Index].Char[CharNum].MAGI = Class[ClassNum].MAGI;

        Player[Index].Char[CharNum].Map = START_MAP;
        Player[Index].Char[CharNum].x = START_X;
        Player[Index].Char[CharNum].y = START_Y;

        Player[Index].Char[CharNum].HP = GetPlayerMaxHP(Index);
        Player[Index].Char[CharNum].MP = GetPlayerMaxMP(Index);
        Player[Index].Char[CharNum].SP = GetPlayerMaxSP(Index);

        // Append name to charlist
        snprintf(path, sizeof(path), "%s/accounts/charlist.txt", app_path);
        fp = fopen(path, "a");
        if (fp) {
            fprintf(fp, "%s\n", Name);
            fclose(fp);
        }

        SavePlayer(Index);
    }
}

void DelChar(int Index, int CharNum) {
    DeleteName(Player[Index].Char[CharNum].Name);
    ClearChar(Index, CharNum);
    SavePlayer(Index);
}

int FindChar(const char *Name) {
    FILE *fp;
    char path[1024];
    char line[256];

    snprintf(path, sizeof(path), "%s/accounts/charlist.txt", app_path);

    fp = fopen(path, "r");
    if (!fp)
        return 0;

    while (fgets(line, sizeof(line), fp)) {
        // Strip newline
        size_t len = strlen(line);
        while (len > 0 && (line[len - 1] == '\n' || line[len - 1] == '\r'))
            line[--len] = '\0';

        str_trim(line);

        char *name_trimmed = str_trim_ret(Name);

        // Case-insensitive compare
        char line_lower[256];
        char name_lower[256];
        strlcpy_safe(line_lower, line, sizeof(line_lower));
        strlcpy_safe(name_lower, name_trimmed, sizeof(name_lower));
        to_lower(line_lower);
        to_lower(name_lower);

        if (strcmp(line_lower, name_lower) == 0) {
            fclose(fp);
            return 1;
        }
    }

    fclose(fp);
    return 0;
}

void SaveAllPlayersOnline(void) {
    int i;
    for (i = 1; i <= MAX_PLAYERS; i++) {
        if (IsPlaying(i)) {
            SavePlayer(i);
        }
    }
}

// ============================================================
// Classes
// ============================================================

void LoadClasses(void) {
    char FileName[1024];
    char section[32];
    char *tmp;
    int i;

    CheckClasses();

    snprintf(FileName, sizeof(FileName), "%s/classes.ini", app_path);

    tmp = get_var(FileName, "INIT", "MaxClasses");
    Max_Classes = atoi(tmp);
    free(tmp);

    // Reallocate Class array (0 to Max_Classes)
    if (Class) {
        free(Class);
    }
    Class = calloc(Max_Classes + 1, sizeof(ClassRec));

    ClearClasses();

    for (i = 0; i <= Max_Classes; i++) {
        snprintf(section, sizeof(section), "CLASS%d", i);

        tmp = get_var(FileName, section, "Name");
        strlcpy_safe(Class[i].Name, tmp, sizeof(Class[i].Name));
        free(tmp);

        tmp = get_var(FileName, section, "Sprite");
        Class[i].Sprite = (int16_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "STR");
        Class[i].STR = (uint8_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "DEF");
        Class[i].DEF = (uint8_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "SPEED");
        Class[i].SPEED = (uint8_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "MAGI");
        Class[i].MAGI = (uint8_t)atoi(tmp);
        free(tmp);
    }
}

void SaveClasses(void) {
    char FileName[1024];
    char section[32];
    char val[64];
    int i;

    snprintf(FileName, sizeof(FileName), "%s/classes.ini", app_path);

    snprintf(val, sizeof(val), "%d", Max_Classes);
    put_var(FileName, "INIT", "MaxClasses", val);

    for (i = 0; i <= Max_Classes; i++) {
        snprintf(section, sizeof(section), "CLASS%d", i);

        put_var(FileName, section, "Name", Class[i].Name);

        snprintf(val, sizeof(val), "%d", Class[i].Sprite);
        put_var(FileName, section, "Sprite", val);

        snprintf(val, sizeof(val), "%d", Class[i].STR);
        put_var(FileName, section, "STR", val);

        snprintf(val, sizeof(val), "%d", Class[i].DEF);
        put_var(FileName, section, "DEF", val);

        snprintf(val, sizeof(val), "%d", Class[i].SPEED);
        put_var(FileName, section, "SPEED", val);

        snprintf(val, sizeof(val), "%d", Class[i].MAGI);
        put_var(FileName, section, "MAGI", val);
    }
}

void CheckClasses(void) {
    char path[1024];
    snprintf(path, sizeof(path), "%s/classes.ini", app_path);
    if (!file_exists(path)) {
        SaveClasses();
    }
}

// ============================================================
// Items
// ============================================================

void SaveItem(int ItemNum) {
    char FileName[1024];
    char section[32];
    char val[64];

    snprintf(FileName, sizeof(FileName), "%s/items.ini", app_path);
    snprintf(section, sizeof(section), "ITEM%d", ItemNum);

    put_var(FileName, section, "Name", Item_[ItemNum].Name);

    snprintf(val, sizeof(val), "%d", Item_[ItemNum].Pic);
    put_var(FileName, section, "Pic", val);

    snprintf(val, sizeof(val), "%d", Item_[ItemNum].Type);
    put_var(FileName, section, "Type", val);

    snprintf(val, sizeof(val), "%d", Item_[ItemNum].Data1);
    put_var(FileName, section, "Data1", val);

    snprintf(val, sizeof(val), "%d", Item_[ItemNum].Data2);
    put_var(FileName, section, "Data2", val);

    snprintf(val, sizeof(val), "%d", Item_[ItemNum].Data3);
    put_var(FileName, section, "Data3", val);
}

void SaveItems(void) {
    int i;
    for (i = 1; i <= MAX_ITEMS; i++) {
        SaveItem(i);
    }
}

void LoadItems(void) {
    char FileName[1024];
    char section[32];
    char *tmp;
    int i;

    CheckItems();

    snprintf(FileName, sizeof(FileName), "%s/items.ini", app_path);

    for (i = 1; i <= MAX_ITEMS; i++) {
        snprintf(section, sizeof(section), "ITEM%d", i);

        tmp = get_var(FileName, section, "Name");
        strlcpy_safe(Item_[i].Name, tmp, sizeof(Item_[i].Name));
        free(tmp);

        tmp = get_var(FileName, section, "Pic");
        Item_[i].Pic = (int16_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "Type");
        Item_[i].Type = (uint8_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "Data1");
        Item_[i].Data1 = (int16_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "Data2");
        Item_[i].Data2 = (int16_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "Data3");
        Item_[i].Data3 = (int16_t)atoi(tmp);
        free(tmp);
    }
}

void CheckItems(void) {
    char path[1024];
    snprintf(path, sizeof(path), "%s/items.ini", app_path);
    if (!file_exists(path)) {
        SaveItems();
    }
}

// ============================================================
// NPCs
// ============================================================

void SaveNpc(int NpcNum) {
    char FileName[1024];
    char section[32];
    char val[64];

    snprintf(FileName, sizeof(FileName), "%s/npcs.ini", app_path);
    snprintf(section, sizeof(section), "NPC%d", NpcNum);

    put_var(FileName, section, "Name", Npc_[NpcNum].Name);
    put_var(FileName, section, "AttackSay", Npc_[NpcNum].AttackSay);

    snprintf(val, sizeof(val), "%d", Npc_[NpcNum].Sprite);
    put_var(FileName, section, "Sprite", val);

    snprintf(val, sizeof(val), "%d", Npc_[NpcNum].SpawnSecs);
    put_var(FileName, section, "SpawnSecs", val);

    snprintf(val, sizeof(val), "%d", Npc_[NpcNum].Behavior);
    put_var(FileName, section, "Behavior", val);

    snprintf(val, sizeof(val), "%d", Npc_[NpcNum].Range);
    put_var(FileName, section, "Range", val);

    snprintf(val, sizeof(val), "%d", Npc_[NpcNum].DropChance);
    put_var(FileName, section, "DropChance", val);

    snprintf(val, sizeof(val), "%d", Npc_[NpcNum].DropItem);
    put_var(FileName, section, "DropItem", val);

    snprintf(val, sizeof(val), "%d", Npc_[NpcNum].DropItemValue);
    put_var(FileName, section, "DropItemValue", val);

    snprintf(val, sizeof(val), "%d", Npc_[NpcNum].STR);
    put_var(FileName, section, "STR", val);

    snprintf(val, sizeof(val), "%d", Npc_[NpcNum].DEF);
    put_var(FileName, section, "DEF", val);

    snprintf(val, sizeof(val), "%d", Npc_[NpcNum].SPEED);
    put_var(FileName, section, "SPEED", val);

    snprintf(val, sizeof(val), "%d", Npc_[NpcNum].MAGI);
    put_var(FileName, section, "MAGI", val);
}

void SaveNpcs(void) {
    int i;
    for (i = 1; i <= MAX_NPCS; i++) {
        SaveNpc(i);
    }
}

void LoadNpcs(void) {
    char FileName[1024];
    char section[32];
    char *tmp;
    int i;

    CheckNpcs();

    snprintf(FileName, sizeof(FileName), "%s/npcs.ini", app_path);

    for (i = 1; i <= MAX_NPCS; i++) {
        snprintf(section, sizeof(section), "NPC%d", i);

        tmp = get_var(FileName, section, "Name");
        strlcpy_safe(Npc_[i].Name, tmp, sizeof(Npc_[i].Name));
        free(tmp);

        tmp = get_var(FileName, section, "AttackSay");
        strlcpy_safe(Npc_[i].AttackSay, tmp, sizeof(Npc_[i].AttackSay));
        free(tmp);

        tmp = get_var(FileName, section, "Sprite");
        Npc_[i].Sprite = (int16_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "SpawnSecs");
        Npc_[i].SpawnSecs = (int32_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "Behavior");
        Npc_[i].Behavior = (uint8_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "Range");
        Npc_[i].Range = (uint8_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "DropChance");
        Npc_[i].DropChance = (int16_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "DropItem");
        Npc_[i].DropItem = (uint8_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "DropItemValue");
        Npc_[i].DropItemValue = (int16_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "STR");
        Npc_[i].STR = (uint8_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "DEF");
        Npc_[i].DEF = (uint8_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "SPEED");
        Npc_[i].SPEED = (uint8_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "MAGI");
        Npc_[i].MAGI = (uint8_t)atoi(tmp);
        free(tmp);
    }
}

void CheckNpcs(void) {
    char path[1024];
    snprintf(path, sizeof(path), "%s/npcs.ini", app_path);
    if (!file_exists(path)) {
        SaveNpcs();
    }
}

// ============================================================
// Shops
// ============================================================

void SaveShop(int ShopNum) {
    char FileName[1024];
    char section[32];
    char key[64];
    char val[64];
    int i;

    snprintf(FileName, sizeof(FileName), "%s/shops.ini", app_path);
    snprintf(section, sizeof(section), "SHOP%d", ShopNum);

    put_var(FileName, section, "Name", Shop_[ShopNum].Name);
    put_var(FileName, section, "JoinSay", Shop_[ShopNum].JoinSay);
    put_var(FileName, section, "LeaveSay", Shop_[ShopNum].LeaveSay);

    snprintf(val, sizeof(val), "%d", Shop_[ShopNum].FixesItems);
    put_var(FileName, section, "FixesItems", val);

    for (i = 1; i <= MAX_TRADES; i++) {
        snprintf(key, sizeof(key), "GiveItem%d", i);
        snprintf(val, sizeof(val), "%d", Shop_[ShopNum].TradeItem[i].GiveItem);
        put_var(FileName, section, key, val);

        snprintf(key, sizeof(key), "GiveValue%d", i);
        snprintf(val, sizeof(val), "%d", Shop_[ShopNum].TradeItem[i].GiveValue);
        put_var(FileName, section, key, val);

        snprintf(key, sizeof(key), "GetItem%d", i);
        snprintf(val, sizeof(val), "%d", Shop_[ShopNum].TradeItem[i].GetItem);
        put_var(FileName, section, key, val);

        snprintf(key, sizeof(key), "GetValue%d", i);
        snprintf(val, sizeof(val), "%d", Shop_[ShopNum].TradeItem[i].GetValue);
        put_var(FileName, section, key, val);
    }
}

void SaveShops(void) {
    int i;
    for (i = 1; i <= MAX_SHOPS; i++) {
        SaveShop(i);
    }
}

void LoadShops(void) {
    char FileName[1024];
    char section[32];
    char key[64];
    char *tmp;
    int i, x;

    CheckShops();

    snprintf(FileName, sizeof(FileName), "%s/shops.ini", app_path);

    for (i = 1; i <= MAX_SHOPS; i++) {
        snprintf(section, sizeof(section), "SHOP%d", i);

        tmp = get_var(FileName, section, "Name");
        strlcpy_safe(Shop_[i].Name, tmp, sizeof(Shop_[i].Name));
        free(tmp);

        tmp = get_var(FileName, section, "JoinSay");
        strlcpy_safe(Shop_[i].JoinSay, tmp, sizeof(Shop_[i].JoinSay));
        free(tmp);

        tmp = get_var(FileName, section, "LeaveSay");
        strlcpy_safe(Shop_[i].LeaveSay, tmp, sizeof(Shop_[i].LeaveSay));
        free(tmp);

        tmp = get_var(FileName, section, "FixesItems");
        Shop_[i].FixesItems = (uint8_t)atoi(tmp);
        free(tmp);

        for (x = 1; x <= MAX_TRADES; x++) {
            snprintf(key, sizeof(key), "GiveItem%d", x);
            tmp = get_var(FileName, section, key);
            Shop_[i].TradeItem[x].GiveItem = (int32_t)atoi(tmp);
            free(tmp);

            snprintf(key, sizeof(key), "GiveValue%d", x);
            tmp = get_var(FileName, section, key);
            Shop_[i].TradeItem[x].GiveValue = (int32_t)atoi(tmp);
            free(tmp);

            snprintf(key, sizeof(key), "GetItem%d", x);
            tmp = get_var(FileName, section, key);
            Shop_[i].TradeItem[x].GetItem = (int32_t)atoi(tmp);
            free(tmp);

            snprintf(key, sizeof(key), "GetValue%d", x);
            tmp = get_var(FileName, section, key);
            Shop_[i].TradeItem[x].GetValue = (int32_t)atoi(tmp);
            free(tmp);
        }
    }
}

void CheckShops(void) {
    char path[1024];
    snprintf(path, sizeof(path), "%s/shops.ini", app_path);
    if (!file_exists(path)) {
        SaveShops();
    }
}

// ============================================================
// Spells
// ============================================================

void SaveSpell(int SpellNum) {
    char FileName[1024];
    char section[32];
    char val[64];

    snprintf(FileName, sizeof(FileName), "%s/spells.ini", app_path);
    snprintf(section, sizeof(section), "SPELL%d", SpellNum);

    put_var(FileName, section, "Name", Spell_[SpellNum].Name);

    snprintf(val, sizeof(val), "%d", Spell_[SpellNum].ClassReq);
    put_var(FileName, section, "ClassReq", val);

    snprintf(val, sizeof(val), "%d", Spell_[SpellNum].LevelReq);
    put_var(FileName, section, "LevelReq", val);

    snprintf(val, sizeof(val), "%d", Spell_[SpellNum].Type);
    put_var(FileName, section, "Type", val);

    snprintf(val, sizeof(val), "%d", Spell_[SpellNum].Data1);
    put_var(FileName, section, "Data1", val);

    snprintf(val, sizeof(val), "%d", Spell_[SpellNum].Data2);
    put_var(FileName, section, "Data2", val);

    snprintf(val, sizeof(val), "%d", Spell_[SpellNum].Data3);
    put_var(FileName, section, "Data3", val);
}

void SaveSpells(void) {
    int i;
    for (i = 1; i <= MAX_SPELLS; i++) {
        SaveSpell(i);
    }
}

void LoadSpells(void) {
    char FileName[1024];
    char section[32];
    char *tmp;
    int i;

    CheckSpells();

    snprintf(FileName, sizeof(FileName), "%s/spells.ini", app_path);

    for (i = 1; i <= MAX_SPELLS; i++) {
        snprintf(section, sizeof(section), "SPELL%d", i);

        tmp = get_var(FileName, section, "Name");
        strlcpy_safe(Spell_[i].Name, tmp, sizeof(Spell_[i].Name));
        free(tmp);

        tmp = get_var(FileName, section, "ClassReq");
        Spell_[i].ClassReq = (uint8_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "LevelReq");
        Spell_[i].LevelReq = (uint8_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "Type");
        Spell_[i].Type = (uint8_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "Data1");
        Spell_[i].Data1 = (int16_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "Data2");
        Spell_[i].Data2 = (int16_t)atoi(tmp);
        free(tmp);

        tmp = get_var(FileName, section, "Data3");
        Spell_[i].Data3 = (int16_t)atoi(tmp);
        free(tmp);
    }
}

void CheckSpells(void) {
    char path[1024];
    snprintf(path, sizeof(path), "%s/spells.ini", app_path);
    if (!file_exists(path)) {
        SaveSpells();
    }
}

// ============================================================
// Maps (binary)
// ============================================================

void SaveMap(int MapNum) {
    char FileName[1024];
    FILE *fp;

    snprintf(FileName, sizeof(FileName), "%s/maps/map%d.dat", app_path, MapNum);

    fp = fopen(FileName, "wb");
    if (fp) {
        fwrite(&Map_[MapNum], sizeof(MapRec), 1, fp);
        fclose(fp);
    }
}

void SaveMaps(void) {
    int i;
    for (i = 1; i <= MAX_MAPS; i++) {
        SaveMap(i);
    }
}

void LoadMaps(void) {
    char FileName[1024];
    FILE *fp;
    int i;

    CheckMaps();

    for (i = 1; i <= MAX_MAPS; i++) {
        snprintf(FileName, sizeof(FileName), "%s/maps/map%d.dat", app_path, i);

        fp = fopen(FileName, "rb");
        if (fp) {
            fread(&Map_[i], sizeof(MapRec), 1, fp);
            fclose(fp);
        }
    }
}

void CheckMaps(void) {
    char FileName[1024];
    char dir_path[1024];
    int i;

    // Ensure maps directory exists
    snprintf(dir_path, sizeof(dir_path), "%s/maps", app_path);
    mkdir(dir_path, 0755);

    ClearMaps();

    for (i = 1; i <= MAX_MAPS; i++) {
        snprintf(FileName, sizeof(FileName), "%s/maps/map%d.dat", app_path, i);
        if (!file_exists(FileName)) {
            SaveMap(i);
        }
    }
}

// ============================================================
// Logging
// ============================================================

void AddLog(const char *Text, const char *FN) {
    char FileName[1024];
    FILE *fp;
    time_t now;
    struct tm *tm_info;
    char time_str[64];

    if (!ServerLog)
        return;

    snprintf(FileName, sizeof(FileName), "%s/%s", app_path, FN);

    now = time(NULL);
    tm_info = localtime(&now);
    strftime(time_str, sizeof(time_str), "%H:%M:%S", tm_info);

    fp = fopen(FileName, "a");
    if (fp) {
        fprintf(fp, "%s: %s\n", time_str, Text);
        fclose(fp);
    }
}

// ============================================================
// Ban
// ============================================================

void BanIndex(int BanPlayerIndex, int BannedByIndex) {
    char FileName[1024];
    char ip[46];
    char msg[512];
    FILE *fp;
    int i, len;

    snprintf(FileName, sizeof(FileName), "%s/banlist.txt", app_path);

    // Get player IP and cut off last octet
    strlcpy_safe(ip, GetPlayerIP(BanPlayerIndex), sizeof(ip));
    len = (int)strlen(ip);

    for (i = len - 1; i >= 0; i--) {
        if (ip[i] == '.') {
            ip[i + 1] = '\0';
            break;
        }
    }

    fp = fopen(FileName, "a");
    if (fp) {
        fprintf(fp, "%s,%s\n", ip, GetPlayerName(BannedByIndex));
        fclose(fp);
    }

    snprintf(msg, sizeof(msg), "%s has been banned from %s by %s!",
             GetPlayerName(BanPlayerIndex), GAME_NAME, GetPlayerName(BannedByIndex));
    GlobalMsg(msg, White);

    snprintf(msg, sizeof(msg), "%s has banned %s.",
             GetPlayerName(BannedByIndex), GetPlayerName(BanPlayerIndex));
    AddLog(msg, ADMIN_LOG);

    snprintf(msg, sizeof(msg), "You have been banned by %s!", GetPlayerName(BannedByIndex));
    AlertMsg(BanPlayerIndex, msg);
}

// ============================================================
// DeleteName - removes a name from charlist.txt
// ============================================================

void DeleteName(const char *Name) {
    char charlist_path[1024];
    char temp_path[1024];
    FILE *f1, *f2;
    char line[256];

    snprintf(charlist_path, sizeof(charlist_path), "%s/accounts/charlist.txt", app_path);
    snprintf(temp_path, sizeof(temp_path), "%s/accounts/chartemp.txt", app_path);

    // Copy charlist to temp
    f1 = fopen(charlist_path, "r");
    f2 = fopen(temp_path, "w");
    if (f1 && f2) {
        while (fgets(line, sizeof(line), f1)) {
            fputs(line, f2);
        }
    }
    if (f1) fclose(f1);
    if (f2) fclose(f2);

    // Read from temp, write back to charlist without the name
    f1 = fopen(temp_path, "r");
    f2 = fopen(charlist_path, "w");
    if (f1 && f2) {
        while (fgets(line, sizeof(line), f1)) {
            // Strip newline for comparison
            char cmp[256];
            strlcpy_safe(cmp, line, sizeof(cmp));
            size_t len = strlen(cmp);
            while (len > 0 && (cmp[len - 1] == '\n' || cmp[len - 1] == '\r'))
                cmp[--len] = '\0';
            str_trim(cmp);

            char name_lower[256];
            char cmp_lower[256];
            char *name_trimmed = str_trim_ret(Name);
            strlcpy_safe(name_lower, name_trimmed, sizeof(name_lower));
            strlcpy_safe(cmp_lower, cmp, sizeof(cmp_lower));
            to_lower(name_lower);
            to_lower(cmp_lower);

            if (strcmp(cmp_lower, name_lower) != 0) {
                // Write the original line (with newline preserved)
                // But ensure it ends with newline
                fprintf(f2, "%s\n", cmp);
            }
        }
    }
    if (f1) fclose(f1);
    if (f2) fclose(f2);

    // Remove temp file
    remove(temp_path);
}
