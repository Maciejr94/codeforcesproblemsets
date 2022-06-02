using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class ConvertBSTToGreaterTree
    {
        public static int sum = 0;
        public static TreeNode ConvertBST(TreeNode root)
        {
            dfs(root);

            return root;
        }

        public static  void dfs(TreeNode node)
        {
            if (node == null)
                return;

            dfs(node.right);
            int temp = node.val;
            node.val += sum;
            sum += temp;
            dfs(node.left);
        }
    }
}
