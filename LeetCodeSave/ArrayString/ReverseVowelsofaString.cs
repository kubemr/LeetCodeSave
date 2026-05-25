using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSave.ArrayString
{
    public class ReverseVowelsofaString
    {
        public static string ExecuteSolution()
        {
            Console.WriteLine("5: Reverse Vowels of a String");
            Console.WriteLine("Enter the string: ");
            string? word = Console.ReadLine();

            if (word == null)
            {
                word = "";
            }

            return ReverseVowels(word);
        }

        public static string ReverseVowels(string s)
        {
            StringBuilder result = new(s);
            List<(int, char)> indexedChars = [];
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' ||  c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                {
                    indexedChars.Add((i, c));
                }
            }

            for (int i = 0; i < indexedChars.Count; i++)
            {
                var index = indexedChars[i].Item1;
                result[index] = indexedChars[indexedChars.Count - i - 1].Item2;
            }

            return result.ToString();
        }
    }
}
