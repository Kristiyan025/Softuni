namespace Exs_03_Student_System
{
    using System.Collections.Generic;
    using System.Linq;

    public class StudentSystem
    {

        private List<Student> students;

        public StudentSystem()
        {
            this.students = new List<Student>();
        }

        public void Add(Student student)
        {
            this.students.Add(student);
        }

        private Student FindByName(string name)
        {
            return students.First(x => x.Name == name);
        }

        public string Show(string name)
        {
            var student = this.FindByName(name);
            string studentDescription = $"{name} is {student.Age} years old.";
            if (student.Grade >= 5.00)
            {
                studentDescription += " Excellent student.";
            }
            else if (student.Grade < 5.00 && student.Grade >= 3.50)
            {
                studentDescription += " Average student.";
            }
            else
            {
                studentDescription += " Very nice person.";
            }
            return studentDescription;
        }

    }
}
