namespace Exs_01_Define_a_Class_Person
{
    public class Person
    {

        private string name;

        private int age;

        public string Name { get => name; set => name = value; }

        public int Age { get => age; set => age = value; }

        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }

    }
}
