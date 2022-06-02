using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class TwoCityScheduling
    {
        public static int TwoCitySchedCost(int[][] costs)
        {
            int result = 0;
            var sorted = costs.OrderBy(x => x[0] - x[1]).ToArray();

            for (int i = 0; i < sorted.Length; i++)
            {
                if (i < sorted.Length / 2)
                    result += sorted[i][0];
                else
                    result += sorted[i][1];
            }

            return 0;
        }

    }
}
