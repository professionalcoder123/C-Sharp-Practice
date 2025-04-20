using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class ThreadsDelayDemo
    {
        public static void PrintNumbers()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Number : {i}");
                Thread.Sleep(3000);
            }
        }

        public static void PrintLetters()
        {
            for(char i='A'; i <= 'Z'; i++)
            {
                Console.WriteLine($"Letter : {i}");
                Thread.Sleep(2000);
            }
        }

        public static void PrintMessage(object message)
        {
            Console.WriteLine(message);
        }
    }
}