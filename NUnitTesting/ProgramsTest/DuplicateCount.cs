using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsTest
{
    public class DuplicateCount
    {
        public int CountDuplicates(string str)
        {
            str = str.ToLower();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            int count = 0;
            foreach(char ch in str)
            {
                if (!dict.ContainsKey(ch))
                {
                    dict.Add(ch, 1);
                }
                else
                {
                    count++;
                }
            }
            return count;
        }
    }
}
