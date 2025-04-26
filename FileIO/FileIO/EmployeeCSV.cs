using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;

namespace FileIO
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }

    internal class EmployeeCSV
    {
        public static void StoreEmployeeInformation()
        {
            var employees = new List<Employee>()
            {
                new Employee{ Id=101, Name="Aditya", Salary=25000 },
                new Employee{ Id=102, Name="Rahul", Salary=22500 },
                new Employee{ Id=103, Name="Pratik", Salary=24000 }
            };
            string path = @"C:\Users\Aditya Turwatkar\Desktop\Aditya\New folder\C# Practice\FileIO\FileIO\EmployeeCSVFile.csv";
            File.Create(path);
            Console.WriteLine("Created file!");
            using (var writer=new StreamWriter(path))
            using(var csvWriter=new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvWriter.WriteRecords(employees);
            }
        }
    }
}