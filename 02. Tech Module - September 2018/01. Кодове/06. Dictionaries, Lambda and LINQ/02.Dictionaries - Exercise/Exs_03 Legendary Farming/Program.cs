using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_03_Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> materials = new Dictionary<string, int>();
            materials.Add("shards", 0);
            materials.Add("fragments", 0);
            materials.Add("motes", 0);
            var junks = new SortedDictionary<string, int>();
            while (materials["shards"] < 250 && materials["fragments"] < 250 && 
                   materials["motes"] < 250)
            {
                string input = Console.ReadLine();
                string[] all = input.Split();
                bool hasToBreak = false;
                for (int i = 0; i < all.Length; i += 2)
                {
                    int quantity = int.Parse(all[i]);
                    string material = all[i + 1].ToLower();
                    if (materials.ContainsKey(material))
                    {
                        materials[material] += quantity;
                        if (materials[material] >= 250)
                        {
                            materials[material] -= 250;
                            if (material == "shards")
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                            }
                            else if (material == "fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");
                            }
                            else if (material == "motes")
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                            }
                            hasToBreak = true;
                            break;
                        }
                    }
                    else if (junks.ContainsKey(material))
                    {
                        junks[material] += quantity;
                    }
                    else
                    {
                        junks.Add(material, quantity);
                    }
                }
                if (hasToBreak)
                {
                    break;
                }
            }
            materials = materials.OrderByDescending(n => n.Value).ThenBy(n => n.Key)
                                 .ToDictionary(n => n.Key, n => n.Value);
            foreach (var mat in materials)
            {
                Console.WriteLine(mat.Key + ": " + mat.Value);
            }
            foreach (var j in junks)
            {
                Console.WriteLine(j.Key + ": " + j.Value);
            }

        }
    }
}