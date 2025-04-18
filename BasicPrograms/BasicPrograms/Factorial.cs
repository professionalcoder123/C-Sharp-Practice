using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class Factorial
    {
        public static int FindFactorial()
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            for(int i = num; i >= 1; i--)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}