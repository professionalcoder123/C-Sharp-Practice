using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class NumberDivision
    {
        public static void HandleDivisionException()
        {
            try
            {
                Console.WriteLine("Enter first number");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                int num2 = int.Parse(Console.ReadLine());
                double res = num1 / num2;
                Console.WriteLine("Division of numbers is " + res);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Execution completed successfully!");
            }
        }
    }
}