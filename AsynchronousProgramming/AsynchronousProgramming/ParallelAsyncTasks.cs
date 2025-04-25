using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    internal class ParallelAsyncTasks
    {
        public static async Task<string> TaskA()
        {
            await Task.Delay(1000);
            return "Task A done!";
        }

        public static async Task<string> TaskB()
        {
            await Task.Delay(2000);
            return "Task B done!";
        }

        public static async Task<string> TaskC()
        {
            await Task.Delay(3000);
            return "Task C done!";
        }
    }
}
