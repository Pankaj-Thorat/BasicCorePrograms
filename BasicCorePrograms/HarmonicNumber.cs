using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    class HarmonicNumber
    {
        
        public static void CalculateHarmonicNumber()
        { 
            int i, n;
            double sum = 0.0;
            //input from user 
            Console.WriteLine("Enter the Number of terms");
            n = Convert.ToInt32(Console.ReadLine());
            //logic for addition of harmonic number
            for (i = 1; i <= n; i++)
            {
                sum += 1 /(float)i;
            }
            Console.WriteLine("Sum of {0} Harmonic Numbers is {1}",n,sum);
        }
    }
}
