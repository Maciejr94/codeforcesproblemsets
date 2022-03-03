using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class Duplicates
    {
        public static string RemoveDuplicates(string s)
        {
            List<char> list = new List<char>();
            for(int i = 0; i < s.Length; i++)
            {
                if (list.Count == 0)
                    list.Add(s[i]);
                else
                {
                    if (list[list.Count - 1] == s[i])
                    {
                        list.RemoveAt(list.Count - 1);
                    }
                    else
                    {
                        list.Add(s[i]);
                    }
                }
            }

            return string.Join("", list);
        }
    }
}
