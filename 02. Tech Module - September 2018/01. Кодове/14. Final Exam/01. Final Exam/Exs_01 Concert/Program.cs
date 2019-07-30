using System;
using System.Collections.Generic;
using System.Linq;

namespace Exs_01_Concert
{
    class Program
    {
        static void Main(string[] args)
        {

            var members = new Dictionary<string, List<string>>();
            var times = new Dictionary<string, long>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "start of concert")
                {
                    break;
                }
                string[] parts = line.Split("; ");
                /*for (int i = 0; i < parts.Length; i++)
                {
                    Console.WriteLine(parts[i]);
                }*/
                string command = parts[0];
                string bandName = parts[1];
                if (!members.ContainsKey(bandName))
                {
                    members.Add(bandName, new List<string>());
                    times.Add(bandName, 0);
                }
                switch (command)
                {
                    case "Add":
                        string[] bandMembers = parts[2].Split(", ");
                        foreach (var mem in bandMembers)
                        {
                            if (!members[bandName].Contains(mem))
                            {
                                members[bandName].Add(mem);
                            }
                        }
                        break;
                    case "Play":
                        int time = int.Parse(parts[2]);
                        times[bandName] += time;
                        break;
                }

            }
            long totalTime = 0;
            foreach (var time in times.Values)
            {
                totalTime += time;
            }
            Console.WriteLine("Total time: {0}", totalTime);
            times = times.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var mem in times)
            {
                Console.WriteLine($"{mem.Key} -> {mem.Value}");
            }
            string band = Console.ReadLine();
            Console.WriteLine(band);
            foreach (var mem in members[band])
            {
                Console.WriteLine($"=> {mem}");
            }

        }
    }
}
