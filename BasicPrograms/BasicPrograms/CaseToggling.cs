using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class CaseToggling
    {
        public static string ToggleCase()
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            string result = "";
            for(int i = 0; i < str.Length; i++)
            {
                if (char.IsLower(str[i]))
                {
                    result += char.ToUpper(str[i]);
                }
                else
                {
                    result += char.ToLower(str[i]);
                }
            }
            return result;
        }
    }
}
