using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class NullString
    {
        public static void HandleNullReferenceException()
        {
            try
            {
                string str = null;
                Console.WriteLine(str.Length);
            }
            catch(NullReferenceException e)
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