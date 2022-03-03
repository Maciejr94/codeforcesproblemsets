using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class UniqueOccurrences
    {
        public static bool UniqueOccurrencesFunc(int[] arr)
        {
            var result = false;
            var query = arr.GroupBy(x => x)
              .Select(y => y.Count())
              .ToList();
            
            result = query.Count() == query.Distinct().Count();
           
            return result;
        }
    }
}
