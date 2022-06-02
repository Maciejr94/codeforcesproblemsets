using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class CheckIfAStringContainsAllBinaryCodesOfSizeK
    {
        public static bool HasAllCodes(string s, int k)
        {
            int need = 1 << k;
            HashSet<string> visited = new HashSet<string>();
            for (int i = k; i <= s.Length; i++)
            {
                string a = s.Substring(i - k, k);
                if (!visited.Contains(a))
                {
                    visited.Add(a);
                    need--;
                    if (need == 0)
                        return true;
                }
            }
            return false;
                //HashSet<string> visited = new HashSet<string>();
                //int total = (int)Math.Pow(2, k);

                //for (int i = 0; i < s.Length - k + 1; i++)
                //{
                //    string subString = s.Substring(i, k);
                //    visited.Add(subString);
                //}

                //return visited.Count == total;

                //var total = Math.Pow(2, k);
                //HashSet<string> visited = new HashSet<string>();

                //for (int i = k; i <= s.Length; i++)
                //{
                //    string subStr = s.Substring(i - k, k);
                //    if (!visited.Contains(subStr))
                //    {
                //        visited.Add(subStr);
                //        if (visited.Count == total) return true;
                //    }
                //}

                //return false;
             }
    }
}
