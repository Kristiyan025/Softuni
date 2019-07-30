using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_09_Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a') sum += 1;
                if (s[i] == 'e') sum += 2;
                if (s[i] == 'i') sum += 3;
                if (s[i] == 'o') sum += 4;
                if (s[i] == 'u') sum += 5;


            }
            Console.WriteLine(sum);

        }
    }
}
