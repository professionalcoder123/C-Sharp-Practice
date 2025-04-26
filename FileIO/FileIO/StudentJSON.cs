using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FileIO
{
    internal class Student
    {
        public int Roll { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Percentage { get; set; }
    }

    internal class StudentJSON
    {
        public static void StoreStudentInformation()
        {
            var students = new List<Student>()
            {
                new Student{Roll=1,Name="Aditya",Age=10,Percentage=93.72},
                new Student{Roll=2,Name="Sohel",Age=14,Percentage=80.66},
                new Student{Roll=3,Name="Kedar",Age=9,Percentage=85.87}
            };
            string path = @"C:\Users\Aditya Turwatkar\Desktop\Aditya\New folder\C# Practice\FileIO\FileIO\StudentJSONFile.json";
            //File.Create(path);
            string json = JsonConvert.SerializeObject(students, Formatting.Indented);
            File.WriteAllText(path, json);
        }
    }
}