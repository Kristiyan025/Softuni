using System;
using System.Collections.Generic;

namespace Exs_05_Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var set = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                set.Add(Console.ReadLine());
            }
            foreach (var name in set)
            {
                Console.WriteLine(name);
            }
        }
    }
}
