using System;





namespace AssessmentCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int dice_one = 0;
            int dice_two = 0;
            int dice_three = 0;
            int dice_four = 0;
            int dice_five = 0;

            choosePlayers c = new choosePlayers();
            int numberOfPlayers = c.playerChoice();


            newPlayer p = new newPlayer();
            for (int i =0; i < numberOfPlayers; i++ )
            {
                Console.WriteLine("Enter name for player "+i);
                p.name = Console.ReadLine();
                Console.WriteLine(string.Format("Player"+i+ ": Name = {0}", p.name));
            }





            


        }
    }
}