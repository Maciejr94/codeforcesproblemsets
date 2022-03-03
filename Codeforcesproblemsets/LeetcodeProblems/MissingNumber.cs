using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class MissingNumber
    {
        public static int MissingNumberFunc(int[] nums)
        {
            int[] arr = new int[nums.Length+1];
            for(int i = 0; i < nums.Length; i++)
            {
                arr[nums[i]]++;
            }
            return arr.Select((s, i) => new { i, s })
                        .Where(t => t.s == 0)
                            .Select(t => t.i)
                            .First();
        }
    }
}
