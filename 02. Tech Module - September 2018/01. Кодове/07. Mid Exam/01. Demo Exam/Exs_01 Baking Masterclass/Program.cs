using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_01_Baking_Masterclass
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine());
            double apronPrice = double.Parse(Console.ReadLine());
            double flourCount = Math.Ceiling(students - students / 5.00);
            double apronCount = Math.Ceiling(students * 1.2);
            double sum = flourPrice * flourCount + eggPrice * 10 * students +
                         apronPrice * apronCount;
            if (sum <= budget)
            {
                Console.WriteLine($"Items purchased for {sum:F2}$.");
            }
            else
            {
                Console.WriteLine($"{(sum - budget):F2}$ more needed.");
            }

        }
    }
}
