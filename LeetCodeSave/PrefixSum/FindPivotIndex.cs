using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSave.PrefixSum
{
    public class FindPivotIndex
    {
        public static string ExecuteSolution(int[] nums)
        {
            Console.WriteLine("19: Find Pivot Index");
            Console.Write("Array: [");
            foreach (var num in nums)
            {
                Console.Write(num + "; ");
            }
            Console.WriteLine("]");

            double result = PivotIndex(nums);
            return result.ToString();
        }

        public static double PivotIndex(int[] nums)
        {
            int rightSum = 0, leftSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                rightSum += nums[i];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (i != 0) leftSum += nums[i-1];
                rightSum -= nums[i];
                if (leftSum == rightSum)
                {
                    return i;
                }
                
            }
            return -1;
        }
    }
}
