namespace Exs_05_Applied_Arithmetics
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {

            var numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                switch (command)
                {
                    case "add":
                        numbers = numbers.Select(x => x + 1).ToArray();
                        break;
                    case "subtract":
                        numbers = numbers.Select(x => x - 1).ToArray();
                        break;    
                    case "multiply":
                        numbers = numbers.Select(x => x * 2).ToArray();
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", numbers));
                        break;
                }
            }

        }
    }
}
