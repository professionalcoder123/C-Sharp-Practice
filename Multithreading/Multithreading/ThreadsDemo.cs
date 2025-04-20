using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class ThreadsDemo
    {
        public static void Func1()
        {
            for(int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Func 1 = " + i);
            }
        }

        public static void Func2()
        {
            for(int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Func 2 = " + i);
            }
        }

        public static void Func3()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Func 3 = " + i);
            }
        }
    }
}