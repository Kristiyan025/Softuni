namespace Exs_04_Find_Evens_or_Odds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            var boundRange = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int down = boundRange[0];
            int up = boundRange[1];
            string type = Console.ReadLine();
            var numbers = new List<int>();
            for (int i = down; i <= up; i++)
            {
                numbers.Add(i);
            }
            Predicate<int> predicate = x => type == "odd" ? x % 2 != 0 : x % 2 == 0;
            Console.WriteLine(string.Join(" ", numbers.Where(x => predicate(x))));

        }
    }
}
