//  board.cpp

#include <iostream>
#include <stdlib.h>
#include "board.h"

//  A function that draws the board depending on the specification.

void drawBoard(int boardSize, int** displayScore, char** displaySymbol)
{
	std::cout << "\n";

	//  Draws the character along with making a border between the values.

	for (int i = 0; i < boardSize; i++)
	{
		for (int j = 0; j < boardSize; j++)
		{
			std::cout << "|" << displaySymbol[i][j] << "|";
		}
		std::cout << std::endl;
	}
}

//  This function assigns the space with the proper character and value.

void assignSpace(char** displaySymbol, int** displayScore, int* position, int val, int boardSize)
{
	//  Creates symbols and depending on the value, also changes the character of the space.

	int total;
	char symbol = ' ';

	if (val == 1)
	{
		symbol = 'X';
	}
	if (val == 10)
	{
		symbol = 'O';
	}

	//  Checking that the spot is unassigned.

	if ((position[0] >= 0) && (position[0] <= boardSize - 1) 
		&& (position[1] >= 0) && (position[1] <= boardSize - 1) 
		&& (displayScore[position[0]][position[1]] != 10))
	{
		if ((displayScore[position[0]][position[1]] != 1))
		{
			displaySymbol[position[0]][position[1]] = symbol;
			displayScore[position[0]][position[1]] = val;
		}
	}
}

//  Boolean beck to see if the player has won.

bool winCheck(int boardSize, int** displayScore)
{
	//  The total of each check.

	int winTotal = 0;

	//  Checks if the player has won vertically.

	for (int i = 0; i < boardSize; i++)
	{
		//  Adds all of the values vertically.

		for (int j = 0; j < boardSize; j++)
		{
			winTotal += displayScore[j][i];
		}

		//  If the win total is equal to N number of X's then break or if its equal to N number of O's then break.

		if (winTotal == boardSize || winTotal == boardSize * 10)
		{
			return true;
		}

		//  Otherwise set the win total to 0 and carry on.

		winTotal = 0;
	}

	//  Checks if the player has won horizontally.

	for (int i = 0; i < boardSize; i++)
	{
		//  Adds all of the values horizontally.

		for (int j = 0; j < boardSize; j++)
		{
			winTotal += displayScore[i][j];
		}

		//  If the win total is equal to N number of X's then break or if its equal to N number of O's then break.

		if (winTotal == boardSize || winTotal == boardSize * 10)
		{
			return true;
		}

		//  Otherwise set the win total to 0 and carry on.

		winTotal = 0;
	}

	//  Checks to see if the player won diagonally down.

	for (int i = 0; i < boardSize; i++)
	{
		winTotal += displayScore[i][i];
	}

	//  If the win total is equal to N number of X's then break or if its equal to N number of O's then break.

	if (winTotal == boardSize || winTotal == boardSize * 10)
	{
		return true;
	}

	//  Otherwise set the win total to 0 and carry on.

	winTotal = 0;

	//  Checks to see if the player won diagonally up.

	for (int i = 0; i < boardSize; i++)
	{
		winTotal += displayScore[boardSize - 1 - i][i];
	}

	//  If the win total is equal to N number of X's then break or if its equal to N number of O's then break.

	if (winTotal == boardSize || winTotal == boardSize * 10)
	{
		return true;
	}

	//  Otherwise just return as false due to not finding a row of them.

	return false;
}

//  A check to see if the grid is full.

bool fullCheck(int** displayScore, int boardSize)
{
	//  Counts through every space, and if they find one without a value, return false.

	for (int i = 0; i < boardSize; i++)
	{
		for (int j = 0; j < boardSize; j++)
		{
			if (displayScore[i][j] != 10 && displayScore[i][j] != 1)
			{
				return false;
			}
		}
	}

	//  If they didnt find an empty space then it must be full so return true.

	return true;
}