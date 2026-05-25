using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSave.HashMapSet
{
    public class DetermineifTwoStringsAreClose
    {
        public static string ExecuteSolution()
        {
            Console.WriteLine("22: Determine if Two Strings Are Close");
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

            return CloseStrings(word1, word2).ToString();
        }

        public static bool CloseStrings(string word1, string word2)
        {
            if(word1.Length != word2.Length) return false;

            int[] frequency1 = new int[26];
            int[] frequency2 = new int[26];

            for(int index=0; index<word1.Length; index++){
                frequency1[word1[index] - 'a']++;
                frequency2[word2[index] - 'a']++;
            }

            for(int index=0; index<26; index++){
                if(frequency1[index] == 0 && frequency2[index] != 0)
                    return false;
                if(frequency1[index] != 0 && frequency2[index] == 0)
                    return false;
            }

            Array.Sort(frequency1);
            Array.Sort(frequency2);

            return frequency1.SequenceEqual(frequency2);
        }
    }
}
