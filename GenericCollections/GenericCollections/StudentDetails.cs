using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    internal class StudentDetails
    {
        public static void SortStudentsByName()
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            Console.WriteLine("Enter the number of key-value pairs to be added");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the roll number of student");
                int rollNo = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the name of the student");
                string name = Console.ReadLine();
                students.Add(rollNo, name);
            }
            var sortedStudents = students.OrderBy(d => d.Value);
            Console.WriteLine("Students sorted by names :");
            foreach(var student in sortedStudents)
            {
                Console.Write($"Roll No. : {student.Key}, Name : {student.Value}");
                Console.WriteLine();
            }
        }
    }
}