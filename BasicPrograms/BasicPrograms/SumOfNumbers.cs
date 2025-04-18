using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class SumOfNumbers
    {
        public static void PrintSum()
        {
            Console.WriteLine("Enter the value of 'n' upto which you want the sum");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Sum of first 'N' natural numbers is " + sum);
        }
    }
}
