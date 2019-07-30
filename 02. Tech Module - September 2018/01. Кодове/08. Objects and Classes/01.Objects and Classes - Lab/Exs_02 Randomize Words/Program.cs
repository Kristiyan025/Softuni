using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_02_Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            List<int> index = new List<int>();
            for (int i = 0; i < words.Length; i++)
            {
                index.Add(i);
            }
            Random r = new Random();
            int count = index.Count();
            for (int i = 0; i < words.Length; i++)
            {
                int j = r.Next(count);
                string x = words[i];
                words[i] = words[j];
                words[j] = x;
                count--;
            }
            Console.WriteLine(string.Join(Environment.NewLine, words));

        }
    }
}
