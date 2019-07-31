namespace Exs_03_Oldest_Family_Member
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {

            var family = new Family();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var inputParts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = inputParts[0];
                int age = int.Parse(inputParts[1]);
            }

            var oldest = family.GetOldestMember();
            Console.WriteLine($"{oldest.Name} - {oldest.Age}");

        }
    }
}
