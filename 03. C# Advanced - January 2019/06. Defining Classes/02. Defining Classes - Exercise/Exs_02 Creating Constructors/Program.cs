namespace Exs_02_Creating_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {

            var firstPerson = new Person();

            var secondPerson = new Person(24);

            var thirdPerson = new Person("Albert", 35);

        }
    }
}
