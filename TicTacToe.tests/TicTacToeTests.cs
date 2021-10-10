using Xunit;

namespace TicTacToe.Tests
{
    public class TicTacTest1
    {
        //Test that your program has the following functionality:
            //1. Given a game board, test for winners
            //2. Test that there is a switch in players between turns
            //3. Test to confirm that the position the player inputs correlates to the correct index of the array
            //4. One other “unique” test of your own

        [Fact]
        public void Test_For_Winners()
        {
            //Arrange
            Board testBoard = new Board();

            int[][] winners = new int[][]
            {
				//horizontal winners
				new[] {1,2,3},
                new[] {4,5,6},
                new[] {7,8,9},

				//vertical winners
				new[] {1,4,7},
                new[] {2,5,8},
                new[] {3,6,9},

				//diagonal winners
				new[] {1,5,9},
                new[] {3,5,7}
            };

            //Act


            //Assert
            
        }

        [Fact]
        public void Switches_Players_Between_Turns()
        {
            //Arrange
            Board testBoard = new Board();
            //Act

            //Assert

        }

        [Fact]
        public void Player_Input_Matches_Array_Index()
        {
            //Arrange
            //Act
            //Assert

        }

        [Fact]
        public void Test4()
        {
            //Arrange
            //Act
            //Assert

        }
    }

    internal class Board
    {
        public Board()
        {
        }
    }
}
