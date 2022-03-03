using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class ContainsDuplicateII
    {
        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                    dict.Add(nums[i], i);
                else
                {
                    if ((i - dict[nums[i]]) <= k)
                        return true;

                    dict[nums[i]] = i;
                }
            }
            return false;
        }
    }
}
