using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class GradeSystem
    {
        public static void GetGrade()
        {
            Console.WriteLine("Enter the marks in English");
            double english = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the marks in Physics");
            double physics = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the marks in Chemistry");
            double chemistry = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the marks in Mathematics");
            double maths = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the marks in Biology");
            double biology = double.Parse(Console.ReadLine());
            double totalMarks = english + physics + chemistry + maths + biology;
            double percentage = totalMarks / 5;
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
    }
}