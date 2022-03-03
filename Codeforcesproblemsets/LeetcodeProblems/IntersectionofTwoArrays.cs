using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class IntersectionofTwoArrays
    {
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            var setOne = new HashSet<int>(nums1);
            var result = new HashSet<int>();
            foreach (var num in nums2)
            {
                if (setOne.Contains(num))
                    result.Add(num);
            }

            return result.ToArray();
        }
    }
}
