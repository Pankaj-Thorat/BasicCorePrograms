using System;

namespace BasicCorePrograms
{
    internal class FlipCoin
    {
        static void Main(string[] args)
        {
            int heads = 0;
            int tails = 0;

            Console.WriteLine("Enter number of times to flip coin:");
            int flips = Convert.ToInt32(Console.ReadLine());

            Random rndm = new Random();
            for (int i = 0; i < flips; i++)
            {
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

            double headsPercentage = (double)heads / flips * 100;
            double tailsPercentage = (double)tails / flips * 100;

            Console.WriteLine("Percentage of heads: {0}%", headsPercentage);
            Console.WriteLine("Percentage of tails: {0}%", tailsPercentage);
        }
    }
}
