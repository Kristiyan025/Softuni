namespace Exs_01_Trojan_Invasion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            int waves = int.Parse(Console.ReadLine());
            var plates = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var warriors = new List<int>();
            var wars = new List<int>();
            bool isTrojanBeat = false;
            for (int t = 1; t <= waves; t++)
            {
                var currWave = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                if (t % 3 == 0)
                {
                    plates.Add(int.Parse(Console.ReadLine()));
                }
                bool a = false;
                for (int j = currWave.Length - 1; j >= 0; j--)
                {
                    while (currWave[j] > 0)
                    {
                        if (plates.Count != 0)
                        {
                            if (currWave[j] > plates[0])
                            {
                                currWave[j] -= plates[0];
                                plates.RemoveAt(0);
                            }
                            else if (plates[0] > currWave[j])
                            {
                                plates[0] -= currWave[j];
                                currWave[j] = 0;
                                break;
                            }
                            else
                            {
                                plates.RemoveAt(0);
                                currWave[j] = 0;
                                break;
                            }
                        }
                        else
                        {
                            isTrojanBeat = true;
                            a = true;
                            break;
                        }
                    }

                    if (currWave[j] > 0)
                    {
                        wars.Add(currWave[j]);
                    }
                }
                warriors.AddRange(currWave);
                if (a) break;

            }

            Console.WriteLine(isTrojanBeat
                ? "The Trojans successfully destroyed the Spartan defense."
                : "The Spartans successfully repulsed the Trojan attack.");
            if (wars.Count != 0)
                Console.WriteLine("Warriors left: " + string.Join(", ", wars));
            if (plates.Count != 0)
                Console.WriteLine("Plates left: " + string.Join(", ", plates));
        }
    }
}

