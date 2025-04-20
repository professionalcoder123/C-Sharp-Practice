using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class DeadlockDemo
    {
        static object lockA = new object();
        static object lockB = new object();
        
        public static void Thread1()
        {
            lock (lockA)
            {
                Console.WriteLine("Thread1 locked A");
                Thread.Sleep(1000);
                lock (lockB)
                {
                    Console.WriteLine("Thread1 locked B");
                }
            }
        }

        public static void Thread2()
        {
            lock (lockB)
            {
                Console.WriteLine("Thread2 locked B");
                Thread.Sleep(1000);
                lock (lockA)
                {
                    Console.WriteLine("Thread2 locked A");
                }
            }
        }
    }
}
