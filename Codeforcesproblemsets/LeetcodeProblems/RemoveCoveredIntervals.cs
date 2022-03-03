using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class RemoveCoveredIntervals
    {
        public static int RemoveCoveredIntervalsFunc(int[][] intervals)
        {
            int counting = 0;
            
            Array.Sort(intervals, (a, b) => {
                int k = a[0].CompareTo(b[0]);
                return k != 0 ? k : b[1].CompareTo(a[1]);
            });

            int[] curr = intervals[0];
            for (int i = 1; i < intervals.Length; i++)
            {
                if (curr[0] <= intervals[i][0] && intervals[i][1] <= curr[1])
                {
                    counting++;
                }
                else
                {
                    curr = intervals[i];
                }
            }
            

            return intervals.Length-counting;
        }
    }
}
