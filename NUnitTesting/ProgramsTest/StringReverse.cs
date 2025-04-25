using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsTest
{
    public class StringReverse
    {
        public string ReverseString(string str)
        {
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
