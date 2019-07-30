using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_04_Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.Write(nums.Max().ToString() + " ");
            nums.Remove(nums.Max());
            if (nums.Count > 0)
            {
            Console.Write(nums.Max().ToString() + " ");
            nums.Remove(nums.Max());
            }
            if (nums.Count > 0)
            {
            Console.Write(nums.Max().ToString() + " ");
            nums.Remove(nums.Max());
            }

        }
    }
}
