using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_01_Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {

            double age = double.Parse(Console.ReadLine());
            var gender = Console.ReadLine();
            if (age < 16)
            {
                if (gender == "f") Console.WriteLine("Miss");
                else if (gender == "m") Console.WriteLine("Master");

            }
            else
            {
                if (gender == "m") Console.WriteLine("Mr.");
                else if (gender == "f") Console.WriteLine("Ms.");
            }

        }
    }
}
