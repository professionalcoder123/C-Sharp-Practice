using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public delegate void Calculate(int num1, int num2);

    internal class Calculator
    {
        public static void Add(int num1,int num2)
        {
            Console.WriteLine("Addition is " + (num1 + num2));
        }

        public static void Subtract(int num1,int num2)
        {
            Console.WriteLine("Subtraction is " + (num1 - num2));
        }

        public static void Multiply(int num1,int num2)
        {
            Console.WriteLine("Multiplication is " + (num1 * num2));
        }

        public static void Divide(int num1, int num2)
        {
            Console.WriteLine("Division is " + (num1 / num2));
        }

        public static void PerformCalculation(Calculate calc, int x, int y)
        {
            calc(x, y);
        }
    }
}