using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    internal class NonAsyncMethod
    {
        public static Task<string> NotAsync()
        {
            return Task.FromResult("Hello!");
        }
    }
}