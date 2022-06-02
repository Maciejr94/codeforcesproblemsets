using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class CountSortedVowelStrings
    {
        #region Using List
        //public static int CountVowelStrings(int n)
        //{
        //    if (n == 0)
        //        return 0;

        //    List<string> strings = new List<string>();
        //    char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u'};
        //    backtracking(n, vowels, strings, new StringBuilder(), 0);
        //    return strings.Count();
        //}

        //private static void backtracking(int n, char[] vowels, List<string> strings, StringBuilder temp, int count)
        //{
        //    if (n == 0)
        //    {
        //        strings.Add(temp.ToString());
        //        return;
        //    }

        //    for(int i = count; i < vowels.Length; i++)
        //    {
        //        temp.Append(vowels[i]);
        //        backtracking(n - 1, vowels, strings, temp, i);
        //        temp.Length = temp.Length - 1;

        //    }
        //}
        #endregion

        #region backtracking but only counting
        //public static int CountVowelStrings(int n)
        //{
        //    if (n == 0)
        //        return 0;

        //    int result = 0;
        //    //List<string> strings = new List<string>();
        //    //char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
        //    backtracking(n, 0, ref result);
        //    return result;
        //}

        //private static void backtracking(int n, int start, ref int result)
        //{
        //    if (n == 0)
        //    {
        //        result++;
        //        return;
        //    }

        //    for (int i = start; i < 5; i++)
        //    {
        //        backtracking(n - 1, i, ref result);
        //    }
        //}
        #endregion

        #region Dynamic Programming
        //public static int CountVowelStrings(int n)
        //{
        //    int[,] dp = new int[n, 5];

        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = 0; j < 5; j++)
        //        {
        //            if (j > 0)
        //            {
        //                dp[i, j] = dp[i, j - 1];
        //            }

        //            if (i > 0)
        //            {
        //                dp[i, j] += dp[i - 1, j];
        //            }
        //            else
        //            {
        //                dp[i, j] = j + 1;
        //            }

        //        }
        //    }

        //    return dp[n - 1, 4];
        //}
        #endregion

        #region Counting
        public static int CountVowelStrings(int n)
        {
            if (n == 0)
                return 0;

            int a = 1;
            int e = 1;
            int i = 1;
            int o = 1;
            int u = 1;

            for (int len = 1; len < n; len++)
            {
                a = a + e + i + o + u; // add 'a' to the beginning of all the existing strings
                e = e + i + o + u;     // add 'e' to the beginning of all the existing strings
                i = i + o + u;         // add 'i' to the beginning of all the existing strings
                o = o + u;             // add 'o' to the beginning of all the existing strings
                u = u;                 // add 'u' to the beginning of all the existing strings
            }

            return a + e + i + o + u;
        }
        #endregion
    }
}
