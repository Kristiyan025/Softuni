using System;
using System.Collections.Generic;

namespace Exs_03_Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {

            var set = new SortedSet<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                foreach (var element in input)
                {
                    set.Add(element);
                }
            }
            Console.WriteLine(string.Join(" ", set));
        }
    }
}
