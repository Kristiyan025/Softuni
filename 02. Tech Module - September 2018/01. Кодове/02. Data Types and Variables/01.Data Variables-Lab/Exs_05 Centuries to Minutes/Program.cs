using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_05_Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {

            byte centuries = byte.Parse(Console.ReadLine());
            ushort years = Convert.ToUInt16(centuries * 100);
            uint days = (uint)(years * 365.2422);
            ulong hours = days * 24;
            ulong minutes = hours * 60;
            Console.WriteLine($"{centuries} centuries = " +
                              $"{years} years = " +
                              $"{days} days = " +
                              $"{hours} hours = " +
                              $"{minutes} minutes");

        }
    }
}
