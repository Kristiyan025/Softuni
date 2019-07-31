namespace Exs_06_Company_Roster
{
    public class Employee
    {

        public string Name { get; set; }

        public double Salary { get; set; }

        public string Position { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public Employee(string name,double salary,string position, string email, int age)
        {
            Name = name;
            Salary = salary;
            Position = position;
            Email = email;
            Age = age;
        }

    }
}
