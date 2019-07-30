using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_01_Train
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> wagons = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int cap = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            while (true)
            {
                if (input == "end")
                {
                    break;
                }
                string[] token = input.Split(' ');
                if (token[0] == "Add")
                {
                    wagons.Add(int.Parse(token[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        bool isPosible = wagons[i] + int.Parse(input) <= cap;
                        if (isPosible)
                        {
                            wagons[i] += int.Parse(input);
                            break;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",wagons));
        }
    }
}
