using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSave.HashMapSet
{
    public class FindTheDifferenceofTwoArrays
    {
        public static string ExecuteSolution(int[] nums1, int[] nums2)
        {
            Console.WriteLine("20: Find the Difference of Two Arrays");
            Console.Write("Array 1: [");
            foreach (var num in nums1)
            {
                Console.Write(num + "; ");
            }
            Console.WriteLine("]");
            Console.Write("Array 2: [");
            foreach (var num in nums2)
            {
                Console.Write(num + "; ");
            }
            Console.WriteLine("]");

            var results = FindDifference(nums1, nums2);
            string output = "[ ";
            output += "[ ";
            foreach (var result in results[0])
            {
                output += $"{result}; ";
            }
            output += "], ";
            output += "[ ";
            foreach (var result in results[1])
            {
                output += $"{result}; ";
            }
            output += "]";
            return output;
        }

        public static IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            List<int> distinct1 = [], distinct2 = [];
            foreach (var num in nums1)
            {
                if (distinct1.Contains(num) || nums2.Contains(num)) continue;

                distinct1.Add(num);
            }

            foreach (var num in nums2)
            {
                if (distinct2.Contains(num) || nums1.Contains(num)) continue;

                distinct2.Add(num);
            }
            var result = new List<IList<int>>() { distinct1, distinct2 };
            return result;
        }
    }
}
