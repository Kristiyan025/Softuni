using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_03_House_Party
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<string> names= new List<string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] token = input.Split(' ');
                if (token[2] != "not")
                {
                    if (names.Contains(token[0]))
                    {
                        Console.WriteLine($"{token[0]} is already in the list!");
                    }
                    else
                    {
                        names.Add(token[0]);
                    }
                }
                else
                {
                    if (names.Contains(token[0]))
                    {
                        names.Remove(token[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{token[0]} is not in the list!");
                    }
                }
            }
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

        }
    }
}
