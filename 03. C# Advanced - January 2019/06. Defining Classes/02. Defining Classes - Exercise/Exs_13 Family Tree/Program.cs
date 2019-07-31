namespace Exs_13_Family_Tree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            var people = new List<Person>();
            var connections = new List<Connection>();
            string data = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End") break;

                if (input.Contains('-'))
                {
                    var splited = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                    string parentArg = splited[0];
                    string childArg = splited[1];

                    var parent = new Person(parentArg);
                    var child = new Person(childArg);

                    var connection = new Connection(parent, child);
                    connections.Add(connection);
                }
                else
                {
                    var splited = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    string name = $"{splited[0]} {splited[1]}";
                    string birthday = splited[2];
                    var person = new Person(name, birthday);
                    people.Add(person);
                }
            }
            var mainPerson = people
                .FirstOrDefault(x => x.Name == data || x.Birthday == data);
            var filteredConnections = connections
                .Where(x => x.Parent.Name == mainPerson.Name ||
                            x.Child.Name == mainPerson.Name ||
                            x.Parent.Birthday == mainPerson.Birthday ||
                            x.Child.Birthday == mainPerson.Birthday)
                .ToList();

            var result = new Result();
            result.MainPerson = mainPerson;
            result.Parents = new List<Person>();
            result.Children = new List<Person>();
            foreach (var connection in filteredConnections)
            {
                if(connection.Parent.Name == mainPerson.Name ||
                   connection.Parent.Birthday == mainPerson.Birthday)
                {
                    var child = people
                               .FirstOrDefault(x => x.Name == connection.Child.Name ||
                                                    x.Birthday == connection.Child.Birthday);
                    result.Children.Add(child);
                }
                if(connection.Child.Name == mainPerson.Name ||
                   connection.Child.Birthday == mainPerson.Birthday)
                {
                    var parent = people
                                .FirstOrDefault(x => x.Name == connection.Parent.Name  || 
                                                     x.Birthday == connection.Parent.Birthday);
                    result.Parents.Add(parent);
                }
            }

            Console.WriteLine($"{result.MainPerson.Name} {result.MainPerson.Birthday}");
            Console.WriteLine("Parents:");
            foreach (var parent in result.Parents)
            {
                Console.WriteLine($"{parent.Name} {parent.Birthday}");
            }
            Console.WriteLine("Children:");
            foreach (var child in result.Children)
            {
                Console.WriteLine($"{child.Name} {child.Birthday}");
            }

        }
    }
}
