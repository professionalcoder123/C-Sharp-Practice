using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsTest
{
    public class AnagramChecker
    {
        public bool CheckAnagramsOrNot(string str1,string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }
            else
            {
                char[] arr1 = str1.ToLower().ToCharArray();
                char[] arr2 = str2.ToLower().ToCharArray();
                Array.Sort(arr1);
                Array.Sort(arr2);
                if(new string(arr1)==new string(arr2))
                {
                    return true;
                }
                return false;
            }
        }
    }
}
