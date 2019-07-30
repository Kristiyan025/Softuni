using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_13_Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int count = 1, k = 1, p = 2, number = 1;
            for (int i = 1; i <= n; i++)
            {
                arr[i - 1] = i;
            }
            while (true)
            {
                for (int j = k; (j < p) && (number <= n); j++)
                {
                    Console.Write(number.ToString() + " "); number++;
                }
                if (!(number <= n)) break;
                Console.WriteLine();
                k = p;
                p += ++count;
            }

        }
    }
}
