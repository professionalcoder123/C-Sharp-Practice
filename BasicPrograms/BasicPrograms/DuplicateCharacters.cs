using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class DuplicateCharacters
    {
        public static void RemoveDuplicates()
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            str = str.ToLower();
            string result = "";
            Dictionary<char, int> dict = new Dictionary<char, int>();
            Console.Write("Resultant string without duplicates : ");
            foreach(char ch in str)
            {
                if (!dict.ContainsKey(ch))
                {
                    dict[ch] = 1;
                    result = result + ch;
                }
            }
            Console.WriteLine(result);
        }
    }
}