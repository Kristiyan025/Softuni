using System;
using System.Collections.Generic;

namespace Exs_05_Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = Console.ReadLine();
            var dic = new SortedDictionary<char, int>();
            foreach (var ch in s)
            {
                if (!dic.ContainsKey(ch))
                {
                    dic.Add(ch, 1);
                }
                else
                {
                    dic[ch]++;
                }
            }
            foreach (var symbol in dic)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }

        }
    }
}
