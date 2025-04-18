using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class SumOfRange
    {
        public static void CalculateSumOfRange()
        {
            Console.WriteLine("Enter the starting number");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the ending number");
            int end = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;
            for(int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    evenSum = evenSum + i;
                }
                else
                {
                    oddSum = oddSum + i;
                }
            }
            Console.WriteLine("Sum of range of even numbers is " + evenSum);
            Console.WriteLine("Sum of range of odd numbers is " + oddSum);
        }
    }
}