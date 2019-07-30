using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_05_Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine()), momentan;
            for (int i = 1; i < n; i++)
            {
                momentan = int.Parse(Console.ReadLine());
                if (max < momentan) max = momentan;


            }
            Console.WriteLine(max);

        }
    }
}
