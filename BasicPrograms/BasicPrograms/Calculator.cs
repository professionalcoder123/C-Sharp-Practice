using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class Calculator
    {
        public static void Calculate()
        {
            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operation to perform :\n1. Addition\n" +
                "2. Subtraction\n3. Multiplication\n4. Division\n5. Modulus");
            int choice = int.Parse(Console.ReadLine());
            dynamic res = 0;
            switch (choice)
            {
                case 1:
                    res = num1 + num2;
                    break;
                case 2:
                    res = num1 - num2;
                    break;
                case 3:
                    res = num1 * num2;
                    break;
                case 4:
                    res = num1 / num2;
                    break;
                case 5:
                    res = num1 % num2;
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please enter valid choice.");
                    break;
            }
            Console.WriteLine("Result of the following operation is " + res);
        }
    }
}