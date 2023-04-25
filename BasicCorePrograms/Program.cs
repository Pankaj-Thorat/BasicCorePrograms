using System;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //getting input from user to execute specific code
            Console.WriteLine("Please choose your program");
            Console.WriteLine("1.FlipCoin \n2.Leap Year \n3.Harmonic Number \n4.Prime Factor \n5.Quotient Remainder");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: FlipCoin.FlipTheCoin(); break;
                case 2: LeapYear.CheckLeapYear();break;
                case 3: HarmonicNumber.CalculateHarmonicNumber();break;
                case 4:
                    Console.WriteLine("Please enter positive number :");
                    int num = int.Parse(Console.ReadLine());
                    PrimeFactor GetPrimeFactor = new PrimeFactor();
                    int[] factor = GetPrimeFactor.GetPrimeFactors(num);
                    Console.WriteLine(string.Join(", ", factor));
                    break;
                case 5:
                    QuotientRemainder.GetQuotientRemainder();
                    break; 
                default: Console.WriteLine("Please try again and choose from given options only.");
                    break;
                    
            }

        }
    }
}
