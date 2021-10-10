using System;

namespace Lab04_TicTacToe.Classes
{
    class Board

    {
		/// <summary>
		/// Tic Tac Toe Gameboard states
		/// </summary>
		///
		public int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};

		public void DisplayBoard()
		{
			Console.WriteLine($"");
			Console.WriteLine("|  {1}  |  {2}  |  {3} |", arr[0],arr[1],arr[2]);
			Console.WriteLine("|  {4}  |  {5}  |  {6} |", arr[3],arr[4],arr[5]);
			Console.WriteLine("|  {7}  |  {8}  |  {9} |", arr[6], arr[7], arr[8]);
		
		}
	}
}
