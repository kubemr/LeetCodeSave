using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSave.ArrayString
{
    public class GreatestCommonDivisor
    {
        public static string ExecuteSolution()
        {
            Console.WriteLine("2: Greatest Common Divisor of Strings");
            Console.WriteLine("Enter the 1st string: ");
            string? word1 = Console.ReadLine();
            Console.WriteLine("Enter the 2nd string: ");
            string? word2 = Console.ReadLine();

            if (word1 == null)
            {
                word1 = "";
            }

            if (word2 == null)
            {
                word2 = "";
            }

            return GcdOfStrings(word1, word2);
        }

        public static string GcdOfStrings(string str1, string str2)
        {
            string result = "";
            
            bool valid = str1 + str2 == str2 + str1 ? true : false;
            if (!valid) return "";

            for (int i = (str1.Length > str2.Length) ? str2.Length : str1.Length; i > 0; i--)
            {
                if (str1.Length%i == 0 && str2.Length%i == 0)
                {
                    result = str1.Substring(0, i);
                    break;
                }
            }

            return result;
        }
    }
}
