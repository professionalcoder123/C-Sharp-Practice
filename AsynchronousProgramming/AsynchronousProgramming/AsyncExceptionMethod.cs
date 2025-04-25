using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    internal class AsyncExceptionMethod
    {
        public static async Task<string> MightThrowAsync(bool shouldThrow)
        {
            await Task.Delay(1000);
            if (shouldThrow)
            {
                throw new Exception("Something went wrong!");
            }
            return "All good!";
        }
    }
}