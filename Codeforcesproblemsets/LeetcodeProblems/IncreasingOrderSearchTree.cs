using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class IncreasingOrderSearchTree
    {
        public static TreeNode IncreasingBST(TreeNode root)
        {
            List<int> values = new List<int>();

            InOrder(root, values);

            TreeNode result = new TreeNode(0);
            TreeNode current = result;

            foreach (var item in values)
            {
                current.right = new TreeNode(item);
                current = current.right;
            }

            return result.right;

        }

        public static void InOrder(TreeNode node, List<int> values)
        {
            if (node == null)
                return;

            InOrder(node.left, values);
            values.Add(node.val);
            InOrder(node.right, values);
        }
    }
}
