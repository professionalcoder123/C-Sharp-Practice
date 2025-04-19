using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class StringPalindrome
    {
        public static bool IsPalindrome()
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            str = str.ToLower();
            string copy = str;
            string rev = "";
            for(int i = str.Length - 1; i >= 0; i--)
            {
                rev = rev + str[i];
            }
            if (copy == rev)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
