using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_05_Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            string bigNumber = Console.ReadLine().TrimStart('0');
            int mult = int.Parse(Console.ReadLine());
            int onMind = 0;
            string resultNumber = string.Empty;
            string reversed = string.Join("", bigNumber.ToCharArray().Reverse());
            if (bigNumber == "0" || mult == 0)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = 0; i < reversed.Length; i++)
            {
                int product = int.Parse(reversed[i].ToString()) * mult + onMind;
                int result = product % 10;
                resultNumber += result;
                onMind = product / 10;
                if (i == reversed.Length - 1 && onMind != 0)
                {
                    resultNumber += onMind;
                }
            }
            string final = string.Join("", resultNumber.ToCharArray().Reverse());
            Console.WriteLine(final);

        }
    }
}
