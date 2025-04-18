using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class NumberOfDigits
    {
        public static void PrintNumberOfDigits()
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            while (num != 0)
            {
                int digit = num % 10;
                num = num / 10;
                count++;
            }
            Console.WriteLine("Number of digits in a number are " + count);
        }
    }
}
