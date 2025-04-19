using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class LongestWord
    {
        public static void FindLongestWord()
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            string[] strArray = str.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string longestWord = "";
            foreach(string word in strArray)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }
            Console.WriteLine("Longest string in a given string is " + "\'" + longestWord + "\'");
        }
    }
}