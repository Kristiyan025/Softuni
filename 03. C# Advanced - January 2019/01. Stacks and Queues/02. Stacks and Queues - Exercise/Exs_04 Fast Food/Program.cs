namespace Exs_04_Fast_Food
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            int food = int.Parse(Console.ReadLine());
            var queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Console.WriteLine(queue.Max());
            int count = queue.Count;
            bool end = true;
            for (int i = 0; i < count; i++)
            {
                if (food >= queue.Peek())
                {
                    food -= queue.Dequeue();
                }
                else
                {
                    end = false;
                    break; 
                }
            }
            
            if (end)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ",queue)}");
            }

        }
    }
}
