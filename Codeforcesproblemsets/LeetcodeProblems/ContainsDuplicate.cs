using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class ContainsDuplicate
    {
        public static bool ContainsDuplicateFunc(int[] nums)
        {
            var hash = new HashSet<int>();
            foreach (var item in nums)
                if (!hash.Add(item)) return true;
            return false;

            //
            //if (hash.Contains(item))
            //    return true;
            //else
            //    hash.Add(item);
        }
    }
}
