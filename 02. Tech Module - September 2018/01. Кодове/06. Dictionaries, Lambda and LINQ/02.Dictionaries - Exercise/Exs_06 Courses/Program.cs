using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_06_Courses
{
    class Program
    {
        static void Main(string[] args)
        {

            var database = new Dictionary<string, List<string>>();
            while (true)
            {
                string info = Console.ReadLine();
                if (info == "end")
                {
                    break;
                }
                string[] parts = info.Split(':');
                string course = parts[0].Remove(parts[0].Length - 1);
                string student = parts[1].Remove(0, 1);
                if (database.ContainsKey(course))
                {
                    database[course].Add(student);
                }
                else
                {
                    List<string> students = new List<string>();
                    students.Add(student);
                    database.Add(course, students);
                }
            }
            database = database.OrderByDescending(n => n.Value.Count)
                               .ToDictionary(n=> n.Key,n => n.Value);
            foreach (var data in database)
            {
                Console.WriteLine($"{data.Key}: {data.Value.Count}");
                data.Value.Sort();
                foreach (var name in data.Value)
                {
                    Console.WriteLine($"-- {name}");
                }
            }

        }
    }
}
