using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_04_List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();
            for (int i = 0; i < n; i++)
            {
                products.Add(Console.ReadLine());
            }
            products.Sort();
            for (int i = 1; i <= products.Count; i++)
            {
                Console.WriteLine($"{i}.{products[i - 1]}");
            }

        }
    }
}
