using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_02_Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] arr1 = Console.ReadLine().Split(new char[] { ' ' }, 
                                                 StringSplitOptions.RemoveEmptyEntries);
            string[] arr2 = Console.ReadLine().Split(new char[] { ' ' }, 
                                                 StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        Console.Write(arr2[j]);
                        Console.Write(" ");
                    }
                }
            }

        }
    }
}
