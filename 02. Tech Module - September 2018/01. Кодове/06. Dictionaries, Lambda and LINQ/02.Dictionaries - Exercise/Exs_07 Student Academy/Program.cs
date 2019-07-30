using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_07_Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var database = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (database.ContainsKey(name))
                {
                    database[name].Add(grade);
                }
                else
                {
                    List<double> temporary = new List<double>();
                    temporary.Add(grade);
                    database.Add(name, temporary);
                }
            }
            database = database.Where(x => x.Value.Average() >= 4.50)
              .OrderByDescending(x => x.Value.Average()).ToDictionary(x => x.Key, x => x.Value);
            foreach (var data in database)
            {
                Console.WriteLine($"{data.Key} -> {data.Value.Average():F2}");
            }

        }
    }
}
