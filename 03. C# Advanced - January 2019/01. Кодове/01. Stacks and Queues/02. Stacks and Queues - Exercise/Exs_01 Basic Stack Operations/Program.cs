namespace Exs_01_Basic_Stack_Operations
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
            var stack = new Stack<int>(
                Console.ReadLine().Split(' ').Select(int.Parse).ToArray());
            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }
            if (stack.Any())
            {
                if (stack.Contains(x))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
            
        }
    }
}
