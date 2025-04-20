using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message) { }
    }

    internal class InvalidAge
    {
        public static void HandleException()
        {
            try
            {
                Console.WriteLine("Enter the age");
                int age = int.Parse(Console.ReadLine());
                if (age < 18)
                {
                    throw new InvalidAgeException("Cannot input age less than 18!");
                }
                else
                {
                    Console.WriteLine("Age is valid!");
                }
            }
            catch(InvalidAgeException e)
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