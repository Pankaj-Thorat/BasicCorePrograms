using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    class FlipCoin
    {
        public static void FlipTheCoin()
        {
            int heads = 0;
            int tails = 0;
            //to get input from user for specific no coin flips
            Console.WriteLine("Enter number of times to flip coin:");
            int flips = Convert.ToInt32(Console.ReadLine());
            
            Random rndm = new Random();
            for (int i = 0; i < flips; i++)
            {
                //to generate random value from min 0 to max 1
                int result = rndm.Next(2);
                if (result == 0)
                {
                    Console.WriteLine("Heads it is!");
                    heads++;
                }
                else
                {
                    Console.WriteLine("Tails it is!");
                    tails++;
                }
            }
            //formula for percentage
            double headsPercentage = (double)heads / flips * 100;
            double tailsPercentage = (double)tails / flips * 100;
            //output
            Console.WriteLine("Percentage of heads: {0}%", headsPercentage);
            Console.WriteLine("Percentage of tails: {0}%", tailsPercentage);
        }
    }
}
