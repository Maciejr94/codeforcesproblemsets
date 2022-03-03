using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class MaxAncestorDiff
    {
        private static int result = 0;
        public static int MaxAncestorDiffFunc(TreeNode root)
        {
            result = 0;
            DFS(root, new List<int>());

            return result;
        }

        public static void DFS(TreeNode node, List<int> que)
        {
            if (node != null)
            {
                que.Add(node.val);
                DFS(node.left, new List<int>(que));
                DFS(node.right, new List<int>(que));
                
                foreach (var a in que)
                {
                    int temp = Math.Abs(node.val - a);
                    if (temp > result)
                        result = temp;
                }
            }
        }
    }
}
