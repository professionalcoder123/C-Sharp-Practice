using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsTest
{
    public class EvenOddChecker
    {
        public string TellEvenOrOdd(int num)
        {
            if (num % 2 == 0)
            {
                return "Even number";
            }
            else
            {
                return "Odd number";
            }
        }
    }
}