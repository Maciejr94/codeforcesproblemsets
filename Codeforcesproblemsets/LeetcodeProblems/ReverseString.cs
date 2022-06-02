using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class ReverseString
    {
        public static void ReverseStringFunc(char[] s)
        {
            //two pointer
            int left = 0;
            int right = s.Length - 1;
            while (left <= right)
            {
                char temp = s[left];
                s[left] = s[right];
                s[right] = temp;
                left++;
                right--;
            }

            //stack
            //int n = s.Length;
            //Stack<char> stack = new Stack<char>();
            //foreach (var item in s)
            //    stack.Push(item);

            //s = new char[n];
            //int i = 0;
            //while(stack.Count != 0)
            //{
            //    s[i] = stack.Pop();
            //    i++;
            //}

        }
    }
}
