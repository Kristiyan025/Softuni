namespace Exs_03_Custom_Min_Function
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToHashSet();
            Func<HashSet<int>, int> min = x => x.Min();
            Console.WriteLine(min(input));

        }
    }
}
