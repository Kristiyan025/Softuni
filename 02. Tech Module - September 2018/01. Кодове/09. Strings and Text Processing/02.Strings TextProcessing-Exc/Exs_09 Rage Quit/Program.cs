using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exs_09_Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine().ToUpper();
            string r = @"[0 - 9] +";
            MatchCollection ms = Regex.Matches(input, r);
            string s = string.Empty;
            foreach (Match m in ms)
            {
                StringBuilder sb = new StringBuilder();
                int a = int.Parse(m.Value);
                for (int i = 0; i < a; i++)
                {
                    sb.Append()
                }
            }
            Console.WriteLine();

        }
    }
}
