using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_07_Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            for (int i = 1; i < input.Length; i++)
            {
                if(input[i] == ' ')
                {
                    input.Remove(i, 1);
                    i--;
                }
            }
            string[] arrs = input.Split('|');
            string num = "";
            for (int i = arrs.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < arrs[i].Length; j++)
                {
                    if (j % 2 == 1)
                    {
                        arrs[i].Insert(j," ");
                    }
                }
                num += arrs[i];
            }
            Console.WriteLine(num);

        }
    }
}