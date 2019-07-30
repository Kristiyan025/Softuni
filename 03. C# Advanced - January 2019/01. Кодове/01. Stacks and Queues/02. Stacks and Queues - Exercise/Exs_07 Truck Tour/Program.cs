namespace Exs_07_Truck_Tour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var queue = new Queue<int>();
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                int[] pair = Console.ReadLine().Split().Select(int.Parse).ToArray();
                queue.Enqueue(pair[0] - pair[1]);
            }
            while(true)
            {
                int fuel = -1;
                var temp = new Queue<int>(queue);
                while(temp.Any())
                {
                    if(temp.Peek() > 0 && fuel == -1)
                    {
                        fuel = temp.Dequeue();
                        queue.Enqueue(queue.Dequeue());
                    }
                    else if(temp.Peek() < 0 && fuel == -1)
                    {
                        temp.Enqueue(temp.Dequeue());
                        queue.Enqueue(queue.Dequeue());
                        index++;
                    }
                    else
                    {
                        fuel += temp.Dequeue();
                        if (fuel < 0)
                        {
                            break;
                        }
                    }
                }
                if (fuel >= 0)
                {
                    Console.WriteLine(index);
                    return;
                }
                index++;
            }
            
        }
    }
}
