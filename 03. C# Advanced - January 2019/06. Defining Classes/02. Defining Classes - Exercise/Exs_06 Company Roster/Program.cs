namespace Exs_06_Company_Roster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            var info = new Dictionary<string,List<Employee>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var inputParts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = inputParts[0];
                double salary = double.Parse(inputParts[1]);
                string position = inputParts[2];
                string department = inputParts[3];
                string email = "n/a";
                int age = -1;
                if (inputParts.Length >= 5)
                {
                    email = inputParts[4];
                    if (inputParts.Length == 6)
                    {
                        age = int.Parse(inputParts[5]);
                    }
                }
                if (!info.ContainsKey(department))
                {
                    info.Add(department, new List<Employee>());
                }
                else
                {
                    info[department] = new List<Employee>();
                }
            }
            var best = info.OrderByDescending(x => x.Value.Select(y => y.Salary).Average()).First();

            Console.WriteLine($"Hightest Avarage Salary: {best.Key}");
            foreach (var employee in best.Value.OrderByDescending(x => x.Salary).ToList())
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2} {employee.Email} {employee.Age}");
            }

        }
    }
}
