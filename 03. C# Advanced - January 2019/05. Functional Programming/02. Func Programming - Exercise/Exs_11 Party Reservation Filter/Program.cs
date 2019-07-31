namespace Exs_11_Party_Reservation_Filter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Lambda
    {
        public string Criteria { get; set; }

        public string Parameter { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            var people = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var predicates = new List<Lambda>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Print")
                {
                    break;
                }
                var commandProps = input.Split(';', StringSplitOptions.RemoveEmptyEntries);
                string command = commandProps[0];
                string criteria = commandProps[1];
                string parameter = commandProps[2];
                var p = new Lambda { Criteria = criteria, Parameter = parameter };
                switch (command)
                {
                    case "Add filter":
                        predicates.Add(p);
                        break;
                    case "Remove filter":
                        predicates = predicates
                                        .Where(x => !(x.Criteria == p.Criteria && 
                                               x.Parameter == p.Parameter))
                                        .ToList();
                        break;
                }
            }
            foreach (var filter in predicates)
            {
                people = people.Where(GetLambda(filter)).ToList();
            }
            Console.WriteLine(string.Join(" ", people));

        }

        static Func<string,bool> GetLambda(Lambda p)
        {
            if (p.Criteria == "Starts with") return x => !x.StartsWith(p.Parameter);
            if (p.Criteria == "Ends with") return x => !x.EndsWith(p.Parameter);
            if (p.Criteria == "Length") return x => x.Length != int.Parse(p.Parameter);
            return x => !x.Contains(p.Parameter);
        }
    }
}
