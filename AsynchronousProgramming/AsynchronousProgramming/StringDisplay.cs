using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    internal class StringDisplay
    {
        public static async Task<string> ReturnString(string str)
        {
            await Task.Delay(3000);
            return "Your string is \'" + str + "\'";
        }
    }
}
