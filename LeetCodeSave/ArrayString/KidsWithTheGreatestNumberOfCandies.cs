using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSave.ArrayString
{
    public class KidsWithTheGreatestNumberOfCandies
    {
        public static string ExecuteSolution(int[] candies, int extraCandies)
        {
            Console.WriteLine("3: KidsWithTheGreatestNumberOfCandies");
            Console.Write("Candies: [");
            foreach (var candy in candies)
            {
                Console.Write(candy + "; ");
            }
            Console.WriteLine("]");
            Console.WriteLine("Extras: " + extraCandies);


            bool[] results = KidsWithCandies(candies, extraCandies);
            string output = "[ ";
            foreach (var result in results)
            {
                output +=$"{result}; ";
            }
            output += "]";
            return output;
        }

        public static bool[] KidsWithCandies(int[] candies, int extraCandies)
        {
            bool[] result = new bool[candies.Length];
            for (int i = 0; i < candies.Length; i++)
            {
                result[i] = true;
                int newCandyCount = candies[i] + extraCandies;
                for (int j = 0; j < candies.Length; j++)
                {
                    if (newCandyCount < candies[j])
                    {
                        result[i] = false;
                        break;
                    }
                }
            }
            return result;
        }
    }
}
