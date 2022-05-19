using System;


namespace AssessmentCode
{
    class scoring
    {

        int playerOneScore = 0;
        int playerTwoScore = 0;
        int extraRolls = 0;
        dieCount dc = new dieCount();

        public void rollAgain(int[] count, Dictionary<string, int> playerData, int currentPlayer)
        {
            Array.Clear(count);
            if (extraRolls == 2)
            {
                calcScores(count, playerData, currentPlayer);
            }
            
            if (extraRolls == 0)
            {
                Console.WriteLine("You rolled a double! Would you like two extra rolls");
                Console.WriteLine("1: Yes");
                Console.WriteLine("2: No");
                int inputChoice = Convert.ToInt32(Console.ReadLine());
                if (inputChoice == 1 )
                {
                    extraRolls ++;
                    count = dc.saveDieCount();
                    calcScores(count, playerData, currentPlayer);
                }
                //try statement here
            }
            if (extraRolls == 1)
            {
                Console.WriteLine("One extra roll remaining");
                extraRolls = 0;
                count = dc.saveDieCount();
                calcScores(count,playerData,currentPlayer);
            }
            
            
        }

        public void calcScores(int[] count, Dictionary<string, int> playerData, int currentPlayer)
        {

            int currentScore = 0;

            for (int i =0; i < count.Length; i++)
            {
                Console.Write(count[i] + " ");
            }
            Console.WriteLine();
            
            int matchOne = count.Count(x => x == 1);
            int matchTwo = count.Count(x => x == 2);
            int matchThree = count.Count(x => x == 3);
            int matchFour = count.Count(x => x == 4);
            int matchFive = count.Count(x => x == 5);
            int matchSix = count.Count(x => x == 6);

            if (matchOne==3||matchTwo==3||matchThree==3||matchFour==3||matchFive==3||matchSix== 3)
            {
                currentScore = 3;
                Console.WriteLine("You rolled a 3 of a kind!");
                addScores(playerData, currentPlayer, currentScore);
            }
            if (matchOne==4||matchTwo==4||matchThree==4||matchFour==4||matchFive==4||matchSix== 4)
            {
                currentScore = 6;
                Console.WriteLine("You rolled a 4 of a kind!");
                addScores(playerData, currentPlayer, currentScore);
            }
            if (matchOne==5||matchTwo==5||matchThree==5||matchFour==5||matchFive==5||matchSix== 5)
            {
                currentScore = 12;
                Console.WriteLine("You rolled a 5 of a kind!");
                addScores(playerData, currentPlayer, currentScore);
            }

            if (matchOne==2||matchTwo==2||matchThree==2||matchFour==2||matchFive==2||matchSix== 2)
            {
                currentScore = 0;
                rollAgain(count, playerData, currentPlayer);
                

            }
            else
            {
                currentScore = 0;
                addScores(playerData, currentPlayer, currentScore);

            }



        }

        public Dictionary<string, int> addScores(Dictionary<string, int> playerData, int currentPlayer, int currentScore)
        {

            endGame end = new endGame();

            int nextPlayer = 0;
            int[] count = new int [5];
            string playerOneName = playerData.ElementAt(0).Key;
            string playerTwoName = playerData.ElementAt(1).Key;

            if (currentPlayer == 0)
            {
                playerOneScore += currentScore;
                Console.WriteLine("Player: " + playerOneName + " is at "+ playerOneScore + " points!");
                
                if (playerOneScore >= 25)
                {
                    string winningPlayer = playerData.ElementAt(currentPlayer).Key;
                    string losingPlayer = playerData.ElementAt(1).Key;
                    playerData[winningPlayer] = playerOneScore;
                    playerData[losingPlayer] = playerTwoScore;
                    end.getResults(playerData);
                }
                else
                {
                    nextPlayer = 1;
                }

            }
            if (currentPlayer == 1)
            {
                playerTwoScore += currentScore;
                Console.WriteLine("Player: "+ playerTwoName + " is at "+ playerTwoScore + " points!");

                if (playerTwoScore >= 25)
                {
                    string winningPlayer = playerData.ElementAt(currentPlayer).Key;
                    string losingPlayer = playerData.ElementAt(0).Key;
                    playerData[winningPlayer] = playerTwoScore;
                    playerData[losingPlayer] = playerOneScore;
                    end.getResults(playerData);
                }
                else
                {
                    nextPlayer = 0;
                }

            }

            Console.WriteLine("Player: " + nextPlayer+1 + " turn to role.");
            Console.WriteLine("Enter 1 to roll.");
            Console.WriteLine("Enter 2 to exit game.");
            int nextRoll = Convert.ToInt32(Console.ReadLine());

            bool validEntry = false;
            do
            {
                try
                {
                    if (nextRoll == 1)
                    {
                        validEntry = true;
                        count = dc.saveDieCount();
                        currentPlayer = nextPlayer;
                        calcScores(count, playerData, currentPlayer);
                    }
                    if (nextRoll == 2)
                    {
                        Console.WriteLine("Ending game.");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Enter 1 or 2");
                        validEntry = false;
                    }
                }catch
                {
                    Console.WriteLine("Enter an integer only (1 or 2)");
                    validEntry = false;
                }
            }while(validEntry == false);

            return playerData;

        }

    }
}
