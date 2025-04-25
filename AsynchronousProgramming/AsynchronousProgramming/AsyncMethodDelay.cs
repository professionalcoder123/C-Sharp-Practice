using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    internal class AsyncMethodDelay
    {
        public static async Task Method1()
        {
            await Task.Delay(1000);
            Console.WriteLine("Method 1 completed successfully!");
        }

        public static async Task Method2()
        {
            await Task.Delay(1000);
            Console.WriteLine("Method 2 completed successfully!");
        }

        public static async Task Method3()
        {
            await Task.Delay(1000);
            Console.WriteLine("Method 3 completed successfully!");
        }
    }
}
