using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    internal class AsyncNonAsyncDifference
    {
        public static async Task PrintMessageAsync()
        {
            await Task.Delay(1000);
            Console.WriteLine("Message from async!");
        }
    }
}
