using System;

namespace AssessmentCode
{
    public class die
    {
        private static readonly Random generateNumber = new Random();
        private int numOnDie;

        public int dice()
        {
            numOnDie = generateNumber.Next(1,6);
            return numOnDie;
        }
    }

    public class dieCount
    {
        int[] count = new int [5];
        public int[] saveDieCount ()
        {

            die d = new die();
            for (int i = 0; i <5; i++)
            {
                count[i] = d.dice();
            }
            

            return count;
        }
    }
}
