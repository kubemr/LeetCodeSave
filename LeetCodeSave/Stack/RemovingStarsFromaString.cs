using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSave.Stack
{
    public class RemovingStarsFromaString
    {
        public static string ExecuteSolution()
        {
            Console.WriteLine("24: Removing Stars From a String");
            Console.WriteLine("Enter the string: ");
            string? word = Console.ReadLine();

            if (word == null)
            {
                word = "";
            }

            return RemoveStars(word);
        }

        public static string RemoveStars(string s)
        {
            Stack<char> stack = new();
            string result = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '*')
                {
                    stack.Pop();
                } else
                    stack.Push(s[i]);
            }
            while (stack.Count != 0)
            {
                result = stack.First() + result;
                stack.Pop();
            }
            return result;
        }
    }
}
