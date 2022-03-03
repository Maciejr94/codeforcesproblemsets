using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class BrokenCalculator
    {
        public static int BrokenCalc(int X, int Y)
        {
            //[1]
            int ans = 0;
            while (Y > X)
            {
                ans++;
                if (Y % 2 == 0) Y /= 2;
                else Y += 1;
            }
            return ans + X - Y;

            // [2]
            //int result = 0;
            //while(X < Y)
            //{
            //    result++;
            //    if (X % 2 == 1) X *= 2;
            //    else X -= 1;
            //}
            //return result + X - Y;
        }
    }
}
