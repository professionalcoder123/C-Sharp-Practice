using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class LetterIdentification
    {
        public static string CheckLetter()
        {
            Console.WriteLine("Enter a character");
            char ch = Console.ReadKey().KeyChar;
            Console.ReadLine();
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                return "Alphabet";
            }
            else if (ch >= '0' && ch <= '9')
            {
                return "Digit";
            }
            else
            {
                return "Special character";
            }
        }
    }
}