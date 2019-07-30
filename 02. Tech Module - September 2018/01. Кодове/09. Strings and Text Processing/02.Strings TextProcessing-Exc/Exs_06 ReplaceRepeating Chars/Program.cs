using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_06_ReplaceRepeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] == text[i - 1])
                {
                    text = text.Remove(i, 1);
                    i--;
                }
            }
            Console.WriteLine(text);

        }
    }
}
