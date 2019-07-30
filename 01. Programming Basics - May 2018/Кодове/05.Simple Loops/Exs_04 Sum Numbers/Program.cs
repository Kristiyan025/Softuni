using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_04_Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int sum = 0;
            int n = int.Parse(Console.ReadLine());
            int momentan;
            for (int i = 0; i < n; i++)
            {
                momentan = int.Parse(Console.ReadLine());
                sum += momentan;
            }
            Console.WriteLine(sum);

        }
    }
}
