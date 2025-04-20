using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class WeakPasswordException : Exception
    {
        public WeakPasswordException(string message) : base(message) { }
    }

    internal class PasswordCheck
    {
        public static void HandlePasswordException()
        {
            try
            {
                Console.WriteLine("Enter the password");
                string password = Console.ReadLine();
                if (password.Length < 6)
                {
                    throw new WeakPasswordException("Length of password should be greater than or equal to 6!");
                }
                else
                {
                    for(int i = 0; i < password.Length; i++)
                    {
                        if (!char.IsDigit(password[i]))
                        {
                                throw new WeakPasswordException("Password should contain digits in it!");
                        }
                        else
                        {
                            Console.WriteLine("Password accepted successfully!");
                        }
                    }
                }
            }
            catch(WeakPasswordException e)
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