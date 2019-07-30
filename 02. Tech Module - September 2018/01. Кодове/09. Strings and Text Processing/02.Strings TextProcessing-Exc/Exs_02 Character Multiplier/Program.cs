using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_02_Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] strings = Console.ReadLine().Split(' ');
            string first = strings[0];
            string second = strings[1];
            int sum = 0; 
            int shorter = first.Length >= second.Length ? second.Length : first.Length;
            for (int i = 0; i < shorter; i++)
            {
                int a = Convert.ToInt32(first[i]);
                int b = Convert.ToInt32(second[i]);
                sum += (a * b);
            }
            if (first.Length > shorter)
            {
                for (int i = shorter; i < first.Length; i++)
                {
                    sum += Convert.ToInt32(first[i]);
                }
            }
            else if (second.Length > shorter)
            {
                for (int i = shorter; i < second.Length; i++)
                {
                    sum += Convert.ToInt32(second[i]); ;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
