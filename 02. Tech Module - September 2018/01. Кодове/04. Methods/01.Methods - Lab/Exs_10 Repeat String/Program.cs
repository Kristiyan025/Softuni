using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_10_Repeat_String
{
    class Program
    {
        static string Repeating(string text,int numberOfRepeating)
        {

            string newText = text;
            for (int i = 1; i < numberOfRepeating; i++)
            {
                newText += text;
            }
            return newText;
        }

        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            int numberOfRepeating = int.Parse(Console.ReadLine());
            Console.WriteLine(Repeating(text, numberOfRepeating));

        }
    }
}
