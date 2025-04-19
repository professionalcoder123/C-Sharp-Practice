using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class Anagram
    {
        public static void CheckAnagram()
        {
            Console.WriteLine("Enter first string");
            string str1 = Console.ReadLine();
            str1 = str1.ToLower();
            Console.WriteLine("Enter second string");
            string str2 = Console.ReadLine();
            str2 = str2.ToLower();
            if (str1.Length == str2.Length)
            {
                char[] arr1 = str1.ToLower().ToCharArray();
                char[] arr2 = str2.ToLower().ToCharArray();
                Array.Sort(arr1);
                Array.Sort(arr2);
                if(new string(arr1)==new string(arr2))
                {
                    Console.WriteLine("Both the strings are anagrams of ecah other");
                }
                else
                {
                    Console.WriteLine("The strings are not anagrams of each other");
                }
            }
            else
            {
                Console.WriteLine("The strings are not anagrams of each other");
            }
        }
    }
}
