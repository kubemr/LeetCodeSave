using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSave.SlidingWindow
{
    public class MaximumAverageSubarrayI
    {
        public static string ExecuteSolution(int[] nums, int k)
        {
            Console.WriteLine("14: Maximum Average Subarray I");
            Console.Write("Array: [");
            foreach (var num in nums)
            {
                Console.Write(num + "; ");
            }
            Console.WriteLine("]");
            Console.WriteLine($"Integer: {k}");

            double result = FindMaxAverage(nums, k);
            return result.ToString();
        }

        public static double FindMaxAverage(int[] nums, int k)
        {
            int sum = 0;
            for (int i = 0; i < k; i ++) sum += nums[i];
            int maxSum = sum;
            for (int i = k; i < nums.Length; i++)
            {
                sum = sum - nums[i-k] + nums[i];
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
            return (double)maxSum/k;
        }

        
    }
}
