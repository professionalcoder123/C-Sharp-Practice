using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class WordCount
    {
        public static void CountWords()
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            string[] strArr = str.Split(" ",StringSplitOptions.RemoveEmptyEntries);
            int count = strArr.Length;
            Console.WriteLine("Total number of words in a string are " + count);
        }
    }
}