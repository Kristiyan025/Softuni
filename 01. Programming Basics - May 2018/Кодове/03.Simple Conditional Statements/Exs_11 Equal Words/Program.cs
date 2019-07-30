using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_11_Equal_Words
{
    class Program
    {
        static void Main(string[] args)
        {

            string a = Console.ReadLine().ToLower();
            string b = Console.ReadLine().ToLower();
            if (a == b)
            {
                Console.Write("yes");
            }
            else
            {
                Console.Write("no");
            }

        }
    }
}
