using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class SwapNumbers
    {
        
        public static void GetSwappedNumbers()
        {
            int num1, num2, temp;

            Console.Write("Enter the first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Before swapping: num1 = {num1}, num2 = {num2}");

            // Swap the values using a temporary variable
            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine($"After swapping: num1 = {num1}, num2 = {num2}");
        }
    }

}
