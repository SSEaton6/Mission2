using System;

namespace InClassJan18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine("How many dice rolls would you like to simulate? ");
            
            string number = Console.ReadLine();
            int numRolls = Convert.ToInt32(number);

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
            Console.WriteLine("Total Number of rolls = " + numRolls);

            randomNumberGen(numRolls);
        }

        static void randomNumberGen(int numRolls)
        {
            // This method generates a random number for each number 2-12 to simulate two die being thrown and their numbers added together
            Random r = new Random();

            int[] twodie = new int[11];

            for (int i = 0; i < numRolls; i++)
            {
                twodie[r.Next(11)]++;
            }
            //calls the assign percent method to calculate what percent of rolls each number were
            assignPercent(twodie, numRolls);
        }
        static void assignPercent(int[] twodie, int numRolls)
        {
            string[] stars = new string[11];
            for (int j = 0; j < twodie.Length; j++)
            {
                // can't divide integers so convert to a float and then back to an integer
                float numJ = twodie[j];
                int percentnum = Convert.ToInt32((numJ / numRolls) * 100);

                // creates another array to store the '*' count for each number
                for (int k = percentnum; k > 0; k--)
                {
                    string value1 = stars[j];
                    value1 = value1 + "*";
                    stars[j] = value1;
                }
            }
            // calls the method to finish printing the results of the game
            PrintItAll(stars);
        }
        static void PrintItAll(string[] stars)
        {
            // loop to run through and create the output variable to print
            for (int l = 0; l < stars.Length; l++)
            {
                string stext = (l + 2) + ": " + stars[l];
                Console.WriteLine(stext);
            }
            Console.WriteLine("Thank you for using the dice throwing simulator! Goodbye.");
        }
    }
}
