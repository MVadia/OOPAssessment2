using System;              
                           
                      

namespace AssessmentCode
{
    class Program
    {

        public static void Main(string[] args = null)
        {
            int numberOfPlayers = 2;
            Dictionary<string, int> players;

            die d = new die();
            dieCount dc = new dieCount();
            scoring scores = new scoring();



            PlayerData enterName = new PlayerData();
            players = enterName.playerEntry(numberOfPlayers);

            int[] count = new int [5];

            // for (int i = 0; i < numberOfPlayers; i++ )
            // {
            //     count = dc.saveDieCount();
            // }



            bool validInput = false;
            Console.WriteLine("Which player would like to roll first? Enter 1 or 2: ");
            do
            {
                try
                {
                    int currentPlayer = Convert.ToInt32(Console.ReadLine());
                    currentPlayer = currentPlayer - 1;

                    if (currentPlayer == 0)
                    {
                        validInput = true;
                        count = dc.saveDieCount();
                        scores.calcScores(count, players, currentPlayer);
                        break;
                    }
                    if (currentPlayer == 1)
                    {
                        validInput = true;
                        count = dc.saveDieCount();
                        scores.calcScores(count, players, currentPlayer);
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Enter 1 or 2 only. ");
                        validInput= false;
                    }
                }catch
                {
                    Console.WriteLine("Enter an integer only. ");
                    validInput = false;
                }
            }while(validInput == false);




        }

        
    }
}
