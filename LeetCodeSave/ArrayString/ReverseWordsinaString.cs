using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSave.ArrayString
{
    public class ReverseWordsinaString
    {
        public static string ExecuteSolution()
        {
            Console.WriteLine("6: Reverse Words of a String");
            Console.WriteLine("Enter the string: ");
            string? word = Console.ReadLine();

            if (word == null)
            {
                word = "";
            }

            return ReverseWords(word);
        }

        public static string ReverseWords(string s)
        {
            string result = "";
            string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = words.Length - 1; i >= 0; i--)
            {
                result += words[i] + " ";
            }
            result = result.Remove(result.Length - 1, 1);
            return result;
        }
    }
}
