using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_07_Left_and_Right_Sum
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
                momentan = int.Parse(Console.ReadLine());
                sum1 += momentan;
            }
            for (int i = 0; i < n; i++)
            {
                momentan = int.Parse(Console.ReadLine());
                sum2 += momentan;
            }
            if (sum1 == sum2) Console.WriteLine("Yes, sum = " + sum1);
            else Console.WriteLine("No, diff = " + Math.Abs(sum1 - sum2));

        }
    }
}
