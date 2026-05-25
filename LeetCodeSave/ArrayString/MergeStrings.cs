using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSave.ArrayString
{
    public static class MergeStrings
    {
        public static string ExecuteSolution()
        {
            Console.WriteLine("1: Merge Strings Alternatively");
            Console.WriteLine("Enter the 1st word: ");
            string? word1 = Console.ReadLine();
            Console.WriteLine("Enter the 2nd word: ");
            string? word2 = Console.ReadLine();

            if (word1 == null)
            {
                word1 = "";
            }

            if (word2 == null)
            {
                word2 = "";
            }

            return MergeAlternately(word1, word2);
        }

        public static string MergeAlternately(string word1, string word2)
        {
            int maxLength = Math.Max(word1.Length, word2.Length);
            string mergedString = "";

            for (int i = 0; i < maxLength; i++)
            {
                if (word1.Length > i)
                {
                    mergedString += word1[i];
                }
                if (word2.Length > i)
                {
                    mergedString += word2[i];
                }
            }

            return mergedString;
        }
    }
}
