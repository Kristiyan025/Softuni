using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_01_Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                StringBuilder word = new StringBuilder();
                word.Append(Console.ReadLine());
                if (word.ToString() == "end")
                {
                    break;
                }
                StringBuilder reversed = new StringBuilder();
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reversed.Append(word[i]);
                }
                Console.WriteLine($"{word} = {reversed}");
            }

        }
    }
}
