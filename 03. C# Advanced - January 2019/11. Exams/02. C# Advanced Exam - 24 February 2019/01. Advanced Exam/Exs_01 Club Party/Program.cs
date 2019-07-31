namespace Exs_01_Club_Party
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            int capacity = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var stack = new Stack<string>(input);
            var queue = new Queue<Room>();
            while (stack.Count != 0)
            {
                string current = stack.Pop();
                int count;
                bool isCount = int.TryParse(current, out count);
                if (!isCount)
                {
                    char hall = Convert.ToChar(current);
                    queue.Enqueue(new Room(hall));
                }
                else // is reservation
                {
                    if (queue.Count() != 0)
                    {
                        if (queue.Peek().Reservations.Sum() + count > capacity)
                        {
                            var room = queue.Dequeue();
                            Console.WriteLine($"{room.Hall} -> {string.Join(", ", room.Reservations)}");
                            if(queue.Count() != 0)
                            {
                                queue.Peek().Reservations.Add(count);
                            }
                        }
                        else
                        {
                            queue.Peek().Reservations.Add(count);
                        }
                    }

                }
            }
        }
    }
}
