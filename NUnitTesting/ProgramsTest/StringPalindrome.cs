using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsTest
{
    public class StringPalindrome
    {
        public bool IsPalindrome(string str)
        {
            str = str.ToLower();
            string copy = str;
            string rev = "";
            for(int i = str.Length - 1; i >= 0; i--)
            {
                rev = rev + str[i];
            }
            if (rev == copy)
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
