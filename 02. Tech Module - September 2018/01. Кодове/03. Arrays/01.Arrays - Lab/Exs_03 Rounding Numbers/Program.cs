using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_03_Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] arr = Console.ReadLine().Split(' ')
                                  .Select(double.Parse)
                                  .ToArray();
            double[] roundedNums = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                roundedNums[i] = (int)Math.Round(arr[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{arr[i]} => {roundedNums[i]:F0}");
            }

        }
    }
}
