using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public delegate void MyDelegate(int a, int b);

    internal class AdditionOperation
    {
        public static void Add(int x, int y)
        {
            Console.WriteLine("Addition is " + (x + y));
        }
    }
}