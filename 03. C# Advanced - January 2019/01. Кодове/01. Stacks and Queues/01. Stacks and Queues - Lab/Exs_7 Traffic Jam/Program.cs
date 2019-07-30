namespace Exs_7_Traffic_Jam
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            var queue = new Queue<string>();
            int passed = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end") break;
                else if(input == "green")
                {
                    int count = Math.Min(queue.Count, n);
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        passed++;
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
            }
            Console.WriteLine($"{passed} cars passed the crossroads.");

        }
    }
}
