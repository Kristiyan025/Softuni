namespace Exs_02_Knights_of_Honor
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Action<string> print = x => Console.WriteLine($"Sir {x}");
            input.ForEach(print);

        }
    }
}
