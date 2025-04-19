using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class NumberString
    {
        public static void CheckDigitsInString()
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            int temp = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if (!char.IsDigit(str[i]))
                {
                    temp++;
                    break;
                }
            }
            if (temp>0)
            {
                Console.WriteLine("Invalid string");
            }
            else
            {
                Console.WriteLine("Valid string");
            }
        }
    }
}
