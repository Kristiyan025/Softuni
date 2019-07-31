using System.Collections.Generic;
using System.Linq;

namespace Exs_03_Oldest_Family_Member
{
    public class Family
    {

        private List<Person> people;

        public List<Person> People { get => people; set => people = value; }

        public void AddMember(Person member)
        {
            People.Add(member);
        }

        public Person GetOldestMember()
        {
            var person = People[0];
            foreach (var p in People)
            {
                if (person.Age < p.Age)
                {
                    person = p;
                }
            }
            return person;
        }

    }
}
