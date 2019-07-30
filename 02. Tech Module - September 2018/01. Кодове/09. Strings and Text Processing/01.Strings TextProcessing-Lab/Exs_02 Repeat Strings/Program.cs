using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_02_Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = Console.ReadLine();
            string[] k = s.Split(' ');
            StringBuilder p = new StringBuilder();
            for (int i = 0; i < k.Length; i++)
            {
                for (int j = 0; j < k[i].Length; j++)
                {
                    p.Append(k[i]);
                }
            }
            Console.WriteLine(p);

        }
    }
}
