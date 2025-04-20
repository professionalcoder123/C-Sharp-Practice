using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class ThreadPriorityDemo
    {
        public static void PrintA()
        {
            for(int i = 1; i <= 50; i++)
            {
                Console.WriteLine("A = " + i);
            }
        }

        public static void PrintB()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("B = " + i);
            }
        }

        public static void PrintC()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("C = " + i);
            }
        }
    }
}
