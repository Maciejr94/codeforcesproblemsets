using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class NextPermutation
    {
        public static void NextPermutationFunc(int[] nums)
        {
            int i = nums.Length - 2;
            while (i >= 0 && nums[i + 1] <= nums[i])
                i--;

            if( i >= 0)
            {
                int j = nums.Length - 1;
                while (nums[j] <= nums[i])
                    j--;

                swap(nums, i, j);
            }
            reverse(nums, i + 1);
        }
        
        private static void reverse(int[] nums, int start)
        {
            int i = start;
            int j = nums.Length - 1;
            while( i < j)
            {
                swap(nums, i, j);
                i++;
                j--;
            }
        }

        private static void swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
