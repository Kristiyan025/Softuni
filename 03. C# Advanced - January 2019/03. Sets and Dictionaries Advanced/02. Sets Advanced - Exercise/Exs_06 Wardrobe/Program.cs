using System;
using System.Collections.Generic;

namespace Exs_06_Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                var clothesProps = Console.ReadLine().Split(" -> ");
                string col = clothesProps[0];
                var clothes = clothesProps[1].Split(',');
                if (!wardrobe.ContainsKey(col))
                {
                    wardrobe.Add(col, new Dictionary<string, int>());
                }
                foreach (var clot in clothes)
                {
                    if (!wardrobe[col].ContainsKey(clot))
                    {
                        wardrobe[col].Add(clot, 0);
                    }
                    wardrobe[col][clot]++;
                }
            }
            var find = Console.ReadLine().Split(' ');
            string color = find[0];
            string cloth = find[1];
            foreach (var col in wardrobe)
            {
                Console.WriteLine($"{col.Key} clothes:");
                foreach (var clot in col.Value)
                {
                    if(col.Key==color && clot.Key == cloth)
                    {
                        Console.WriteLine($"* {clot.Key} - {clot.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clot.Key} - {clot.Value}");
                    }
                }
            }

        }
    }
}
