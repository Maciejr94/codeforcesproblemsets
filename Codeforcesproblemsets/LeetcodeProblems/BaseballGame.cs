using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class BaseballGame
    {
        public static int CalPoints(string[] ops)
        {
            #region my solution 
            //List<int> result = new List<int>();

            //foreach(var item in ops)
            //{
            //    if (int.TryParse(item, out int value))
            //        result.Add(value);
            //    else
            //    {
            //        char.TryParse(item, out char c);
            //        switch (c)
            //        {
            //            case 'C':
            //                result.Remove(result.Last());
            //                break;
            //            case 'D':
            //                result.Add(result.Last() * 2);
            //                break;
            //            case '+':
            //                int temp = 0;
            //                int index = 0;
            //                while(index < 2)
            //                {
            //                    temp += result[result.Count - 1 - index];
            //                    index++;
            //                }
            //                result.Add(temp);
            //                break;
            //        }
            //    }
            //}

            //int res = 0;
            //foreach (var item in result)
            //    res += item;
            //return res;
            #endregion

            #region stack solution
            Stack<int> stack = new Stack<int>();

            foreach(var item in ops)
            {
                if (item.Equals("+"))
                {
                    int top = stack.Pop();
                    int newTop = top + stack.Peek();
                    stack.Push(top);
                    stack.Push(newTop);
                }
                else if (item.Equals("C"))
                    stack.Pop();
                else if (item.Equals("D"))
                    stack.Push(stack.Peek() * 2);
                else
                    stack.Push(int.Parse(item));
            }

            int result = 0;
            foreach (var item in stack)
                result += item;

            return result;
            #endregion

        }
    }
}
