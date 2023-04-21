using System;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //getting input from user to execute specific code
            Console.WriteLine("Please choose your program");
            Console.WriteLine("1.FlipCoin \n2.Leap Year \n3.Harmonic Number");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: FlipCoin.FlipTheCoin(); break;
                case 2: LeapYear.CheckLeapYear();break;
                case 3: HarmonicNumber.CalculateHarmonicNumber();break;
            }

        }
    }
}
