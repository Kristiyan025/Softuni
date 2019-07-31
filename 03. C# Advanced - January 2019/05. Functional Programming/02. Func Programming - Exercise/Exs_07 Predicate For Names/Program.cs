namespace Exs_07_Predicate_For_Names
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var names = Console.ReadLine()
                .Split()
                .Where(x => x.Count() <= n)
                .ToList();
            Console.WriteLine(string.Join(Environment.NewLine, names));
            
        }
    }
}
