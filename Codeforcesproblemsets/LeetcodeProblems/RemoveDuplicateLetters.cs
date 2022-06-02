using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class RemoveDuplicateLetters
    {
        public static string RemoveDuplicateLettersFunc(string s)
        {
            int[] count = new int[26];
            for (int i = 0; i < s.Length; i++)
                count[s[i] - 'a']++;

            var sb = new StringBuilder();
            var visited = new HashSet<char>();
            for (int i = 0; i < s.Length; i++)
            {
                count[s[i] - 'a']--;
                if (visited.Contains(s[i]))
                    continue;

                while (sb.Length > 0 && sb[sb.Length - 1] > s[i] && count[sb[sb.Length - 1] - 'a'] > 0)
                {
                    visited.Remove(sb[sb.Length - 1]);
                    sb.Length--;
                }

                visited.Add(s[i]);
                sb.Append(s[i]);
            }

            return sb.ToString();
        }
        
    }
}
