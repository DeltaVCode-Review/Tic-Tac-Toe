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
            // TODO: Setup your game.

            // Create a new method that creates your players and instantiates the game class.
            Console.WriteLine("Player One, What is your name?");
            string pOneName = Console.ReadLine();

            Player playerOne = new Player();
            playerOne.Name = pOneName;

            Console.WriteLine("Player Two, What is your name?");
            string pTwoName = Console.ReadLine();

            Player playerTwo = new Player();
            playerTwo.Name = pTwoName;

            Console.WriteLine($"{pOneName} and {pTwoName}, let's begin.");

            Game game = new(playerOne, playerTwo);
            Game newGame = game;


            // 
            if (newGame.Winner == playerOne)
                {
                Console.WriteLine($"Congratulations {pOneName}, you are the winner.");
                }
            else if (newGame.Winner == playerTwo)
                {
                Console.WriteLine($"Congratulations {pTwoName}, you are the winner.");
                }
            else if (newGame.Winner != playerOne && newGame.Winner != playerTwo)
                {
                Console.WriteLine("Sorry. Looks like it was a draw.");
                }

        }


    }
}
