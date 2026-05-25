using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSave.ArrayString
{
    public class StringCompression
    {
        public static string ExecuteSolution(char[] chars)
        {
            Console.WriteLine("9: String Compression");
            Console.Write("Array: [");
            foreach (var character in chars)
            {
                Console.Write(character + "; ");
            }
            Console.WriteLine("]");
            int result = Compress(chars);
            string output = result.ToString();
            return output;
        }

        public static int Compress(char[] chars)
        {
            int index = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                char ch = chars[i];
                int cnt = 0;
                while (i < chars.Length && chars[i] == ch)
                {
                    cnt++;
                    i++;
                }
                chars[index++] = ch;
                if (cnt > 1)
                {
                    foreach (char digit in cnt.ToString())
                    {
                        chars[index++] = digit;
                    }
                }
                i--;
            }
            Array.Resize(ref chars, index);
            return index;
        }
    }
}
