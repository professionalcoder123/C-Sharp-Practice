using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class EvenOddChecker
    {
        public static string CheckEvenOrOdd()
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                return "Even number";
            }
            else
            {
                return "Odd number";
            }
        }
    }
}
