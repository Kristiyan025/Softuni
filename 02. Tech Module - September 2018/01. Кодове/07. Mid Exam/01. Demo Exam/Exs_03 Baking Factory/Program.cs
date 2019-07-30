using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_03_Baking_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> breads = new List<string>();
            while (true)
            {
                string batches = Console.ReadLine();
                if (batches == "Bake It!")
                {
                    break;
                }
                breads.Add(batches);
            }
            List<int> counts = new List<int>();
            List<int> qualities = new List<int>();
            List<decimal> averages = new List<decimal>();
            for (int i = breads.Count - 1; i >= 0; i--)
            {
                List<int> quality = breads[i].Split('#').Select(int.Parse).ToList();
                counts.Insert(0, quality.Count());
                qualities.Insert(0,quality.Sum());
                decimal average = quality.Sum() / quality.Count();
                averages.Insert(0, average);
            }
            Console.WriteLine($"Best Batch quality: {qualities.Max()}");
            List<int> c = new List<int>();
            for (int i = qualities.Count() - 1; i >= 0; i--)
            {
                if (qualities[i] == qualities.Max())
                {
                    c.Insert(0, i);
                }
            }
            int max = c[0];
            for (int i = 1; i < c.Count(); i++)
            {
                if(averages[c[i]] > averages[max])
                {
                    c.RemoveAt(c.IndexOf(max));
                    i--;
                    max = c[i];
                    continue;
                }
                if(averages[c[i]] < averages[max])
                {
                    c.RemoveAt(i);
                    i--;
                }
            }
            max = c[0];
            for (int i = 1; i < c.Count(); i++)
            {
                if (counts[c[i]] < counts[max])
                {
                    max = c[i];
                }
            }
            Console.WriteLine(string.Join(" ",breads[max].Split('#').Select(int.Parse).ToList()));
            
        }
    }
}
