namespace Exs_01_Define_a_Class_Person
{
    class Program
    {
        static void Main(string[] args)
        {

            var persons = new Person[3]
            {
                new Person("Pesho",23),
                new Person("Anabel",17),
                new Person("Toni",27)
            };

        }
    }
}
