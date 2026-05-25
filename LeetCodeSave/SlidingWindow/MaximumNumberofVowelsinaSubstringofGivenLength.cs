using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSave.SlidingWindow
{
    public class MaximumNumberofVowelsinaSubstringofGivenLength
    {
        public static string ExecuteSolution(int k)
        {
            Console.WriteLine("15: Maximum Number of Vowels in a Substring of Given Length");
            Console.WriteLine("Enter the string: ");
            string? word = Console.ReadLine();

            if (word == null)
            {
                word = "";
            }

            return MaxVowels(word, k).ToString();
        }

        public static int MaxVowels(string s, int k)
        {
            int vowelCount = 0;
            int leftVowelIndex = 0;
            for (int i = 0; i < k; i++)
            {
                if (IsVowel(s[i]))
                {
                    vowelCount++;
                }
            }
            int maxVowelCount = vowelCount;
            for (int i = k; i < s.Length; i++)
            {
                if (IsVowel(s[i]))
                {
                    vowelCount++;
                }
                if (IsVowel(s[leftVowelIndex]))
                {
                    vowelCount--;
                }
                leftVowelIndex++;

                if (vowelCount > maxVowelCount)
                {
                    maxVowelCount = vowelCount;
                }
            }

            return maxVowelCount;
        }


        public static bool IsVowel(char c)
        {
            return (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U');
        }
    }
}
