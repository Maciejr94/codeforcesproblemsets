using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class CoinChange
    {
        public static int CoinChangeFunc(int[] coins, int amount)
        {

            int[] dp = new int[amount + 1];
            dp[0] = 0;

            for(int i = 1; i <= amount; i++)
            {
                dp[i] = int.MaxValue;
                foreach(var coin in coins)
                {
                    if (i - coin >= 0 && dp[i - coin] != int.MaxValue)
                        dp[i] = Math.Min(dp[i], 1 + dp[i - coin]);
                }
            }
            return dp[amount] == int.MaxValue ? -1 : dp[amount];
        }
    }
}
