using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class FindAllDuplicatesinanArray
    {
        public static IList<int> FindDuplicates(int[] nums)
        {
            List<int> result = new List<int>();
            var hash = new HashSet<int>();
            foreach(var i in nums)
            {
                if (!hash.Add(i))
                    result.Add(i);
            }
            return result;
        }
    }
}
