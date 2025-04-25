using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    internal class DataDisplay
    {
        public static async Task<string> GetDataAsync()
        {
            await Task.Delay(3000);
            return "Data fetched successfully!";
        }

        public static async Task DisplayDataAsync()
        {
            Console.WriteLine("Fetching data...");
            string data = await GetDataAsync();
            Console.WriteLine(data);
        }
    }
}
