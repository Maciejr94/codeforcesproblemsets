using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class DeleteAndEarn
    {
        public static int DeleteAndEarnFunc(int[] nums)
        {
 
            /* 1 */
            int[] count = new int[10001];

            foreach (var num in nums)
            {
                count[num] += num;
            }

            int next = 0;
            int previous = 0;
            int current = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                next = Math.Max(previous + nums[i], current);
                previous = current;
                current = next;
            }

            return next;

            
            
            
            /* 2 */
            //int[] arr = new int[10001];
            //int[] dp = new int[10001];

            //foreach (var num in nums) 
            //    arr[num] += num;

            //dp[1] = arr[1];
            //for (var i = 2; i < 10001; i++) 
            //    dp[i] = Math.Max(dp[i - 1], dp[i - 2] + arr[i]);

            //Console.WriteLine(dp[10000]);
            //return dp[10000];
            
            
            
            
            
            
            /* 3 */
            //int max = 0;
            //foreach(var num in nums)
            //    max = Math.Max(num, max);

            //int[] count = new int[max+1];

            //foreach (var num in nums)
            //    count[num] += num;


            //for(int i = count.Length - 3; i >= 0; i--)
            //{
            //    count[i] = Math.Max(count[i + 1], count[i] + count[i + 2]);
            //}

            //return count[0];
        }
    }
}
