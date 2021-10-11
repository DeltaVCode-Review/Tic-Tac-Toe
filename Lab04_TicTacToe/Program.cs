using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Welcome to the Game.");

            StartGame();
        }

        static void StartGame()
        {
            // Create a new method that creates your players and instantiates the game class.
            Console.WriteLine("Player One, What is your name?");
            string pOneName = Console.ReadLine();
            Player playerOne = new Player();
            playerOne.Name = pOneName;
            playerOne.Marker = "X";
            playerOne.IsTurn = true;


            Console.WriteLine("Player Two, What is your name?");
            string pTwoName = Console.ReadLine();
            Player playerTwo = new Player();
            playerTwo.Name = pTwoName;
            playerTwo.Marker = "O";
            playerTwo.IsTurn = true;

            Console.WriteLine($"Hello {pOneName} and {pTwoName}. Let's begin.");
            Console.WriteLine($"{pOneName} will go first.");

            Game newGame = new Game(playerOne, playerTwo);

            // Take up to 9 turns
            for (int i = 1; i <= 9; i++)
            {
                Player winner = newGame.Play();
                if (winner != null)
                    break;
            }

            // 
            if (newGame.Winner != null)
                {
                Console.WriteLine($"Congratulations {newGame.Winner}, you are the winner.");
                }
            else if (newGame.Winner != playerOne && newGame.Winner != playerTwo)
                {
                Console.WriteLine("Sorry. Looks like it was a draw.");
                }
        }
    }
}