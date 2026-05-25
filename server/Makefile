CC = gcc
CFLAGS = -Wall -Wextra -O2 -std=c11 -D_POSIX_C_SOURCE=200809L -D_GNU_SOURCE
LDFLAGS = -lm

SRCS = main.c types.c database.c network.c game_logic.c
OBJS = $(SRCS:.c=.o)
TARGET = server

.PHONY: all clean

all: $(TARGET)

$(TARGET): $(OBJS)
	$(CC) $(CFLAGS) -o $@ $^ $(LDFLAGS)

%.o: %.c server.h
	$(CC) $(CFLAGS) -c -o $@ $<

clean:
	rm -f $(OBJS) $(TARGET)

debug: CFLAGS += -g -DDEBUG -O0
debug: clean all
