using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class SpiralMatrixII
    {
        public static int[][] GenerateMatrix(int n)
        {
            int[][] result = new int[n][];
            for (int i = 0; i < result.Length; i++)
                result[i] = new int[n];

            int left = 0;
            int right = result[0].Length;
            int top = 0;
            int bottom = result.Length;
            int cnt = 1;

            while (left < right && top < bottom)
            {
                for(int i = left; i < right; i++)
                {
                    result[top][i] = cnt;
                    cnt++;
                }
                top++;

                for(int i = top; i < bottom; i++)
                {
                    result[i][right - 1] = cnt;
                    cnt++;
                }
                right--;

                //if (left > right && top > bottom)
                 //   break;

                for (int i = right - 1; i > left - 1; i--)
                {
                    result[bottom - 1][i] = cnt;
                    cnt++;
                }
                bottom--;

                for (int i = bottom - 1; i > top - 1; i--){
                    result[i][left] = cnt;
                    cnt++;
                }
                left++;
            }


            //int cnt = 1;
            //for (int layer = 0; layer < (n + 1) / 2; layer++)
            //{
            //    for (int ptr = layer; ptr < n - layer; ptr++)
            //    {
            //        result[layer][ptr] = cnt++;
            //    }
            //    for (int ptr = layer + 1; ptr < n - layer; ptr++)
            //    {
            //        result[ptr][n - layer - 1] = cnt++;
            //    }
            //    for (int ptr = n - layer - 2; ptr >= layer; ptr--)
            //    {
            //        result[n - layer - 1][ptr] = cnt++;
            //    }
            //    for (int ptr = n - layer - 2; ptr > layer; ptr--)
            //    {
            //        result[ptr][layer] = cnt++;
            //    }
            //}
            return result;
        }
    }




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
}
