using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_01_Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var counts = new SortedDictionary<int, int>();
            foreach (var num in nums)
                if (counts.ContainsKey(num))
                    counts[num]++;
                else
                    counts[num] = 1;
            foreach (var num in counts)
                Console.WriteLine($"{num.Key} -> {num.Value}");

        }
    }
}
