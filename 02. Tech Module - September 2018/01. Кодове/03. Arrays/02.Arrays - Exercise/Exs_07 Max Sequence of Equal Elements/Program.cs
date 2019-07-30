using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_07_Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {

            string values = Console.ReadLine();
            string[] items = values.Split();
            int[] arr = new int[items.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(items[i]);
            }
            int[] sequences = new int[arr.Length];
            int[] count = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                count[i] = 1;
            }
            int current = 0;
            int firstRecurring = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (firstRecurring == arr[i])
                {                    
                    sequences[current] = arr[i];
                    count[current]++;
                }
                else
                {
                    firstRecurring = arr[i];
                    if (i != arr.Length - 1 && arr[i + 1] == arr[i])
                    {                    
                        current++;
                    }
                }
            }
            int longest = count[0];
            int index = 0;
            for (int i = 1; i <= current; i++)
            {
                if (longest < count[i])
                {
                    longest = count[i];
                    index = i;
                }
            }
            for (int i = 0; i < count[index]; i++)
            {
                Console.Write(sequences[index]);
                Console.Write(" ");
            }

        }
    }
}
