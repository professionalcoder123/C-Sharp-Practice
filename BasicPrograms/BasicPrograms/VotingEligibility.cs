using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class VotingEligibility
    {
        public static void CheckEligibility()
        {
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("You are not eligible to vote");
            }
            else
            {
                Console.WriteLine("You are eligible to vote");
            }
        }
    }
}