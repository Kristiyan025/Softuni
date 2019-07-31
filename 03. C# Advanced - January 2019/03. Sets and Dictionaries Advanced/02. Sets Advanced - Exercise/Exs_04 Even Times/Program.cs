using System;
using System.Collections.Generic;
using System.Linq;

namespace Exs_04_Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {

            var dict = new Dictionary<int, int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int p = int.Parse(Console.ReadLine());
                if (!dict.ContainsKey(p))
                {
                    dict.Add(p, 1);
                }
                else
                {
                    dict[p]++;
                }
            }
            int chislo = dict.Where(x => x.Value % 2 == 0).Select(x => x.Key).First();
            Console.WriteLine(chislo);

        }
    }
}
