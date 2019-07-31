namespace Exs_04_Add_VAT
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(x => x * 1.2)
                .ToList();
            input.ForEach(x => Console.WriteLine($"{x:F2}"));

        }
    }
}
