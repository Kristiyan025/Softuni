using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_01_Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] phrases = new string[] { "Excellent product.",
                                               "Such a great product.",
                                               "I always use that product.",
                                               "Best product of its category.",
                                               "Exceptional product.",
                                               "I can’t live without this product." };
            string[] events = new string[] { "Now I feel good.",
                                              "I have succeeded with this product.",
                                              "Makes miracles. I am happy of the results!",
                                              "I cannot believe but now I feel awesome.",
                                              "Try it yourself, I am very satisfied.",
                                              "I feel great!" };
            string[] authors = new string[] { "Diana", "Petya", "Stella", "Elena",
                                               "Katya", "Iva", "Annie", "Eva" };
            string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            int n = int.Parse(Console.ReadLine());
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{phrases[r.Next(0,6)]} {events[r.Next(0,6)]} " +
                                  $"{authors[r.Next(0,8)]} – {cities[r.Next(0,5)]}");
            }

        }
    }
}
