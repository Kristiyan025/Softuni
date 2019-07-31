namespace Exs_05_Filter_By_Age
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var all = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                var personProps = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string Currentname = personProps[0];
                int Currentage = int.Parse(personProps[1]);
                all.Add(new Person { Name = Currentname, Age = Currentage });
            }
            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();
            Func<Person, bool> predicate = Predicate(condition, age);
            Func<Person, string> filter = Filter(format);
            all.Where(predicate).Select(filter).ToList().ForEach(x => Console.WriteLine(x));

        }
        
        static Func<Person,bool> Predicate(string condition, int age)
        {
            if (condition == "older")
            {
                return x => x.Age >= age;
            }
            else
            {
                return x => x.Age < age;
            }
        }

        static Func<Person,string> Filter(string format)
        {
            if (format == "name")
            {
                return x => $"{x.Name}";
            }
            else if (format == "age")
            {
                return x => $"{x.Age}";
            }
            else
            {
                return x => $"{x.Name} - {x.Age}";
            }
        }
    }
}
