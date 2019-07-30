using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_06_Equal_Sum
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
                bool haveGot = false;
            for (int i = 0; i < arr.Length; i++)
            {
                int rightSum = 0;
                int leftSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += arr[j];
                }
                for (int j = i + 1; j < arr.Length; j++)
                {
                    rightSum += arr[j];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    haveGot = true;
                    break;
                }                
            }
            if (!haveGot)
            {
                Console.WriteLine("no");
            }

        }
    }
}
