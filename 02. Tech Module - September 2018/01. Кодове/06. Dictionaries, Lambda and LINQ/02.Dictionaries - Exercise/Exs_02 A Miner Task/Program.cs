using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_02_A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {

            string resource = Console.ReadLine();
            var counts = new Dictionary<string, int>();
            while (true)
            {
                if (resource == "stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());
                if (counts.ContainsKey(resource))
                {
                    counts[resource] += quantity;
                }
                else
                {
                    counts.Add(resource, quantity);
                }
                resource = Console.ReadLine();
            }
            foreach (var res in counts)
            {
                Console.WriteLine(res.Key + " -> " + res.Value);
            }

        }
    }
}
