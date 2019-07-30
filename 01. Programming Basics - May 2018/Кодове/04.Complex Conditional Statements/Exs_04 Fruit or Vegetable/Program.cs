using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_04_Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {

            var inp = Console.ReadLine();
            if (inp == "banana" || inp == "apple" || inp == "kiwi" || inp == "cherry" ||
                inp == "lemon" || inp == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (inp == "tomato" || inp == "cucumber" || inp == "pepper" || inp == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }

        }
    }
}
