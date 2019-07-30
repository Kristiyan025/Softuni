using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_05_Students
{
    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var students = new List<Student>();
            while (true)
            {
                string student = Console.ReadLine();
                if(student == "end")
                {
                    break;
                }
                string[] properties = student.Split(' ').ToArray();
                students.Add(new Student
                {
                    FirstName = properties[0],
                    LastName = properties[1],
                    Age = int.Parse(properties[2]),
                    HomeTown = properties[3]
                });
            }
            string requestedHomeTown = Console.ReadLine();
            foreach (var student in students)
            {
                if (student.HomeTown == requestedHomeTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} " +
                                      $"is {student.Age} years old.");
                }
            }

        }
    }
}
