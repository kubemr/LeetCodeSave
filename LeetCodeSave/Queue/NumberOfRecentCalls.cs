using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSave.Queue
{
    public class NumberOfRecentCalls
    {
        public static string ExecuteSolution()
        {
            Console.WriteLine("27: Number of Recent Calls");
            RecentCounter obj = new RecentCounter();
            Console.WriteLine(obj.Ping(1));
            Console.WriteLine(obj.Ping(100));
            Console.WriteLine(obj.Ping(3001));
            Console.WriteLine(obj.Ping(3002));
            return "";
        }
    }

    public class RecentCounter
    {
        private static int[] records = new int[10000];
        private int start;
        private int end;

        public RecentCounter()
        {
            start = 0;
            end = 0;
        }

        public int Ping(int t)
        {
            while (start < end && (t - records[start] > 3000))
            {
                start++;
            }
            records[end++] = t;
            return end - start;
        }
    }
}
