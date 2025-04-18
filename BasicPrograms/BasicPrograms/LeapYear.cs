using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class LeapYear
    {
        public static void CheckLeapYear()
        {
            Console.WriteLine("Enter a year");
            int year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("Entered year is a leap year");
            }
            else
            {
                Console.WriteLine("Entered year is not a leap year");
            }
        }
    }
}