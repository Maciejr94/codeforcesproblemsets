using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class SearchInRotatedSortedArrayII
    {
        //public bool Search(int[] nums, int target)
        //{
        //    foreach (var item in nums)
        //        if (item == target)
        //            return true;

        //    return false;
        //}
        public static bool Search(int[] nums, int target)
        {
                int left = 0;
                int right = nums.Length - 1;
                int mid;
                while (left <= right)
                {
                    mid = left + (right - left) / 2;
                    if (nums[mid] == target)
                        return true;

                    if (nums[left] < nums[mid])
                    {
                        if (nums[left] <= target && target < nums[mid])
                        {
                            right = mid - 1;
                        }
                        else
                        {
                            left = mid + 1;
                        }
                    }
                    else if (nums[left] > nums[mid])
                    {
                        if (nums[mid] < target && target <= nums[right])
                        {
                            left = mid + 1;
                        }
                        else
                        {
                            right = mid - 1;
                        }
                    }
                    else
                        left++;
                }
                return false;
            
        }
    }
}
