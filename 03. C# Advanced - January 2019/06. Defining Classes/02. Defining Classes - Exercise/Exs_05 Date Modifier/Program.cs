namespace Exs_05_Date_Modifier
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {

            string start = Console.ReadLine();
            string end = Console.ReadLine();
            var dateModifier = new DateModifier();
            dateModifier.CalculateDifference(start, end);
            Console.WriteLine(dateModifier.Days);

        }
    }
}
