using System;
using System.Collections.Generic;

namespace Exs_04_Cities_by_ContinentCountry
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var data = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string continent = input[0];
                string country = input[1];
                string city = input[2];
                if (!data.ContainsKey(continent))
                {
                    data.Add(continent, new Dictionary<string, List<string>>());
                    data[continent].Add(country, new List<string> { city });
                }
                else
                {
                    if (!data[continent].ContainsKey(country))
                    {
                        data[continent].Add(country, new List<string> { city });
                    }
                    else
                    {
                        data[continent][country].Add(city);
                    }
                }
                
            }
            foreach (var continent in data)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
