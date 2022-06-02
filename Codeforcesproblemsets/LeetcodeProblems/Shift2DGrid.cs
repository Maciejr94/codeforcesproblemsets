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
            #region fast list solution
            int rowLen = grid.Length;
            int colLen = grid[0].Length;
            var res = new List<IList<int>>();
            foreach (var r in grid)
                res.Add(r.ToList());
            k %= rowLen * colLen;
            while (k-- > 0)
            {
                int temp = res[rowLen - 1][colLen - 1];
                for (int i = 0; i < rowLen; i++)
                {
                    res[i].Insert(0, temp);
                    temp = res[i].Last();
                    res[i].RemoveAt(res[i].Count - 1);
                }
            }
            return res;
            #endregion





            #region 2d array to 1d array
            //int m = grid.Length;
            //int n = grid[0].Length;
            //int totalSize = m * n;
            ////2d to 1d array
            //int[] tempArray = new int[totalSize];
            //int index = 0;

            //for (int i = 0; i < grid.Length; i++)
            //{
            //    for (int j = 0; j < grid[0].Length; j++)
            //    {
            //        tempArray[(index + k) % totalSize] = grid[i][j];
            //        index++;
            //    }
            //}
            ////1d to 2d array/list
            //List<IList<int>> result = new List<IList<int>>();
            //for (int i = 0; i < grid.Length; i++)
            //{
            //    List<int> cur = new List<int>();
            //    for (int j = 0; j < grid[0].Length; j++)
            //    {
            //        cur.Add(tempArray[i * grid[0].Length + j]);
            //    }
            //    result.Add(cur);
            //}


            //return result;
            #endregion
        }
    }
}
