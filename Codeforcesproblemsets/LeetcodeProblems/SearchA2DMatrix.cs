using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class SearchA2DMatrix
    {
        // from behind
        //public static bool SearchMatrix(int[][] matrix, int target)
        //{
        //var n = matrix.Length;

        //    if (n == 0)
        //    {
        //        return false;
        //    }
        //    var m = matrix[0].Length;

        //var i = n - 1;
        //var j = 0;

        //    while (i >= 0 && j<m)
        //    {
        //        if (matrix[i][j] == target)
        //        {
        //            return true;
        //        }
        //        else if (matrix[i][j] > target)
        //        {
        //            i--;
        //        }
        //        else
        //        {
        //            j++;
        //        }
        //    }

        //    return false;
//}

        public static bool SearchMatrix(int[][] matrix, int target)
        {
            var n = matrix.Length;
            if (n == 0)
                return false;

            var m = matrix[0].Length;
            if (m == 0)
                return false;

            var left = 0;
            var right = n * m - 1;

            while (left <= right)
            {
                var mid = (left + right) / 2;
                var i = mid / m;
                var j = mid % m;

                if (matrix[i][j] == target)
                    return true;
                if (matrix[i][j] < target)
                    left = mid + 1;
                if (matrix[i][j] > target)
                    right = mid - 1;
            }

            return false;
        }
      
    }

}
