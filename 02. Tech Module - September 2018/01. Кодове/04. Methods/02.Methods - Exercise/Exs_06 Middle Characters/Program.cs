using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_06_Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = Console.ReadLine();
            Console.WriteLine(MiddleFinder(s));

        }

        static string MiddleFinder(string s)
        {
            int index = 0;
            if (s.Length % 2 == 1)
            {
                index = (s.Length - 1) / 2;
                return s[index].ToString();
            }
            else
            {
                index = s.Length / 2 - 1;
                int index2 = index + 1;
                return  s[index].ToString() + s[index2].ToString();
            }
            
        }
    }
}
