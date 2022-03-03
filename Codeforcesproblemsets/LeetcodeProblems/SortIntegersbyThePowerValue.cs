using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
        //if x is even then x = x / 2
        //if x is odd then x = 3 * x + 1
        //For example, the power of x = 3 is 7 because 3 needs 7 steps to become 1 (3 --> 10 --> 5 --> 16 --> 8 --> 4 --> 2 --> 1).
    public static class SortIntegersbyThePowerValue
    {
        public static int GetKth(int lo, int hi, int k)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            for(int i = lo; i <= hi; i++)
            {
                result.Add(i,DoMath(i));
            }
            result = result.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            return result.ElementAt(k-1).Key;
        }

        private static int DoMath(int num)
        {
            int steps = 0;
            while(num != 1)
            {
                if(num % 2 == 0)
                {
                    num = num / 2;
                } else
                {
                    num = num * 3 + 1;
                }
                steps++;
            }
            return steps;
        }
    }
}
