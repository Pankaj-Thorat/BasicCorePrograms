using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    class LeapYear
    {
        public static void CheckLeapYear()
        {
            //year input
            Console.WriteLine("Enter the Year:");
            int year = Convert.ToInt32(Console.ReadLine());
            //to check if input is valid 4 digit number
            while (year >9999 || year < 1000) 
            {
                Console.WriteLine("Please Enter Valid Year");
                year = Convert.ToInt32(Console.ReadLine());
            }     
            //to check leap year condition
            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0)) 
            {
                Console.WriteLine("{0} is a Leap Year",year);
            }
            else
            {
                Console.WriteLine("{0} is not a Leap Year",year);
            }

        }
    }
}
