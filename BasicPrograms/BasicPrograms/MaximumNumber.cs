using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class MaximumNumber
    {
        public static void FindMaximum()
        {
            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("Two numbers are equal. Cannot find greater number!");
            }
            else
            {
                if (num1 > num2)
                {
                    Console.WriteLine("First number is greater");
                }
                else
                {
                    Console.WriteLine("Second number is greater");
                }
            }
        }
    }
}