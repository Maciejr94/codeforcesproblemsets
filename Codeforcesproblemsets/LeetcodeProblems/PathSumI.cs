using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{

    public static class PathSumI
    {
        public static bool result = false;
        public static bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null)
                return false;

            if (root.left == null && root.right == null)
                return root.val == targetSum;

            targetSum -= root.val;
            return HasPathSum(root.left, targetSum) || HasPathSum(root.right, targetSum);
        }

        //public static void DFS(TreeNode node, int sum)
        //{
        //    if(node != null)
        //    {
                
        //        DFS(node.left, sum);
        //        DFS(node.right, sum);
        //        int t = sum - node.val;
        //        if (t == sum)
        //            result = true;

        //    }
        //}
    }
}
