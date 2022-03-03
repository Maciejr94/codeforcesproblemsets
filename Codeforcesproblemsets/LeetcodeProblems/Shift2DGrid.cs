using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class Shift2DGrid
    {
        public static IList<IList<int>> ShiftGrid(int[][] grid, int k)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            int totalSize = m * n;
            //2d to 1d array
            int[] tempArray = new int[totalSize];
            int index = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    tempArray[(index + k) % totalSize] = grid[i][j];
                    index++;
                }
            }
            //1d to 2d array/list
            List<IList<int>> result = new List<IList<int>>();
            for (int i = 0; i < grid.Length; i++)
            {
                List<int> cur = new List<int>();
                for (int j = 0; j < grid[0].Length; j++)
                {
                    cur.Add(tempArray[i * grid[0].Length + j]);
                }
                result.Add(cur);
            }


            return result;
        }
    }
}
