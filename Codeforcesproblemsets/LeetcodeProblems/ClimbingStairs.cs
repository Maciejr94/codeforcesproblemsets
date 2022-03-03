using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class ClimbingStairs
    {
        public static int ClimbStairsDP(int n)
        {
            if (n <= 2)
                return n;

            int[] arr = new int[n + 1];
            arr[1] = 1;
            arr[2] = 2;

            for(int i = 3; i <= n; i++)
                arr[i] = arr[i - 1] + arr[i - 2];

            return arr[n];
        }

        public static int ClimbStairsFibb(int n)
        {
            if (n <= 2)
                return n;

            int res = 0;
            int a = 1; int b = 2;
            
            for(int i = 3; i <= n; i++)
            {
                res = a + b;
                a = b;
                b = res;
            }
            return res;
        }
    }
}
