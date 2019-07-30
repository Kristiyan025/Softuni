using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_04_Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                char newChar = Convert.ToChar(Convert.ToInt32(text[i]) + 3);
                sb.Append(newChar);
            }
            Console.WriteLine(sb);

        }
    }
}
