using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class LongestIncreasingPathInAMatrix
    {
        private static int result = 0;
        public static int LongestIncreasingPath(int[][] matrix)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            int[,] dp = new int[n, m];

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    DFS(matrix, i, j, dp, 0);

            return result;
        }

        private static void DFS(int[][] matrix, int i, int j, int[,] dp, int currentLength)
        {
            currentLength++;

            if (dp[i, j] >= currentLength)
                return;
            else
            {
                dp[i, j] = currentLength;
                result = Math.Max(result, currentLength);
            }

            if (i - 1 > -1 && matrix[i - 1][j] > matrix[i][j])
                DFS(matrix, i - 1, j, dp, currentLength);

            if (j - 1 > -1 && matrix[i][j - 1] > matrix[i][j])
                DFS(matrix, i, j - 1, dp, currentLength);

            if (i + 1 < matrix.Length && matrix[i + 1][j] > matrix[i][j])
                DFS(matrix, i + 1, j, dp, currentLength);

            if (j + 1 < matrix[0].Length && matrix[i][j + 1] > matrix[i][j])
                DFS(matrix, i, j + 1, dp, currentLength);
            
        }
    }
}
