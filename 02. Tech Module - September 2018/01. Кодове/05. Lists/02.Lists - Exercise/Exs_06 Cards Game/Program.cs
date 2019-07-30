using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_06_Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> nums1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> nums2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            while(true)
            {
                if (nums1.Count == 0 || nums2.Count == 0)
                {
                    break;
                }
                if (nums1[0] > nums2[0])
                {
                    nums1.Add(nums1[0]);
                    nums1.Add(nums2[0]);
                }
                else if (nums1[0] < nums2[0])
                {
                    nums2.Add(nums2[0]);
                    nums2.Add(nums1[0]);
                }
                nums1.RemoveAt(0);
                nums2.RemoveAt(0);
            }
            int left = nums1.Count;
            string winner = "First";
            if (nums1.Count == 0)
            {
                left = nums2.Count;
                winner = "Second";
            }
            int sum = 0;
            for (int i = 0; i < left; i++)
            {
                if (nums1.Count != 0)
                {
                    sum += nums1[i];
                }
                else
                {
                    sum += nums2[i];
                }
            }
            
            Console.WriteLine($"{winner} player wins! Sum: {sum}");

        }
    }
}
