using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    internal class StudentNames
    {
        public static void SortStudents()
        {
            SortedList<string, int> students = new SortedList<string, int>();
            Console.WriteLine("Enter the number of key-value pairs to be added");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the name of a student");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the marks of a student");
                int marks = int.Parse(Console.ReadLine());
                students.Add(name, marks);
            }
            Console.WriteLine();
            Console.WriteLine("Sorted students :");
            foreach(var student in students)
            {
                Console.Write($"Student Name : {student.Key}, Marks : {student.Value}");
                Console.WriteLine();
            }
        }
    }
}