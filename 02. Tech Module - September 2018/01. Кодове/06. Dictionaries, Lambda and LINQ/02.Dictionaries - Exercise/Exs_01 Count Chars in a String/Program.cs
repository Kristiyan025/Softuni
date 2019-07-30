using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_01_Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {

            string word = Console.ReadLine();
            var counts = new Dictionary<char, int>();
            foreach (var let in word)
            {
                if (let != ' ')
                {
                    if (counts.ContainsKey(let))
                    {
                        counts[let]++;
                    }
                    else
                    {
                        counts.Add(let, 1);
                    }
                }
            }
            foreach (var count in counts)
            {
                Console.WriteLine(count.Key + " -> " + count.Value);
            }

        }
    }
}
