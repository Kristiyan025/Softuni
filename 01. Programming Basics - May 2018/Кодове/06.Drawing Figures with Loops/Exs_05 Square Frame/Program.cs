using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_05_Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {

            int b = int.Parse(Console.ReadLine());
            Console.Write("+ ");
            for (int i = 0; i < (b - 2); i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine('+');
            for (int i = 0; i < (b - 2); i++)
            {
                Console.Write("| ");
                for (int j = 0; j < (b - 2); j++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine('|');

            }
            Console.Write("+ ");
            for (int i = 0; i < (b - 2); i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine('+');

        }
    }
}
