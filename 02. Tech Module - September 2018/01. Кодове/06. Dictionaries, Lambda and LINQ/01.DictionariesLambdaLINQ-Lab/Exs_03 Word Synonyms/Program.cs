using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_03_Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!dict.ContainsKey(word))
                {
                    dict.Add(word, new List<string>());
                }
                dict[word].Add(synonym);
            }
            foreach (var w in dict)
            {
                Console.WriteLine(w.Key + " - " + string.Join(", ", w.Value));
            }

        }
    }
}
