using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    internal class EmployeeDetails
    {
        public static void PrintEmployeeWithHighSalary()
        {
            Dictionary<string, int> employees = new Dictionary<string, int>();
            Console.WriteLine("Enter the number of key-value pairs to be added");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the name of an employee");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the salary of an employee");
                int salary = int.Parse(Console.ReadLine());
                employees.Add(name, salary);
            }
            int maxSalary = employees.Values.Max();
            Console.WriteLine();
            Console.WriteLine("Employee with highest salary :");
            foreach(var employee in employees)
            {
                if (employee.Value == maxSalary)
                {
                    Console.WriteLine($"{employee.Key} : {employee.Value}");
                }
            }
        }
    }
}