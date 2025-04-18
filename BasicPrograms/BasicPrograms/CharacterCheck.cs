using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class CharacterCheck
    {
        public static string CheckCharacter()
        {
            Console.WriteLine("Enter a character");
            char ch = Console.ReadKey().KeyChar;
            Console.ReadLine();
            if ((ch == 'a' || ch == 'A') || (ch == 'e' || ch == 'E') || (ch == 'i' || ch == 'I') || (ch == 'o' || ch == 'O') || (ch == 'u' || ch == 'U'))
            {
                return "Vowel";
            }
            else
            {
                return "Consonant";
            }
        }
    }
}