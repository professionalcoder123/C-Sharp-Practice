using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class AgeFormat
    {
        public static void HandleFormatException()
        {
            try
            {
                Console.WriteLine("Enter an age");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Age of a person is " + age);
            }
            catch(FormatException e)
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