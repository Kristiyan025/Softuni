namespace Exs_08_Custom_Comparator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            Console.Write(string.Join(" ", numbers.Where(x => x % 2 == 0).OrderBy(x => x)) + " ");
            Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0).OrderBy(x => x)));

        }
    }
}
