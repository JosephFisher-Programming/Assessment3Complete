#include <iostream>
#include <stdlib.h>
#include "board.h"

//  This is the main function that runs the whole game.

int main()
{
	int boardSize = 3;
	bool gameFinished = false;
	bool playerOneWin = false;
	bool playerTwoWin = false;

	//  Asks for the grid size.

	std::cout << "What is the size of your board?" << std::endl;
	std::cin >> boardSize;

	if (boardSize <= 0)
	{
		boardSize = 3;
	}

	//  Creates a double array of symbols and also a double array of integers.

	int** displayScore = new int*[boardSize];
	char** displaySymbol = new char*[boardSize];

	//  Assigns a "space" character to displaySymbol.

	for (int i = 0; i < boardSize; i++)
	{
		displayScore[i] = new int[boardSize];
		displaySymbol[i] = new char[boardSize];

		for (int j = 0; j < boardSize; j++)
		{
			displaySymbol[i][j] = ' ';
		}
	}

	//  Draw the initial play board.

	drawBoard(boardSize, displayScore, displaySymbol);

	//  Main game loop that stops when either of the win conditions are true if other checks dont fail.

	while (playerOneWin == false && playerTwoWin == false)
	{
		int vector2Positions[2]{ 0,0 };

		if (fullCheck(displayScore, boardSize))
		{
			break;
		}

		//  Asks the first player what position it wants its choice to be at and makes it suitable for arrays and loops to reprompt.
		while (true)
		{
			std::cout << "Player X, what is the row you want to put your X in?" << std::endl;
			std::cin >> vector2Positions[0];
			vector2Positions[0]--;

			std::cout << "Player X, what is the column you want to put your X in?" << std::endl;
			std::cin >> vector2Positions[1];
			vector2Positions[1]--;

			//  If the input fails then ignore the error and fix the position.

			if (std::cin.fail())
			{
				std::cout << "Invalid Input" << std::endl;
				std::cin.clear();
				std::cin.ignore();
				continue;
			}

			break;
		}

		//  Assigns the space with the proper char, and re-draws the board.

		assignSpace(displaySymbol, displayScore, vector2Positions, 1, boardSize);

		drawBoard(boardSize, displayScore, displaySymbol);

		playerOneWin = winCheck(boardSize, displayScore);

		//  Checks to see if p1 wins and will break the loop if they did.

		if (playerOneWin == true)
		{
			break;
		}

		//  If the board is out of space, then break the loop.

		if (fullCheck(displayScore, boardSize))
		{
			break;
		}

		//  Asks the second player what position it wants its choice to be at and makes it suitable for arrays and loops to reprompt.
		while (true)
		{
			std::cout << "Player O, what is the row you want to put your O in?" << std::endl;
			std::cin >> vector2Positions[0];
			vector2Positions[0]--;

			std::cout << "Player O, what is the column you want to put your O in?" << std::endl;
			std::cin >> vector2Positions[1];
			vector2Positions[1]--;

			//  If the input fails then ignore the error and fix the position.

			if (std::cin.fail())
			{
				std::cout << "Invalid Input" << std::endl;
				std::cin.clear();
				std::cin.ignore();
				continue;
			}

			break;
		}
		//  Assigns the space with the proper char, and re-draws the board.

		assignSpace(displaySymbol, displayScore, vector2Positions, 10, boardSize);

		drawBoard(boardSize, displayScore, displaySymbol);

		playerTwoWin = winCheck(boardSize, displayScore);

		//  Checks to see if the second player wins and if they do, break the loop.

		if (playerTwoWin == true)
		{
			break;
		}

		//  If the board is out of space, then break the loop.

		if (fullCheck(displayScore, boardSize))
		{
			break;
		}
	}

	//  If player one wins then state the win screen for player one.

	if (playerOneWin == true)
	{
		std::cin.clear();
		system("CLS");
		std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
		drawBoard(boardSize, displayScore, displaySymbol);
		std::cout << "\nYOU HAVE WON THE GAME PLAYER ONE!" << std::endl;
	}

	//  If player two wins then state the win screen for player two.

	else if (playerTwoWin == true)
	{
		std::cin.clear();
		system("CLS");
		std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
		drawBoard(boardSize, displayScore, displaySymbol);
		std::cout << "\nYOU HAVE WON THE GAME PLAYER TWO!" << std::endl;
	}

	//  If neither player wins then you should display that they tied.

	else if (playerOneWin == false && playerTwoWin == false)
	{
		std::cin.clear();
		system("CLS");
		std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
		drawBoard(boardSize, displayScore, displaySymbol);
		std::cout << "\nYOU HAVE TIED!" << std::endl;
	}

	while (true) {}
	return 0;
 
}