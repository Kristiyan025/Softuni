namespace Exs_03_Count_Uppercase_Words
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(x => char.IsUpper(x[0]))
                .ToList();
            input.ForEach(x => Console.WriteLine(x));

        }
    }
}
