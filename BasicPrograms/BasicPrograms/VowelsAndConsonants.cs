using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class VowelsAndConsonants
    {
        public static void CountVowelsAndConsonants()
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            int vowels = 0;
            int consonants = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if ((str[i] == 'a' || str[i] == 'A') || (str[i] == 'e' || str[i] == 'E') || (str[i] == 'i' || str[i] == 'I') || (str[i] == 'o' || str[i] == 'O') || (str[i] == 'u' || str[i] == 'U'))
                {
                    vowels++;
                }
                else
                {
                    consonants++;
                }
            }
            Console.WriteLine("Total number of vowels in a string : " + vowels + "\n" +
                "Total number of consonants in a string : " + consonants);
        }
    }
}
