using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class NumberDivisibility
    {
        public static bool CheckDivisibility()
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            if (num % 5 == 0 && num % 11 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}