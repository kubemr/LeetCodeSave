using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSave.HashMapSet
{
    public class EqualRowandColumnPairs
    {
        public static string ExecuteSolution(int[][] nums)
        {
            Console.WriteLine("23: Equal Row and Column Pairs");
            Console.WriteLine("Matrix:");
            foreach (var numA in nums)
            {
                Console.Write("[ ");
                foreach (var num in numA)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine("]");
            }
            return EqualPairs(nums).ToString();
        }

        public static int EqualPairs(int[][] grid)
        {
            int equalRC = 0;
            Dictionary<int, int[]> rows = [];
            Dictionary<int, int[]> columns = [];
            for (int i = 0; i < grid.Length; i++)
            {
                int[] row = new int[grid.Length];
                int[] col = new int[grid.Length];
                for (int j = 0;  j < grid[i].Length; j++)
                {
                    row[j] = grid[i][j];
                    col[j] = grid[j][i];
                }
                rows.Add(i, row);
                columns.Add(i, col);
            }

            foreach(var row in rows)
            {
                foreach (var col in columns)
                {
                    if (row.Value.SequenceEqual(col.Value))
                    {
                        equalRC++;
                    }
                }
            }
            return equalRC;

        }
    }
}
