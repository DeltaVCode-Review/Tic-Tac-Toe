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
		{ // [0]  [1]  [2]  
			{"1", "2", "3"}, //[0]
			{"4", "5", "6"}, //[1]
			{"7", "8", "9"}, //[2]
		};

		public void DisplayBoard()
        {
            string one = GameBoard[0, 0];
            string two = GameBoard[0, 1];
            string three = GameBoard[0, 2];

            Console.WriteLine($"{one}, {two}, {three}");

            string four = GameBoard[1, 0];
            string five = GameBoard[1, 1];
            string six = GameBoard[1, 2];

            Console.WriteLine($"{four}, {five}, {six}");

            string seven = GameBoard[2, 0];
            string eight = GameBoard[2, 1];
            string nine = GameBoard[2, 2];

            Console.WriteLine($"{seven}, {eight}, {nine}");




            //Shad Sluiter method

            //int[] GameBoard = new int[9];
            //GameBoard[0] = 0;
            //GameBoard[1] = 1;
            //GameBoard[2] = 0;
            //GameBoard[3] = 0;
            //GameBoard[4] = 0;
            //GameBoard[5] = 2;
            //GameBoard[6] = 0;
            //GameBoard[7] = 0;
            //GameBoard[8] = 0;

            //for (int i = 0; i < 9; i++)
            //{
            //    //print X or O for each square
            //    // 0 is unoccupied, 1 is player one(X), 2 is player two (O).
            //    if (board[i] == 0)
            //    {
            //        Console.Write("[_]");
            //    }
            //    if (board[i] == 1)
            //    {
            //        Console.Write("[X]");
            //    }
            //    if (board[i] == 2)
            //    {
            //        Console.Write("[O]");
            //    }
            //    //print a new line every third character
            //    if (i == 2 || i == 5 || i == 8)
            //    {
            //        Console.WriteLine();
            //    }
            //}
        }
	}
}

