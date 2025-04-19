using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class CharacterFrequency
    {
        public static void FindFrequency()
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            str = str.ToLower();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach(char ch in str)
            {
                if (!dict.ContainsKey(ch))
                {
                    dict[ch] = 1;
                }
                else
                {
                    dict[ch]++;
                }
            }
            foreach(var pair in dict)
            {
                Console.WriteLine(pair.Key + " : " + pair.Value);
            }
        }
    }
}
