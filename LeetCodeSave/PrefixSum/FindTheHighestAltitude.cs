using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSave.PrefixSum
{
    public class FindTheHighestAltitude
    {
        public static string ExecuteSolution(int[] nums)
        {
            Console.WriteLine("18: Find the Highest Altitude");
            Console.Write("Array: [");
            foreach (var num in nums)
            {
                Console.Write(num + "; ");
            }
            Console.WriteLine("]");

            double result = LargestAltitude(nums);
            return result.ToString();
        }

        public static double LargestAltitude(int[] gain)
        {
            int maxAlt = 0, currentAlt = 0;
            for (int i = 0; i < gain.Length; i++)
            {
                currentAlt += gain[i];
                maxAlt = Math.Max(currentAlt, maxAlt);
            }
            return maxAlt;
        }
    }
}
