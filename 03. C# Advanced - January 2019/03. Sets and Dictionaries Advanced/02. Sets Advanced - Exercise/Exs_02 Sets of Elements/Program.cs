using System;
using System.Collections.Generic;
using System.Linq;

namespace Exs_02_Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {

            var dimenions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int n = dimenions[0];
            int m = dimenions[1];
            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                int p = int.Parse(Console.ReadLine());
                if (!firstSet.Contains(p))
                {
                    firstSet.Add(p);
                }
            }
            for (int i = 0; i < m; i++)
            {
                int p = int.Parse(Console.ReadLine());
                if (!secondSet.Contains(p))
                {
                    secondSet.Add(p);
                }
            }
            var set = new HashSet<int>();
            foreach (var i in firstSet)
            {
                if (secondSet.Contains(i))
                {
                    set.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ",set));

        }
    }
}
