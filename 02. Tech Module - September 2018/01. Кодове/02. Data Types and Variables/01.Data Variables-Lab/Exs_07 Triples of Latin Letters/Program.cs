using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_07_Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            for (char i = 'a'; i <= Convert.ToChar(96 + number); i++)
            {
                for (char j = 'a'; j <= Convert.ToChar(96 + number); j++)
                {
                    for (char l = 'a'; l <= Convert.ToChar(96 + number); l++)
                    {
                        Console.WriteLine($"{i}{j}{l}");
                    }
                }
            }

        }
    }
}
