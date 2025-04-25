using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsTest
{
    public class NonDuplicateString
    {
        public string ReturnNonDuplicateString(string str)
        {
            str = str.ToLower();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            StringBuilder newStr = new StringBuilder();
            foreach(char ch in str)
            {
                if (!dict.ContainsKey(ch))
                {
                    dict.Add(ch, 1);
                    newStr.Append(ch);
                }
            }
            return newStr.ToString();
        }
    }
}
