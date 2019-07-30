using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_06_Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine()), momentan;
            for (int i = 1; i < n; i++)
            {
                momentan = int.Parse(Console.ReadLine());
                if (min > momentan) min = momentan;


            }
            Console.WriteLine(min);

        }
    }
}
