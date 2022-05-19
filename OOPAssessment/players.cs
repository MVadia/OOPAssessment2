


namespace AssessmentCode
{


    public class player
    {
        public string name { get; set;}
    }

    public class newPlayer : player
    {
        
    }


    class PlayerData
    {

        public Dictionary<string, int> playerEntry (int numberOfPlayers)
        {
            Dictionary<string, int> playerData = new Dictionary<string, int>();
            newPlayer p = new newPlayer();

            bool validEntry = false;
            for (int i = 0; i < numberOfPlayers; i++)
            {
                Console.WriteLine("Enter username for player "+i+1);
                do
                {
                    try
                    {
                         string name = Console.ReadLine();
                         if (name.Length >= 2)
                         {
                             p.name = name;
                             playerData.Add(name, 0);
                             validEntry = true;
                             break;
                         }
                         else
                         {
                             Console.WriteLine("Name must be more than 2 letters in length.");
                             validEntry = false;
                         }
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Name already used. Please try again.");
                        validEntry = false;
                        
                    }
                } while (validEntry == false);

            }

            return playerData;
        } 




    }
}




