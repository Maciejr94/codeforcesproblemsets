using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class PathSumII
    {
        public static IList<IList<int>> result = new List<IList<int>>();
        public static IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {
            DFS(root, targetSum, new List<int>());
            return result;
        }

        public static void DFS(TreeNode node, int sum, List<int> que)
        {
            if(node != null)
            {
                que.Add(node.val);
                if (node.left == null && node.right == null && node.val == sum)
                    result.Add(que);

                sum -= node.val;
                DFS(node.left, sum, new List<int>(que));
                DFS(node.right, sum, new List<int>(que));

            }
        }


    }
}
