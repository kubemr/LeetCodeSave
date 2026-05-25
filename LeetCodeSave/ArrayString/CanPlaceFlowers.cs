using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSave.ArrayString
{
    public class CanPlaceFlowers
    {
        public static string ExecuteSolution(int[] flowerbed, int n)
        {
            Console.WriteLine("4: Can Place Flowers");
            Console.Write("Candies: [");
            foreach (var candy in flowerbed)
            {
                Console.Write(candy + "; ");
            }
            Console.WriteLine("]");
            Console.WriteLine("Flower to plant: " + n);


            bool result = CanPlaceFlowersA(flowerbed, n);
            string output = result.ToString();
            
            return output;
        }

        public static bool CanPlaceFlowersA(int[] flowerbed, int n)
        {
            if (n == 0) return true;
            
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 1) continue;

                bool leftTaken = (i > 0) && (flowerbed[i-1] == 1) ;
                bool rightTaken = (i < flowerbed.Length - 1) && (flowerbed[i + 1] == 1);
                if (!leftTaken && !rightTaken)
                {
                    flowerbed[i] = 1;
                    n--;
                    if (n == 0) break;
                }
            }
            return n == 0;
        }
    }
}
