using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_05_Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {

            string values = Console.ReadLine();
            string[] items = values.Split();
            int[] arr = new int[items.Length];
            int[] tops = new int[items.Length];
            int count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                arr[i] = int.Parse(items[i]);
            }
            for (int i = 0; i < arr.Length; i++)
            {
            bool isGood = true;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] <= arr[j])
                    {
                        isGood = false;
                        break;
                    }
                }
                if (isGood)
                {
                    tops[count] = arr[i];
                    count++;
                }
            }
            for (int i = 0; i < count; i++)
            {
                Console.Write(tops[i]);
                Console.Write(" ");
            }

        }
    }
}
