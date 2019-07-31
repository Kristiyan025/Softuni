namespace Exs_03_Student_System
{
    using System.Linq;

    public class CommandParser
    {

        public Command GetCommand(string input)
        {
            var parts = input.Split();

            string type = parts[0];
            var arguments = parts.Skip(1).ToArray();
            return new Command(type, arguments);
        }

        public Student GetStudent(string[] arguments)
        {
            string name = arguments[0];
            int age = int.Parse(arguments[1]);
            double grade = double.Parse(arguments[2]);
            return new Student(name, age, grade);
        }

    }
}
