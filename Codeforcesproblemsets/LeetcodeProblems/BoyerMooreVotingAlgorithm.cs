using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class BoyerMooreVotingAlgorithm
    {
        public static int MajorityElement(int[] nums)
        {
            int count = 0;
            int candidate = 0;

            foreach(var num in nums)
            {
                if (count == 0)
                {
                    candidate = num;
                }
                count += (num == candidate) ? 1 : -1;
            }

            return candidate;
        }




        // 229. Majority Element II
        // Given an integer array of size n, find all elements that appear more than ⌊ n/3 ⌋ times.

        //public IList<int> MajorityElement(int[] nums)
        //{
        //    Dictionary<int, int> dict = new Dictionary<int, int>();
        //    List<int> result = new List<int>();
        //    int n = nums.Length / 3;

        //    foreach (var num in nums)
        //    {
        //        if (!dict.ContainsKey(num))
        //            dict.Add(num, 1);
        //        else
        //            dict[num]++;
        //    }

        //    foreach (var dic in dict)
        //    {
        //        if (dic.Value > n)
        //            result.Add(dic.Key);
        //    }

        //    return result;
        //}
    }
}
