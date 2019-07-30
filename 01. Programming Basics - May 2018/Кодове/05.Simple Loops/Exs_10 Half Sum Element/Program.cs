using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_10_Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int ng;
            int[] arr = new int[n];
            bool dali = false;
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
            }
            ng = arr[0];
            for (int i = 0; i < n; i++)
            {
                if (ng <= arr[i]) { ng = arr[i]; }
                if (arr[i] == (sum - arr[i]))
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine("Sum = " + arr[i].ToString());
                    dali = true;
                    break;
                }
                else continue;
            }
            if (dali == false)
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(ng - (sum - ng)).ToString());
            }

        }
    }
}
