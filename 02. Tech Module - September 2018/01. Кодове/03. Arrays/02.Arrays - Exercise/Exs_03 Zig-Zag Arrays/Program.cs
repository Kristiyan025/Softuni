using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_03_Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];
            for (int i = 0; i < n; i++)
            {
                string values = Console.ReadLine();
                string[] items = values.Split();
                for (int j = 0; j < 2; j++)
                {
                    if (i % 2 == 0)
                    {
                        arr1[i] = int.Parse(items[0]);
                        arr2[i] = int.Parse(items[1]);
                    }
                    else
                    {
                        arr2[i] = int.Parse(items[0]);
                        arr1[i] = int.Parse(items[1]);
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr1[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr2[i]);
                Console.Write(" ");
            }

        }
    }
}
