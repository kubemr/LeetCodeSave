using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSave.HashMapSet
{
    public class UniqueNumberofOccurences
    {
        public static string ExecuteSolution(int[] nums)
        {
            Console.WriteLine("21: Unique Number of Occurrences");
            Console.Write("Array: [");
            foreach (var num in nums)
            {
                Console.Write(num + "; ");
            }
            Console.WriteLine("]");

            bool result = UniqueOccurrences(nums);
            return result.ToString();
        }

        public static bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> occurences = [];
            HashSet<int> uniqueOccurences = [];
            foreach (int num in arr) occurences[num] = occurences.GetValueOrDefault(num,0) + 1;
            foreach (int i in occurences.Values) if (!uniqueOccurences.Add(i)) return false;
            return true;
        }
    }
}
