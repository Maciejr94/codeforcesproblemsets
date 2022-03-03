using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class MaximumSubarray
    {
        //Kadane's Algorithm
        public static int MaxSubArray(int[] nums)
        {
            int max_global = nums[0];
            int max_current = nums[0];
            for(int i = 1; i <= nums.Length - 1; i++)
            {
                max_current = Math.Max(nums[i], max_current + nums[i]);
                if (max_current > max_global)
                    max_global = max_current;
            }
            return max_global;



           
        }
    }
}
