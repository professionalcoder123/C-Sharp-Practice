using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class ThreadPerformanceDemo
    {
        public static void IncrementCounter1()
        {
            long count = 0;
            for(int i = 1; i <= 1000000000; i++)
            {
                count++;
            }
            Console.WriteLine($"IncrementCounter1 : {count}");
        }

        public static void IncrementCounter2()
        {
            long count = 0;
            for (int i = 1; i <= 1000000000; i++)
            {
                count++;
            }
            Console.WriteLine($"IncrementCounter2 : {count}");
        }
    }
}
