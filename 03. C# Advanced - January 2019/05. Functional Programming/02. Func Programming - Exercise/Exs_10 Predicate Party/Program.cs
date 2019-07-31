namespace Exs_10_Predicate_Party
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            var people = Console.ReadLine().Split().ToList();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Party!")
                {
                    break;
                }
                var commandProps = input.Split();
                string command = commandProps[0];
                string criteria = commandProps[1];
                Func<string, bool> predicate = null;
                if (criteria == "StartsWith")
                {
                    predicate = x => x.StartsWith(commandProps[2]);
                }
                else if(criteria== "EndsWith")
                {
                    predicate = x => x.EndsWith(commandProps[2]);
                }
                else if (criteria=="Length")
                {
                    predicate = x => x.Length == int.Parse(commandProps[2]);
                }
                var list = people.Where(predicate).ToList();
                switch (command)
                {
                    case "Double":
                        for(int i = 0; i < list.Count(); i++)
                        {
                            people.Add(list[i]);
                        }
                        break;
                    case "Remove":
                        for(int i = 0; i < list.Count(); i++)
                        {
                            people.Remove(list[i]);
                        }
                        break;
                }
            }
            if (people.Any())
            {
                Console.WriteLine(string.Join(", ", people) + " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }

        }
    }
}
