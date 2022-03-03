using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    static public class SearchInsertPosition
    {
        public static int SearchInsert(int[] nums, int target)
        {
            int l = 0;
            int r = nums.Length - 1;
            while(l <= r)
            {
                int M = l + (r - l) / 2;
                if (nums[M] == target)
                    return M;
                if (nums[M] > target)
                    r = M - 1;
                if (nums[M] < target)
                    l = M + 1;
            }

            return l;
        }
    }
}
