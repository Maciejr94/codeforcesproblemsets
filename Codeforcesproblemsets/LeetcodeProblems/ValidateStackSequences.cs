using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class ValidateStackSequences
    {
        public static bool ValidateStackSequencesFunc(int[] pushed, int[] popped)
        {
            Stack<int> stack = new Stack<int>();
            int index = 0;
            foreach(var item in pushed)
            {
                stack.Push(item);
                while(stack.Count > 0 && popped[index] == stack.Peek())
                {
                    stack.Pop();
                    index++;
                }
            }
            return stack.Count == 0;
        }
    }
}
