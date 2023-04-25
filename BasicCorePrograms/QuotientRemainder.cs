using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
     class QuotientRemainder
     {
          public static void GetQuotientRemainder()
          {
              int dividend, divisor, quotient, remainder;

              Console.Write("Enter the dividend: ");
              dividend = int.Parse(Console.ReadLine());

              Console.Write("Enter the divisor: ");
              divisor = int.Parse(Console.ReadLine());

              quotient = dividend / divisor;
              remainder = dividend % divisor;

              Console.WriteLine($"Quotient: {quotient}");
              Console.WriteLine($"Remainder: {remainder}");
          }
    }
}
