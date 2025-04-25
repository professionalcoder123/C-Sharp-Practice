using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsTest
{
    public class NumberReverse
    {
        public int ReverseNumber(int num)
        {
            num = Math.Abs(num);
            int rev = 0;
            while (num != 0)
            {
                int digit = num % 10;
                rev = rev * 10 + digit;
                num = num / 10;
            }
            return rev;
        }
    }
}
