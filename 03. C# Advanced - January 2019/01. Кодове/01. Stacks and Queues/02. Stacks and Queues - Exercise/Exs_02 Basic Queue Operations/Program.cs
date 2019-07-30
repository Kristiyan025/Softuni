namespace Exs_02_Basic_Queue_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = input[0];
            int s = input[1];
            int x = input[2];
            var queue = new Queue<int>(
                Console.ReadLine().Split(' ').Select(int.Parse).ToArray());
            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }
            if (queue.Any())
            {
                if (queue.Contains(x))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }

        }
    }
}
