using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_08_Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = arr.Length;
            for (int i = 0; i < count - 1;)
            {
                for (int j = 0; j < count - 1; j++)
                {
                    arr[j] += arr[j + 1];
                }
                count--;
            }
            Console.WriteLine(arr[0]);

        }
    }
}
