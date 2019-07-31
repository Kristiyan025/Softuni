namespace Exs_02_Sum_Numbers
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
                .Select(int.Parse)
                .ToList();
            Console.WriteLine(input.Count);
            Console.WriteLine(input.Sum());

        }
    }
}
