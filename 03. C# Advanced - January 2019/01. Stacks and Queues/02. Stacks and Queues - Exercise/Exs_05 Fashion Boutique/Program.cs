namespace Exs_05_Fashion_Boutique
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            var stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int capacity = int.Parse(Console.ReadLine());
            int box = 0;
            int count = 1;

            while (stack.Any())
            {
                int current = stack.Peek();
                if (box + current < capacity)
                {
                    box += current;
                    stack.Pop();
                }
                else if (box + current == capacity)
                {
                    stack.Pop();
                    if (stack.Any())
                    {
                        count++;
                        box = 0;
                    }
                }
                else
                {
                    count++;
                    box = current;
                    stack.Pop();
                }
            }
            Console.WriteLine(count);

        }
    }
}