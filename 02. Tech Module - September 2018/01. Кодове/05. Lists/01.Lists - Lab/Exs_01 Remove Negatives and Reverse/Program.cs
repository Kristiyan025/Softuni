using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_01_Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string niz = "";
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if(numbers[i] < 0)
                {
                    numbers.Remove(numbers[i]);
                }
                else
                {
                    niz += numbers[i];
                    niz += " ";
                }
            }
            if (niz != "")
            {
                Console.WriteLine(niz);
            }
            else
            {
                Console.WriteLine("empty");
            }


        }
    }
}
