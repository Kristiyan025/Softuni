using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_08_Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
           Град       0 ≤ s ≤ 500   500 < s ≤ 1000   1000 < s ≤ 10000   s > 10000

           Sofia      5%            7%               8%                 12%
           Varna      4.5%          7.5%             10%                13%
           Plovdiv    5.5%          8%               12%                14.5%
           */
            string town = Console.ReadLine();
            double s = double.Parse(Console.ReadLine());
            bool dali = true;
            double p = s;
            double k;
            if ((s >= 0) && (s <= 500))
            {
                if (town == "Sofia") { k = 0.05; p *= k; }
                else if (town == "Varna") { k = 0.045; p *= k; }
                else if (town == "Plovdiv") { k = 0.055; p *= k; }
                else
                {
                    Console.WriteLine("error");
                    dali = false;
                }
            }
            else if ((s > 500) && (s <= 1000))
            {
                if (town == "Sofia") { k = 0.07; p *= k; }
                else if (town == "Varna") { k = 0.075; p *= k; }
                else if (town == "Plovdiv") { k = 0.08; p *= k; }
                else
                {
                    Console.WriteLine("error");
                    dali = false;
                }
            }
            else if ((s > 1000) && (s <= 10000))
            {
                if (town == "Sofia") { k = 0.08; p *= k; }
                else if (town == "Varna") { k = 0.1; p *= k; }
                else if (town == "Plovdiv") { k = 0.12; p *= k; }
                else
                {
                    Console.WriteLine("error");
                    dali = false;
                }
            }
            else if (s > 10000)
            {
                if (town == "Sofia") { k = 0.12; p *= k; }
                else if (town == "Varna") { k = 0.13; p *= k; }
                else if (town == "Plovdiv") { k = 0.145; p *= k; }
                else
                {
                    Console.WriteLine("error");
                    dali = false;
                }
            }
            else
            {
                Console.WriteLine("error");
                dali = false;
            }
            if (dali == true)
            {

                Console.WriteLine(p.ToString("0.00"));
            }

        }
    }
}
