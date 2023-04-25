using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    class PrimeFactor
    {
         public int[] GetPrimeFactors(int num)
         {

               int[] factors = new int[num];
               int index = 0;
               int divisor = 2;
            
               while (num > 1)
               {
                   if (num % divisor == 0)
                   {
                       factors[index++] = divisor;
                       num /= divisor;
                   }
                   else
                   {
                       divisor++;
                   }
               }

               int[] primeFactors = new int[index];
               for (int i = 0; i < index; i++)
               {
                   primeFactors[i] = factors[i];
               }
            
              return primeFactors;
         }


    }
}



