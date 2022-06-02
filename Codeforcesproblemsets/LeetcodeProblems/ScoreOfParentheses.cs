using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class ScoreOfParentheses
    {
        //public static int ScoreOfParenthesesFunc(string s)
        //{

        //    int result = 0;
        //    int counter = 0;
        //    //char[] array = s.ToCharArray();

        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        counter = s[i] == '(' ? counter + 1 : counter - 1;

        //        if (s[i] == ')' && s[i - 1] == '(')
        //        {
        //            result += (int)Math.Pow(2, counter);
        //        }

        //    }



        //    return result;

        //}


        public static int ScoreOfParenthesesFunc(string s)
        {
            var score = 0;
            var stack = new Stack<int>();
            foreach (var ch in s)
            {
                if (ch == '(')
                {
                    // we move any running score into the stack and reset it
                    stack.Push(score);
                    score = 0;
                }
                else if (ch == ')')
                {
                    // we take 2 X any running score or 1 if the running score is 0 
                    // and add it to the last score pushed in the stack
                    score = stack.Pop() + Math.Max(score * 2, 1);
                }
            }
            return score;
        }
    }
}
