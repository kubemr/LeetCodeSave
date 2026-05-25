using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSave.ArrayString
{
    public class IncreasingTripletSubsequence
    {
        public static string ExecuteSolution(int[] nums)
        {
            Console.WriteLine("8: Increasing Triplet Subsequence");
            Console.Write("Array: [");
            foreach (var num in nums)
            {
                Console.Write(num + "; ");
            }
            Console.WriteLine("]");
            bool result = IncreasingTriplet(nums);
            string output = result.ToString();
            return output;
        }

        public static bool IncreasingTriplet(int[] nums)
        {
            if(nums.Length < 3) return false;

            int minVal = int.MaxValue;
            int nextMinVal = int.MaxValue;

            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] <= minVal)
                    minVal = nums[i];
                else if(nums[i] <= nextMinVal)
                    nextMinVal = nums[i];
                else 
                    return true;
            }
            return false;
        }
    }
}
