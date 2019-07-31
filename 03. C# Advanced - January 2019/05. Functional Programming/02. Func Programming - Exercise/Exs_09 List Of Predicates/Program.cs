namespace Exs_09_List_Of_Predicates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var divisors = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderBy(x => x)
                .ToList();
            var numbers = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                numbers.Add(i);
            }
            foreach (var divisor in divisors)
            {
                numbers = numbers.Where(x => x % divisor == 0).ToList();
            }
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
