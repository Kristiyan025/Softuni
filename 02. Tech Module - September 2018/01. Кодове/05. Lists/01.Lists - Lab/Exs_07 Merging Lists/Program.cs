using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_07_Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> nums1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> nums2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> newl = new List<int>();
            int bigger = nums1.Count;
            if (nums1.Count < nums2.Count)
            {
                bigger = nums2.Count;
            }
            for (int i = 0; i < 2 * bigger; i++)
            {
                if (i % 2 == 0)
                {
                    if (i >= 2 * nums1.Count)
                    {
                        continue;
                    }
                    newl.Add(nums1[i / 2]);
                }
                else
                {
                    if(i > 2 * nums2.Count)
                    {
                        continue;
                    }
                    newl.Add(nums2[(i - 1) / 2]);
                }
            }
            Console.WriteLine(string.Join(" ",newl));

        }
    }
}
