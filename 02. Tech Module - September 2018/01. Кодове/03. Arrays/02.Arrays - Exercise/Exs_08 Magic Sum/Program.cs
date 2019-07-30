using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_08_Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = Console.ReadLine().Split(' ')
                                          .Select(int.Parse)
                                          .ToArray();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == n)
                    {                    
                        Console.WriteLine($"{arr[i]} {arr[j]}");                       
                    }
                }
            }

        }
    }
}
