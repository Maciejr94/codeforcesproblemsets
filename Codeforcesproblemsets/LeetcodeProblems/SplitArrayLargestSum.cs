using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class SplitArrayLargestSum
    {
        public static int[,] memo = new int[1001,51];
        #region DP?
        public static int SplitArray(int[] nums, int m)
        {
            int n = nums.Length;
            int[] prefixSum = new int[n + 1];
            for (int i = 0; i < n; i++)
                prefixSum[i + 1] = prefixSum[i] + nums[i];



            return getMinimumLargestSplitSum(prefixSum, 0, m);
        }

        private static int getMinimumLargestSplitSum(int[] prefixSum, int currIndex, int subarrayCount)
        {
            int n = prefixSum.Length - 1;
            if (memo[currIndex,subarrayCount] != 0)
            {
                return memo[currIndex,subarrayCount];
            }

            if (subarrayCount == 1)
            {
                return memo[currIndex,subarrayCount] = prefixSum[n] - prefixSum[currIndex];
            }

            int minimumLargestSplitSum = int.MaxValue;
            for (int i = currIndex; i <= n - subarrayCount; i++)
            {
                int firstSplitSum = prefixSum[i + 1] - prefixSum[currIndex];
                int largestSplitSum = Math.Max(firstSplitSum, getMinimumLargestSplitSum(prefixSum, i + 1, subarrayCount - 1));
                minimumLargestSplitSum = Math.Min(minimumLargestSplitSum, largestSplitSum);
                if (firstSplitSum >= minimumLargestSplitSum)
                    break;
            }

            return memo[currIndex,subarrayCount] = minimumLargestSplitSum;
        }
        #endregion
        #region binary search
        //public static int SplitArray(int[] nums, int m)
        //{

        //    int left = 0, right = 0;
        //    foreach (var num in nums)
        //    {
        //        left = Math.Max(left, num);
        //        right += num;
        //    }

        //    while (left < right)
        //    {
        //        int mid = (right - left) / 2 + left;
        //        if (canSplit(nums, mid, m))
        //            right = mid;
        //        else
        //            left = mid + 1;
        //    }

        //    return left;
        //}

        //private static bool canSplit(int[] nums, int maxSum, int m)
        //{
        //    int numOfSubarrays = 1, currSum = 0;
        //    foreach (var num in nums)
        //    {
        //        if (currSum + num > maxSum)
        //        {
        //            numOfSubarrays++;
        //            currSum = 0;
        //        }

        //        currSum += num;
        //        if (numOfSubarrays > m)
        //            return false;
        //    }

        //    return true;
        //}
        #endregion
    }
}

