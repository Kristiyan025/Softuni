using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_05_Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = Console.ReadLine().Split(' ')
                      .Select(int.Parse)
                      .ToArray();
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine(sum);

        }
    }
}
