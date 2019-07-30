﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_02_Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] words = Console.ReadLine().Split(' ');
            var counts = new Dictionary<string, int>();
            foreach (var word in words)
            {
                string lowerCase = word.ToLower();
                if (counts.ContainsKey(lowerCase))
                {
                    counts[lowerCase]++;
                }
                else
                {
                    counts.Add(lowerCase, 1);
                }
            }
            foreach (var count in counts)
            {
                if (count.Value % 2 == 1)
                {
                    Console.Write(count.Key + " ");
                }
            }

        }
    }
}
