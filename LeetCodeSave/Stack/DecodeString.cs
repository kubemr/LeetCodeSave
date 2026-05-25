using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSave.Stack
{
    public class DecodeString
    {
        public static string ExecuteSolution(string s)
        {
            Console.WriteLine("26: Decode String : " + s);
            return DecodeStringA(s);
        }

        public static string DecodeStringA(string s)
        {
            string result = "";
            int num = 0;
            int index = 0;

            while (index < s.Length)
            {
                if (s[index] == '[')
                {
                    index++;
                    result += DecodeSegment(s, num, ref index);
                    num = 0;
                    continue;
                }

                if (int.TryParse(s[index].ToString(), out int n))
                {
                    num *= 10;
                    num += n;
                    index++;
                    continue;
                }

                result += s[index]; 
                index++;
            }
            return result;
        }

        public static string DecodeSegment(string encodedString, int num, ref int index)
        {
            string subresult = "";
            string result = "";
            int subnum = 0;
            while (encodedString[index] != ']')
            {
                if (int.TryParse(encodedString[index].ToString(), out int n))
                {
                    subnum *= 10;
                    subnum += n;
                    index++;
                    continue;
                }

                if (encodedString[index] == '[')
                {
                    index++;
                    subresult += DecodeSegment(encodedString, subnum, ref index);
                    subnum = 0;
                    continue;
                }
                subresult += encodedString[index];
                index++;
            }

            for (int i = 0; i < num; i++) 
                result += subresult;
            index++;
            return result;
        }

    }
}
