namespace Exs_5_Supermarket
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {

            var queue = new Queue<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                else if (input == "Paid")
                {
                    int count = queue.Count;
                    if (count > 0)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine(queue.Dequeue());
                        }
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
            }
            Console.WriteLine($"{queue.Count} people remaining.");

        }
    }
}
