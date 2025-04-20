using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class MarksOutOfBoundsException : Exception
    {
        public MarksOutOfBoundsException(string message) : base(message) { }
    }

    internal class StudentMarksValidation
    {
        public static void HandleMarksOutOfBoundsException()
        {
            try
            {
                Console.WriteLine("Enter the marks in English");
                double english = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the marks in Maths");
                double maths = double.Parse(Console.ReadLine());
                if ((english >= 0 && english <= 100) && (maths >= 0 && maths <= 100))
                {
                    double totalMarks = english + maths;
                    double percentage = totalMarks / 2;
                    Console.WriteLine("Your percentage : " + percentage);
                    if (percentage >= 80 && percentage <= 100)
                    {
                        Console.WriteLine("Congrats! You have achieved grade A.");
                    }
                    else if (percentage >= 60 && percentage <= 79)
                    {
                        Console.WriteLine("Grade B! You have passed with distinction.");
                    }
                    else if (percentage >= 40 && percentage <= 59)
                    {
                        Console.WriteLine("You have got grade C. You need to work hard.");
                    }
                    else if (percentage >= 35 && percentage <= 39)
                    {
                        Console.WriteLine("You have just passed with grade D. You need to work very hard.");
                    }
                    else
                    {
                        Console.WriteLine("Grade E. You have failed!");
                    }
                }
                else
                {
                    throw new MarksOutOfBoundsException("Marks should be between 0 to 100!");
                }
            }
            catch(MarksOutOfBoundsException e)
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