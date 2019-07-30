using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_12_Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] a1 = new int[n + 1]; string[] a1s = new string[n + 1];
            int[] a2 = new int[n + 1]; string[] a2s = new string[n + 1];
            int[] sb = new int[n + 1]; string[] sbs = new string[n + 1];
            double[] razl = new double[n];
            bool dali = true;
            a1[1] = int.Parse(Console.ReadLine());
            a2[1] = int.Parse(Console.ReadLine());
            sb[1] = a1[1] + a2[1];
            if (n == 1)
            {
                Console.WriteLine("Yes value = " + (2 * a1[1]).ToString());
            }
            else
            {
                a1[2] = int.Parse(Console.ReadLine());
                a2[2] = int.Parse(Console.ReadLine());
                razl[1] = Math.Abs((a1[2] + a2[2]) - (a1[1] + a2[1]));
                double maxrazl = razl[1];
                for (int i = 3; i < n; i++)
                {
                    a1s[i] = Console.ReadLine();
                    int.TryParse(a1s[i], out a1[i]);
                    a2s[i] = Console.ReadLine();
                    int.TryParse(a2s[i], out a2[i]);
                    if (!(int.TryParse(a1s[i], out a1[i]))) { a1[i] = 0; }
                    if (!(int.TryParse(a2s[i], out a2[i]))) { a2[i] = 0; }
                    sb[i] = a1[i] + a2[i];
                    razl[i - 1] = Math.Abs((a1[i] + a2[i]) - (a1[i - 1] + a2[i - 1]));
                }
                for (int i = 1; i <= n; i++)
                {
                    if (sb[i] != sb[i + 1]) { dali = false; break; }
                    else
                    {
                        if (i == n - 1)
                        {
                            Console.WriteLine("Yes value = " + sb[i].ToString());
                        }
                    }
                }
                if (dali == false)
                {
                    for (int i = 2; i <= n - 1; i++)
                    {
                        if (maxrazl < razl[i]) maxrazl = razl[i];
                    }
                    if (maxrazl == 0) Console.WriteLine("Yes value= " + sb[1].ToString());
                    else Console.WriteLine("No, maxdiff = " + maxrazl.ToString());
                }
            }

        }
    }
}
