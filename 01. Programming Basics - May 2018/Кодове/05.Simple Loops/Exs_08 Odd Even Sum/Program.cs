using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_08_Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            int sum1 = 0;
            int sum2 = 0;
            int n = int.Parse(Console.ReadLine());
            int momentan;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    momentan = int.Parse(Console.ReadLine());
                    sum1 += momentan;
                }
                else
                {
                    momentan = int.Parse(Console.ReadLine());
                    sum2 += momentan;
                }
            }
            if (sum1 == sum2) Console.WriteLine("Yes\nSum = " + sum1);
            else Console.WriteLine("No\nDiff = " + Math.Abs(sum1 - sum2));

        }
    }
}
