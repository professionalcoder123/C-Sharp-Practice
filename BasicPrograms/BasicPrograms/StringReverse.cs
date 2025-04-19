using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class StringReverse
    {
        public static string ReverseString()
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            str = str.ToLower();
            string rev = "";
            for(int i = str.Length - 1; i >= 0; i--)
            {
                rev = rev + str[i];
            }
            return rev;
        }
    }
}