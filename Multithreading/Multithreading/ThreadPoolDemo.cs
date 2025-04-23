using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class ThreadPoolDemo
    {
        public static void WorkItem1(object state)
        {
            Console.WriteLine($"WorkItem1 : {state}");
        }

        public static void WorkItem2(object state)
        {
            int num = (int)state;
            int square = num * num;
            Console.WriteLine($"WorkItem2 : {square}");
        }
    }
}