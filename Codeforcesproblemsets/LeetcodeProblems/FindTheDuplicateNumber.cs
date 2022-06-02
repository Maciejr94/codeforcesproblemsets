using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class FindTheDuplicateNumber
    {
        //public static int FindDuplicate(int[] nums)
        //{
        //    HashSet<int> temp = new HashSet<int>();
        //    foreach(var item in nums)
        //    {
        //        if (!temp.Contains(item))
        //            temp.Add(item);
        //        else
        //            return item;

        //    }
        //    return -1;
        //}

        public static int FindDuplicate(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            int n = nums.Length - 1; // numbers in [1, n]

            int left = 1;
            int right = nums.Length;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                int cnt = 0;
                foreach (var num in nums)
                {
                    if (num <= mid)
                    {
                        cnt++;
                    }
                }
                if (cnt <= mid)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            return right;
        }
    }


    
}


