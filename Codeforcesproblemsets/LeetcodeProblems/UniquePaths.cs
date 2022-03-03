using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class UniquePaths
    {
        public static int UniquePathsFunc(int m, int n)
        {
            int[,] result = new int[m, n];
            
            //seed
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (i == 0)
                        result[0, j] = 1;
                    if (j == 0)
                        result[i, 0] = 1;
                }
            }
            
            for(int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    result[i, j] = result[i, j - 1] + result[i - 1, j];
                }
            }

            return result[m - 1, n - 1];
        }
    }
}
