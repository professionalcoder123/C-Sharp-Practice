using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class NumberSubtraction
    {
        public static void SubtractNumbers()
        {
            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number");
            int num3 = int.Parse(Console.ReadLine());
            int num4 = num1 - num2 - num3;
            Console.WriteLine("Subtraction of numbers is " + num4);
        }
    }
}
