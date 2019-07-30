using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_10_Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            if (a == 2 || a == 3)
            {
                Console.WriteLine("Prime");
            }
            else if (a == 1 || a <= 0)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                bool dali = false;
                for (int i = 2; i <= Math.Sqrt(a); i++)
                {
                    if (a % i == 0)
                    {
                        Console.WriteLine("Not Prime");
                        break;
                    }
                    else
                    {
                        dali = true;
                        continue;
                    }
                }
                if (dali == true)
                {
                    Console.WriteLine("Prime");
                }
            }

        }
    }
}
