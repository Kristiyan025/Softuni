using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_07_Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isEqual = true;
            int sum = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    isEqual = false;
                    Console.WriteLine($"Arrays are not identical. " +
                                      $"Found difference at {i} index");
                    break;
                }
                sum += arr1[i];
            }
            if (isEqual)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }

        }
    }
}
