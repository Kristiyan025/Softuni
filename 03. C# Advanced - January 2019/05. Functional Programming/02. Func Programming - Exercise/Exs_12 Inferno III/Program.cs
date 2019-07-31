namespace Exs_12_Inferno_III
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            var numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var excluded = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Forge")
                {
                    break;
                }
                var parts = input.Split(';', StringSplitOptions.RemoveEmptyEntries);
                string command = parts[0];
                string Currentcommand = parts[1] + ';' + parts[2];
                switch (command)
                {
                    case "Exclude":
                        excluded.Add(Currentcommand);
                        break;
                    case "Reverse":
                        excluded.Remove(Currentcommand);
                        break;
                }
            }
            foreach (var e in excluded)
            {
                var entries = e.Split(';');
                string filter = entries[0];
                int criteria = int.Parse(entries[1]);
                numbers = numbers
                    .Where(GetLambda(numbers, filter, criteria))
                    .ToList();
            }
            Console.WriteLine(string.Join(" ", numbers));

        }

        public static Func<int, bool> GetLambda(List<int> numbers, string filter, int criteria)
        {
            if (filter == "Sum Left")
            {
                return x => (numbers.IndexOf(x) != 0 ? numbers[numbers.IndexOf(x) - 1] : 0) + x != criteria;
            }
            if (filter == "Sum Right")
            {
                return x => x +
                (numbers.IndexOf(x) != numbers.Count - 1 ? numbers[numbers.IndexOf(x) + 1] : 0) != criteria;
            }
            if (filter == "Sum Left Right")
            {
                return x => (numbers.IndexOf(x) != 0 ? numbers[numbers.IndexOf(x) - 1] : 0) + x +
                            (numbers.IndexOf(x) != numbers.Count - 1 ? numbers[numbers.IndexOf(x) + 1] : 0)
                            != criteria;
            }
            return null;
        }
    }
}