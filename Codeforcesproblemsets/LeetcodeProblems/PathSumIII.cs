using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    //[10,5,-3,3,2,null,11,3,-2,null,1], targetSum = 8
    public class TreeNode
    {
      public int val;
      public TreeNode left;
      public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public static class PathSumIII
    {

        
        private static int DFS(TreeNode node, int targetSum, bool isRoot)
        {
            int res = 0;
            if(node!= null)
            {
                if (node.val == targetSum)
                    res++;

                if (isRoot)
                {
                    res = DFS(node.left, targetSum, true) + DFS(node.right, targetSum, true);
                }
                
                res += DFS(node.left, targetSum - node.val, false) + DFS(node.right, targetSum - node.val, false);

            }
            
            return res;
        }

        public static int PathSum(TreeNode root, int targetSum)
        {
            return DFS(root, targetSum, true);
        }
    }
}
