using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_14_Time_plus_15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {

            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            m += 15;
            if (m >= 60)
            {
                h++;
                m -= 60;
            }
            if (h >= 24)
            {
                h -= 24;
            }
            if (m < 10)
            {
                Console.WriteLine(h.ToString() + ":0" + m.ToString());
            }
            else
            {
                Console.WriteLine(h.ToString() + ":" + m.ToString());
            }

        }
    }
}
