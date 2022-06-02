using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class SmallestStringWithAGivenNumericValue
    {
        public static string GetSmallestString(int n, int k)
        {
            char[] carr = new char[n];
            while (n > 0)
            {
                var m = Math.Min(k - n + 1, 26);
                k -= m;
                carr[n - 1] = Convert.ToChar('a' + m - 1);
                n--;
            }
            return new string(carr);
        }
        //public static string GetSmallestString(int n, int k)
        //{
        //StringBuilder result = new StringBuilder();
        //    for (int i = 0; i<n; i++)
        //        result.Append('a');

        //    k -= n;

        //    for(int i = n - 1; i >= 0; i--)
        //    {
        //        if (k == 0)
        //            break;
        //        else if (k< 25)
        //        {
        //            result[i] = (char) ('a' + k);          
        //            k = 0;
        //        }
        //        else
        //        {
        //            result[i] = (char) ('a' + 25);
        //            k = k - 25;
        //        }
        //    }

        //    return result.ToString();
        //}


    }
}
