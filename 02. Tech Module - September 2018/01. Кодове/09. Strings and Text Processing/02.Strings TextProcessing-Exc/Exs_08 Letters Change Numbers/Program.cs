using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_08_Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> str = new List<string>();
            while (true)
            {
                string[] pod = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (pod[0] == "End")
                {
                    break;
                }
                str.AddRange(pod);
            }
            
            decimal sum = 0.00m;
            for (int i = 0; i < str.Count; i++)
            {
                char first = str[i][0];
                int number = int.Parse(str[i].Substring(1, str[i].Length - 2));
                char last = str[i][str[i].Length - 1];
                decimal num = number;
                if (char.IsUpper(first))
                {
                    num /= (first - 'A' + 1);
                }
                else
                {
                    num *= (first - 'A' + 1);
                }
                if (char.IsUpper(last))
                {
                    num -= (last - 'A' + 1);
                }
                else
                {
                    num += (last - 'A' + 1);
                }
                sum += num;
            }
            Console.WriteLine($"{sum:F2}");

        }
    }
}
