namespace Exs_11_Pokemon_Trainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            var trainers = new List<Trainer>();
            while (true)
            {
                string input = Console.ReadLine();
                if(input == "Tournament")
                {
                    break;
                }
                var parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string trainerName = parts[0];
                string pokemonName = parts[1];
                string pokemonElement = parts[2];
                int pokemonHealth = int.Parse(parts[3]);
                var pokemon = new Pokemon
                {
                    Name = pokemonName,
                    Element = pokemonElement,
                    Health = pokemonHealth
                };
                if(trainers
                    .Where(x => x.Name == trainerName)
                    .Count() == 0)
                {
                    trainers.Add(new Trainer
                    {
                        Name = trainerName,
                        Badges = 0,
                        Pokemons = new List<Pokemon> { pokemon }
                    });
                }
                else
                {
                    trainers
                        .Where(x => x.Name == trainerName)
                        .First()
                        .Pokemons
                        .Add(pokemon);
                }

            }
            while (true)
            {
                string element = Console.ReadLine();
                if(element == "End")
                {
                    break;
                }
                for (int i = 0; i < trainers.Count; i++)
                {
                    if(trainers[i].Pokemons
                        .Where(x=>x.Element == element)
                        .Count() > 0)
                    {
                        trainers[i].Badges++;
                    }
                    else
                    {
                        for (int j = 0; j < trainers[i].Pokemons.Count; j++)
                        {
                            trainers[i].Pokemons[j].Health -= 10;
                            if(trainers[i].Pokemons[j].Health <=0)
                            {
                                trainers[i].Pokemons.RemoveAt(j);
                                j--;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(
                string.Join(Environment.NewLine,
                trainers
                   .OrderByDescending(x=>x.Badges)
                   .Select(x=> $"{x.Name} {x.Badges} {x.Pokemons.Count}")));

        }
    }
}
