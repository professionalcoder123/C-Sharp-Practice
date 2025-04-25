using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    internal class TaskAwaitConfigure
    {
        public static async Task DoWorkAsync()
        {
            await Task.Delay(2000).ConfigureAwait(false);
            Console.WriteLine("Task done without capturing context!");
        } 
    }
}