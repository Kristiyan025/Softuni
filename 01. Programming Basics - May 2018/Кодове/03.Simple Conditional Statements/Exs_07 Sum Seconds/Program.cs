using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_07_Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {

            int sec1 = int.Parse(Console.ReadLine());
            int sec2 = int.Parse(Console.ReadLine());
            int sec3 = int.Parse(Console.ReadLine());
            int totalSecs = sec1 + sec2 + sec3;
            int mins = 0;
            if (totalSecs > 59) // TODO: Repeat this 2 times…
            {
                mins = totalSecs / 60;
                totalSecs %= 60;
            }
            if (totalSecs < 10)
            {
                Console.WriteLine(mins + ":" + "0" + totalSecs);
            }
            else
            {
                Console.WriteLine(mins + ":" + totalSecs);
            }

        }
    }
}
