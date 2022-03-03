using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class BestTimetoBuyandSellStock
    {
        public static int MaxProfit(int[] prices)
        {
            int result = 0;
            int diff = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < diff)
                    diff = prices[i];
                else if (prices[i] - diff > result)
                    result = prices[i] - diff;
            }

            #region brutal force działa ale duzo pamieci needed
            //int result = 0;
            //for(int i = 0; i < prices.Length; i++)
            //{
            //    for(int j = i + 1; j < prices.Length; j++)
            //    {
            //        int temp = prices[j] - prices[i];
            //        if (temp > 0 && temp > result)
            //            result = temp;
            //    }
            //}
            #endregion
            return result;
        }
    }
}
