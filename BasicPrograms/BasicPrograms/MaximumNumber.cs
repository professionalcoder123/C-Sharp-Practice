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
            Console.WriteLine("Enter third number");
            int num3 = int.Parse(Console.ReadLine());
            if ((num1 == num2)&&(num2==num3)&&(num1==num3))
            {
                Console.WriteLine("All the three numbers are equal. Cannot find greater number!");
            }
            else
            {
                if ((num1 > num2) && (num1 > num3))
                {
                    Console.WriteLine("First number is greater");
                }
                else if ((num2 > num1) && (num2 > num3))
                {
                    Console.WriteLine("Second number is greater");
                }
                else
                {
                    Console.WriteLine("Third number is greater");
                }
            }
        }
    }
}