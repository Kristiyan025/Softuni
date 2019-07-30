using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_11_Odd_or_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            double oddSum = 0, evenSum = 0;
            double oddMin, oddMax, evenMin, evenMax;
            double[] arr = new double[n + 1];
            if (n != 0)
            {
                arr[1] = double.Parse(Console.ReadLine()); oddSum += arr[1]; oddMin = arr[1]; oddMax = arr[1];
                if (n != 1)
                {
                    arr[2] = double.Parse(Console.ReadLine()); evenSum += arr[2]; evenMin = arr[2]; evenMax = arr[2];

                    for (int i = 3; i <= n; i++)
                    {
                        arr[i] = double.Parse(Console.ReadLine());
                        if (i % 2 == 1)
                        {
                            oddSum += arr[i];
                            if (oddMin > arr[i])
                            {
                                oddMin = arr[i];
                            }
                            if (oddMax < arr[i])
                            {
                                oddMax = arr[i];
                            }
                        }
                        else
                        {
                            evenSum += arr[i];
                            if (evenMin > arr[i])
                            {
                                evenMin = arr[i];
                            }
                            if (evenMax < arr[i])
                            {
                                evenMax = arr[i];
                            }
                        }
                    }
                    Console.WriteLine("OddSum = " + oddSum.ToString() + ",");
                    Console.WriteLine("OddMin = " + oddMin.ToString() + ",");
                    Console.WriteLine("OddMax = " + oddMax.ToString() + ",");
                    Console.WriteLine("EvenSum = " + evenSum.ToString() + ",");
                    Console.WriteLine("EvenMin = " + evenMin.ToString() + ",");
                    Console.WriteLine("EvenMax = " + evenMax.ToString());
                }
            }
            if (n == 0)
            {
                Console.WriteLine("OddSum = 0,");
                Console.WriteLine("OddMin = No,");
                Console.WriteLine("OddMax = No,");
                Console.WriteLine("EvenSum = " + evenSum.ToString() + ",");
            }
            else if (n == 1)
            {
                Console.WriteLine("OddSum = " + arr[1].ToString() + ",");
                Console.WriteLine("OddMin = " + arr[1].ToString() + ",");
                Console.WriteLine("OddMax = " + arr[1].ToString() + ",");
                Console.WriteLine("EvenSum = " + evenSum.ToString() + ",");
            }
            if (n == 1 || n == 0)
            {
                Console.WriteLine("EvenMin = No,");
                Console.WriteLine("EvenMax = No");

            }

        }
    }
}
