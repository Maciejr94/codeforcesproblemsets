using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class LastStoneWeight
    {
        public static int LastStoneWeightFunc(int[] stones)
        {
            #region array sort to list, do math, list to array
            if (stones.Length == 1)
                return stones[0];

            while (stones.Length > 1)
            {
                Array.Sort(stones);
                int n = stones.Length - 1;
                int m = n - 1;

                if (stones[n] == stones[m])
                {
                    List<int> list = new List<int>(stones);
                    list.RemoveAt(n);
                    list.RemoveAt(m);
                    stones = list.ToArray();
                }
                else
                {
                    int temp = stones[n] - stones[m];
                    stones[m] = temp;
                    List<int> list = new List<int>(stones);
                    list.RemoveAt(n);
                    stones = list.ToArray();
                }
            }
            return stones.Length > 0 ? stones[0] : 0;
            #endregion
            #region list solution
            //var list = stones.ToList();

            //while (list.Count() > 1)
            //{
            //    list = list.OrderByDescending(x => x).ToList();
            //    int f = list[0], s = list[1];
            //    if (f == s)
            //    {
            //        list.RemoveAt(0);
            //        list.RemoveAt(0);
            //    }
            //    else
            //    {
            //        list[1] = f - s;
            //        list.RemoveAt(0);
            //    }
            //}
            //return list.Count() > 0 ? list.First() : 0;
            #endregion
        }
    }
}
