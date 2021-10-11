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
            //string one = GameBoard[0, 0];
            //string two = GameBoard[0, 1];
            //string three = GameBoard[0, 2];

            //Console.WriteLine($"| {one} | {two} | {three} |");

            //string four = GameBoard[1, 0];
            //string five = GameBoard[1, 1];
            //string six = GameBoard[1, 2];

            //Console.WriteLine($"{four}, {five}, {six}");

            //string seven = GameBoard[2, 0];
            //string eight = GameBoard[2, 1];
            //string nine = GameBoard[2, 2];

            //Console.WriteLine($"{seven}, {eight}, {nine}");

            for (int column = 0; column < 3; column++)
            {
                for (int row = 0; row < 3; row++)
                    Console.Write("[{0}]", GameBoard[column, row]);
                Console.WriteLine();
            }
            
        }





       

       
	}
}

