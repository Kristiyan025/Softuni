using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_04_Students
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string student = Console.ReadLine();
                string[] info = student.Split(' ').ToArray();
                string fName = info[0];
                string lName = info[1];
                float grade = float.Parse(info[2]);
                students.Add(new Student(fName, lName, grade));
            }
            students = students.OrderByDescending(x => x.Grade).ToList();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
            }

        }
    }

    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public float Grade { get; set; }

        public Student(string fName, string lName, float grade)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Grade = grade;
        }
    }
}
