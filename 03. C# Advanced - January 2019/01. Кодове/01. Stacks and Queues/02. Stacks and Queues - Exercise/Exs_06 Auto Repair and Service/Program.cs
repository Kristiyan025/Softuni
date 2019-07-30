namespace Exs_06_Auto_Repair_and_Service
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            var queue = new Queue<string>(Console.ReadLine().Split());
            var served = new List<string>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                switch (command[0])
                {
                    case 'S': //Services
                        if (queue.Any())
                        {
                            Console.WriteLine($"Vehicle {queue.Peek()} got served.");
                            served.Insert(0, queue.Dequeue());
                        }
                        break;
                    case 'C': //CarInfo
                        string car = command.Substring(8);
                        if(queue.Contains(car))
                        {
                            Console.WriteLine("Still waiting for service.");
                        }
                        else
                        {
                            Console.WriteLine("Served.");
                        }
                        break;
                    case 'H': //History
                        Console.WriteLine(string.Join(", ", served));
                        break;
                }
            }
            if (queue.Any())
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ", queue)}");
            }
            Console.WriteLine($"Served vehicles: {string.Join(", ", served)}");

        }
    }
}
