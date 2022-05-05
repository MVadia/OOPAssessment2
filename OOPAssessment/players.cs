


namespace AssessmentCode
{


    public class player
    {
        public string name { get; set;}
    }

    public class newPlayer : player
    {
        
    }
    class choosePlayers
    {
        public int playerChoice ()
        {
            int numberOfPlayers = 0;
            Console.WriteLine("Enter number of players (2-5): ");
            bool validEntry = false;
            do
            {
                try
                {
                     int input = Convert.ToInt32(Console.ReadLine());
                     if (input <= 5 && input >=2)
                     {
                         numberOfPlayers = input;
                         validEntry = true;
                         return numberOfPlayers;
                     } 
                     else
                     {
                         Console.WriteLine("Value must be between 2 and 5 (inclusive)");
                         validEntry = false;
                     }
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Invalid Input, Re-Enter");
                }
                
            } while (validEntry == false);
            return 0;
        }


    }
}

