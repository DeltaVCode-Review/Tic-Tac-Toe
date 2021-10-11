using System;

namespace Lab04_TicTacToe.Classes
{
    class Board

    {
		/// <summary>
		/// Tic Tac Toe Gameboard states
		/// </summary>
		///

		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};

		public void DisplayBoard()
        {
			int[] board = new int[9];
			board[0] = 0;
			board[1] = 1;
			board[2] = 0;
			board[3] = 0;
			board[4] = 0;
			board[5] = 2;
			board[6] = 0;
			board[7] = 0;
			board[8] = 0;

            for (int i = 0; i < 9; i++)
            {
				//print the board
				//Console.WriteLine($"Square {i} contains {board[i]}");

				//print X or O for each square
				// 0 is unoccupied, 1 is player one(X), 2 is player two (O).

				if(board[i] == 0)
                {
					Console.Write("[_]");
                }
				if (board[i] == 1)
				{
					Console.Write("[X]");
				}
				if (board[i] == 2)
				{
					Console.Write("[O]");
				}

				//print a new line every third character
				if (i == 2 || i == 5 || i == 8)
                {
					Console.WriteLine();
                }
			}
		}
	}
}

