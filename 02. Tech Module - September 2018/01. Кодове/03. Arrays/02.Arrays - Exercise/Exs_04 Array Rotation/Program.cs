using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_04_Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {

            string values = Console.ReadLine();
            string[] items = values.Split();
            int[] arr = new int[items.Length];
            for (int i = 0; i < items.Length; i++)
            {
                arr[i] = int.Parse(items[i]);
            }
            int rotations = int.Parse(Console.ReadLine());
            for (int i = 0; i < rotations; i++)
            {
                int firstElement = arr[0];
                for (int j = 0; j < items.Length - 1; j++)
                {
                    arr[j] = arr[j + 1]; 
                }
                arr[items.Length - 1] = firstElement;
            }
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write(arr[i]);
                Console.Write(" ");
            }

        }
    }
}
