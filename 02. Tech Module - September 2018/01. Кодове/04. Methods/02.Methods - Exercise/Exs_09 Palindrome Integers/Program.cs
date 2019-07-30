using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_09_Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            while (input != "END")
            {
                Console.WriteLine(PalindromeChecker(input));
                input = Console.ReadLine();
            }

        }
        
        static string PalindromeChecker(string input)
        {
            string reversed = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }
            if (input == reversed) return "true";
            else return "false";
        }
    }
}
