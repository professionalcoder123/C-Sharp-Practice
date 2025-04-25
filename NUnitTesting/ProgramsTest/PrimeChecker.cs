using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsTest
{
    public class PrimeChecker
    {
        public bool IsPrime(int num)
        {
            int temp = 0;
            for(int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    temp++;
                }
            }
            if (temp > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
