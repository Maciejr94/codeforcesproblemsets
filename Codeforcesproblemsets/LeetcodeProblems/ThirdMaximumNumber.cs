using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class ThirdMaximumNumber
    {
        public static int ThirdMax(int[] nums)
        {
            var a = new HashSet<int>(nums).OrderByDescending(x => x).ToList();

            if (a.Count >= 3)
                return a[2];

            return a[0];
        }
    }
}
