using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class NumberIdentification
    {
        public static string CheckNumber()
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                return "Negative number";
            }
            else if (num > 0)
            {
                return "Positive number";
            }
            else
            {
                return "Zero";
            }
        }
    }
}