using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_06_Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = Console.ReadLine().Split(' ')
                                          .Select(int.Parse)
                                          .ToArray();
            int sum1 = 0;
            int sum2 = 0;
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum1 += arr[i];
                }
                else
                {
                    sum2 += arr[i];
                }
            }
            result = sum1 - sum2;
            Console.WriteLine(result);

        }
    }
}
