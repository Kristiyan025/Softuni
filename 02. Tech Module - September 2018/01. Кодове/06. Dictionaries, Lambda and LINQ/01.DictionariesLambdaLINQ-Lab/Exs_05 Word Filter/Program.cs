using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_05_Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> words = Console.ReadLine().Split(' ').ToList();
            var dict = new Dictionary<string, int>();
            foreach (var w in words)
            {
                int count = w.Length;
                if (count % 2 == 0)
                {
                    dict.Add(w, count);
                }
            }
            foreach (var w in dict)
            {
                Console.WriteLine(w.Key + " ");
            }

        }
    }
}
