using System;
using System.Collections.Generic;
using System.Linq;

namespace Exs_01_Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {

            var database = new Dictionary<double, int>();
            var input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            foreach (var d in input)
            {
                if (!database.ContainsKey(d))
                {
                    database.Add(d, 1);
                }
                else
                {
                    database[d]++;
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine,
                database.Select(x => $"{x.Key} - {x.Value} times")));

        }
    }
}
