namespace Exs_06_Reverse_And_Exclude
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
            int divisor = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(" ", numbers.Where(x => x % divisor != 0).Reverse()));

        }
    }
}
