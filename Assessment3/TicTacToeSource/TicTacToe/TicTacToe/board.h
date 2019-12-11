//  board.h

#pragma once
#include <iostream>

//  This is the header that states all of the function and what they need to run.

void drawBoard(int boardSize, int** displayScore, char** displayVal);
void assignSpace(char** displayVal, int** displayScore, int* position, int val, int boardSize);
bool winCheck(int boardSize, int** displayScore);
bool fullCheck(int** displayScore, int boardSize);