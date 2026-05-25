using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSave.SlidingWindow
{
    public class MaxConsecutiveOnesIII
    {
        public static string ExecuteSolution(int[] nums, int k)
        {
            Console.WriteLine("16: Max Consecutive Ones III");
            Console.Write("Array: [");
            foreach (var num in nums)
            {
                Console.Write(num + "; ");
            }
            Console.WriteLine("]");
            Console.WriteLine($"Integer: {k}");

            double result = LongestOnes(nums, k);
            return result.ToString();
        }

        public static double LongestOnes(int[] nums, int k)
        {
            int zeroes = 0, maxOnes = 0, left = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    zeroes++;
                    while (zeroes > k)
                    {
                        if (nums[left] == 0) zeroes--;
                        left++;
                    }
                }
                maxOnes = Math.Max(maxOnes, i - left+1);
            }

            return maxOnes;
        }
    }
}
