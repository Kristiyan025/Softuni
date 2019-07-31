using System;
using System.Collections.Generic;
using System.Linq;

namespace Exs_02_Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var data = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                var student = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = student[0];
                double note = double.Parse(student[1]);
                if (!data.ContainsKey(name))
                {
                    data.Add(name, new List<double> { note });
                }
                else
                {
                    data[name].Add(note);
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine,data
             .Select(x => $"{x.Key} -> {string.Join(" ", x.Value.Select(y=>y.ToString("0.00")))} (avg: {x.Value.Average():F2})")));

        }
    }
}
