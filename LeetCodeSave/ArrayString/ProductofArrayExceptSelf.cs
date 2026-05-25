using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSave.ArrayString
{
    public class ProductofArrayExceptSelf
    {
        public static string ExecuteSolution(int[] nums)
        {
            Console.WriteLine("7: Product of Array Except Self");
            Console.Write("Array: [");
            foreach (var num in nums)
            {
                Console.Write(num + "; ");
            }
            Console.WriteLine("]");


            int[] results = ProductExceptSelf(nums);
            string output = "[ ";
            foreach (var result in results)
            {
                output += $"{result}; ";
            }
            output += "]";
            return output;
        }

        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Length];
            int totalProduct = 1;
            int zeroes = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    zeroes++;
                    if (zeroes >= 2)
                    {
                        totalProduct = 0;
                        break;
                    }
                    continue;
                }
                totalProduct *= nums[i];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (zeroes >= 1)
                {
                    if (nums[i] == 0)
                    {
                        result[i] = totalProduct;
                    }
                    else
                    {
                        result[i] = 0;
                    }
                    continue;
                }
                result[i] = totalProduct / nums[i];
            }

            return result;
        }
    }
}
