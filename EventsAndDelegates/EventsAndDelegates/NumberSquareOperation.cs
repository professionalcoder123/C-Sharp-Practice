using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public delegate int PerformSquare(int x);

    internal class NumberSquareOperation
    {
        public static int FindSquare(int num)
        {
            PerformSquare square = num => num * num;
            return square(num);
        }
    }
}