namespace Exs_04_Opinion_Poll
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            var people = new List<Person>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var inputParts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = inputParts[0];
                int age = int.Parse(inputParts[1]);
                people.Add(new Person(name, age));
            }
            people = people.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

        }
    }
}
