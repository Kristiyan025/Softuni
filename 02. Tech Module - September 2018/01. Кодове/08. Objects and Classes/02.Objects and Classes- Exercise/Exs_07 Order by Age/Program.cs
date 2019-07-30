using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_07_Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> persons = new List<Person>();
            while (true)
            {
                string person = Console.ReadLine();
                if (person == "End")
                {
                    break;
                }
                string[] info = person.Split(' ');
                string name = info[0];
                string id = info[1];
                int age = int.Parse(info[2]);
                persons.Add(new Person(name, id, age));
            }
            persons = persons.OrderBy(x => x.Age).ToList();
            foreach (var p in persons)
            {
                Console.WriteLine($"{p.Name} with ID: {p.Id} is {p.Age} years old.");
            }

        }
    }

    class Person
    {
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }

        public string Name { get; set; }

        public string Id { get; set; }

        public int Age { get; set; }
    }
}
