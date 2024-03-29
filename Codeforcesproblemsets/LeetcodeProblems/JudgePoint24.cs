﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class JudgePoint24
    {
        private static char[] operators = new char[] { '+', '-', '*', '/' };
        public static bool Game24(int[] cards)
        {
            double[] n = new double[4];
            for (int i = 0; i < 4; i++)
                n[i] = cards[i];
            return dfs(n);
        }
        private static bool dfs(double[] nums)
        {
            int n = nums.Length;
            if (n == 1)
                return Math.Abs(nums[0] - 24) < 0.001;

            double[] left = new double[n - 1];
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    double a = nums[i];
                    double b = nums[j];

                    for (int k = 0, l = 0; k < n; k++)
                    {
                        if (k != i && k != j)
                        {
                            left[l] = nums[k];
                            l++;
                        }
                    }

                    left[n - 2] = a + b;
                    if (dfs(left))
                        return true;

                    left[n - 2] = a - b;
                    if (dfs(left))
                        return true;

                    left[n - 2] = a * b;
                    if (dfs(left))
                        return true;

                    left[n - 2] = a / b;
                    if (dfs(left))
                        return true;

                    left[n - 2] = b - a;
                    if (dfs(left))
                        return true;

                    left[n - 2] = b / a;
                    if (dfs(left))
                        return true;
                }
            }

            return false;
        }

    }
}
