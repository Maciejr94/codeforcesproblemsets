using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class MinimumRemoveToMakeValidParentheses
    {
        public static string MinRemoveToMakeValid(string s)
        {
            Stack<(char character, int index)> stack = new Stack<(char c, int index)>();

            for (int i = 0; i < s.Length; i++)
            {
                if (stack.Count > 0 && stack.Peek().character == '(' && s[i] == ')')
                    stack.Pop();
                else if (s[i] == '(' || s[i] == ')')
                    stack.Push((s[i], i));
            }

            StringBuilder result = new StringBuilder(s);
            foreach (var item in stack)
                result = result.Remove(item.index, 1);

            return result.ToString();
        }
    }
}
