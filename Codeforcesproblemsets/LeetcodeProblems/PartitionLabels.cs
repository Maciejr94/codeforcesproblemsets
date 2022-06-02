using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    class PartitionLabels
    {
        public static IList<int> PartitionLabelsFunc(string s)
        {
            List<int> results = new List<int>();
            //List<string> tempRes = new List<string>();
            //int[] count = new int[26];
            //for (int i = 0; i < s.Length; i++)
            //    count[s[i] - 'a']++;

            int[] last = new int[26];
            for (int i = 0; i < s.Length; ++i)
                last[s[i] - 'a'] = i;

            int begin = 0;
            int end = 0;
            for (int i = 0; i < s.Length; ++i)
            {
                char c = s[i];
                int temp = last[c - 'a'];
                end = Math.Max(end, temp);
                if (i == end)
                {
                    results.Add(end - begin + 1);
                    begin = end + 1;
                }
            }



                return results;
        }
    }
}
