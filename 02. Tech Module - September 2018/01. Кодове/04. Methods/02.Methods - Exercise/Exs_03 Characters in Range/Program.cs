using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_03_Characters_in_Range
{
    class Program
    {
        static void RangePrinting(char firstSymbol, char secondSymbol)
        {

            if (secondSymbol < firstSymbol)
            {
                char temp = firstSymbol;
                firstSymbol = secondSymbol;
                secondSymbol = temp;
            }
            firstSymbol++;
            for (char i = firstSymbol; i < secondSymbol; i++)
            {
                Console.Write(i.ToString() + " ");
            }
        }
        static void Main(string[] args)
        {

            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());
            RangePrinting(firstSymbol, secondSymbol);

        }
    }
}
