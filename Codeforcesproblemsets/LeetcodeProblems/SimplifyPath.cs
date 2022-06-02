using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class SimplifyPath
    {
        public static string SimplifyPathFunc(string path)
        {
            StringBuilder result = new StringBuilder();
            Stack<string> stack = new Stack<string>();

            foreach(var item in path.Split('/'))
            {
                if(item != String.Empty)
                {
                    if (item == ".." && stack.Count > 0)
                        stack.Pop();
                    else if (item != "." && item != "..")
                        stack.Push(item);
                }
            }

            List<string> temp = new List<string>();
            while (stack.Count > 0)
                temp.Add(stack.Pop());

            for (int i = temp.Count - 1; i >= 0; i--)
                result.Append("/" + temp[i]);

            return result.Length == 0 ? "/" : result.ToString();
        }
    }
}
