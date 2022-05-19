using System;

namespace AssessmentCode
{
    class endGame
    {
        public void getResults (Dictionary<string, int> playerData)
        {

            string playerOne = playerData.ElementAt(0).Key;
            string playerTwo = playerData.ElementAt(1).Key;
            int playerOneScore = playerData[playerOne];
            int playerTwoScore = playerData[playerTwo];
            
            if (playerOneScore > playerTwoScore)
            {
                Console.WriteLine(playerOne + " Wins the game with "+ playerOneScore + " points!");
                Console.WriteLine(playerTwo + " Scored "+ playerTwoScore + "points!");
            }
            if (playerTwoScore > playerOneScore)
            {
                Console.WriteLine(playerTwo + " Wins the game with "+ playerTwoScore + " points!");
                Console.WriteLine(playerOne + " Scored "+ playerOneScore + "points!");
            }

            Console.WriteLine("Would you like to play again or exit?");
            Console.WriteLine("1: Play again");
            Console.WriteLine("2: Exit");
            int inputChoice = Convert.ToInt32(Console.ReadLine());
            if (inputChoice == 1)
            {
                playerData.Clear();
                Program.Main(null);
            }
            if (inputChoice == 2)
            {
                Environment.Exit(0);
            }





        }
    }

    
}
