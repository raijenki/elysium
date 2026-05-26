CC = gcc
CFLAGS = -Wall -Wextra -O2 -g -Ideps/usr/include
LDFLAGS = -Ldeps/usr/lib -Wl,-rpath,'$$ORIGIN/deps/usr/lib'
LIBS = -lcsfml-graphics -lcsfml-window -lcsfml-system -lcsfml-network -lcsfml-audio \
       -lsfml-graphics -lsfml-window -lsfml-system -lsfml-network -lsfml-audio \
       -lstdc++ -lm

SRCS = src/main.c \
       src/globals.c \
       src/graphics.c \
       src/network.c \
       src/protocol.c \
       src/packet_handler.c \
       src/game_logic.c \
       src/map_render.c \
       src/ui.c \
       src/screens.c \
       src/sound.c \
       src/database.c \
       src/chat.c \
       src/config.c

OBJS = $(SRCS:.c=.o)

TARGET = client

.PHONY: all clean

all: $(TARGET)

$(TARGET): $(OBJS)
	$(CC) $(LDFLAGS) -o $@ $^ $(LIBS)

src/%.o: src/%.c src/client.h
	$(CC) $(CFLAGS) -c -o $@ $<

clean:
	rm -f $(OBJS) $(TARGET)
