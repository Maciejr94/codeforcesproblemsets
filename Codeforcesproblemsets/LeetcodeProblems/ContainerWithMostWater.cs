using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class ContainerWithMostWater
    {
        public static int MaxArea(int[] height)
        {
            int result = int.MinValue;
            int i = 0;
            int j = height.Length - 1;

            while (i < j)
            {
                int n = Math.Min(height[i], height[j]);
                result = Math.Max(result, (j - i) * n);

                if (height[i] <= height[j])
                    i++;
                else
                    j--;
            }

            return result;


            // Time Limit Exceeded
            //
            //
            //int result = int.MinValue;
            //for (int i = 0; i < height.Length; i++)
            //{
            //    for (int j = i + 1; j < height.Length; j++)
            //    {
            //        int n = Math.Min(height[i], height[j]);
            //        result = Math.Max(result, (j - i) * n);
            //    }
            //}
            //return result;
        }
    }
}
