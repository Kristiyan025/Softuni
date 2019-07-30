using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_03_Gauss_Trick
{
    class Program
    {
        static void Main(string[] args)
        {

            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            int count = numbers.Count / 2;
            for (int i = 0; i < count; i++)
            {
                int j = numbers.Count - 1;
                numbers[i] += numbers[j];
                numbers.RemoveAt(j);
                j--;
            }
            Console.WriteLine(string.Join(" ",numbers));

        }
    }
}
