using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class Permutations
    {
        public static IList<IList<int>> Permute(int[] nums)
        {
            List<IList<int>> res = new List<IList<int>>();
            Reroll(nums, new List<int>(), res);
            return res;

        }

        private static void Reroll(int[] nums, List<int> list, List<IList<int>> res)
        {
            if (list.Count == nums.Length)
            {
                res.Add(new List<int>(list));
                return;
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (list.Contains(nums[i]))
                        continue;
                    list.Add(nums[i]);
                    Reroll(nums, list, res);
                    list.RemoveAt(list.Count - 1);
                }
            }
        }
    }
}
