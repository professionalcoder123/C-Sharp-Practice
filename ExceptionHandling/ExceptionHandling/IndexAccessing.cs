using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class IndexAccessing
    {
        public static void HandleIndexException()
        {
            try
            {
                int[] arr = new int[] { 1, 2, 3, 4, 5 };
                Console.WriteLine(arr[10]);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Execution completed successfully!");
            }
        }
    }
}