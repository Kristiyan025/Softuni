using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_05_Digits_Letters_Other
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder other = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    digits.Append(text[i]);
                }
                else if (char.IsLetter(text[i]))
                {
                    letters.Append(text[i]);
                }
                else
                {
                    other.Append(text[i]);
                }
            }
            Console.WriteLine(digits.ToString() + "\n" +
                              letters.ToString() + "\n" +
                              other.ToString());

        }
    }
}
