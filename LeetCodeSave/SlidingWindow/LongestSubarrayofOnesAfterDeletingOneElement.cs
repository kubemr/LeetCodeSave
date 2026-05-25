using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSave.SlidingWindow
{
    public class LongestSubarrayofOnesAfterDeletingOneElement
    {
        public static string ExecuteSolution(int[] nums)
        {
            Console.WriteLine("17: Longest Subarray of 1's After Deleting One Element");
            Console.Write("Array: [");
            foreach (var num in nums)
            {
                Console.Write(num + "; ");
            }
            Console.WriteLine("]");

            double result = LongestSubarray(nums);
            return result.ToString();
        }

        public static double LongestSubarray(int[] nums)
        {
            int zeroes = 0, maxOnes = 0, left = 0;
            bool zeroFlipped = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    while (zeroFlipped)
                    {
                        if (nums[left] == 0) zeroFlipped = false;
                        left++;
                    }
                    zeroFlipped = true;
                    
                }
                maxOnes = Math.Max(maxOnes, i - left);
            }

            return maxOnes;
        }
    }
}
