using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public class BinarySearchTreeIterator
    {
        static Stack<TreeNode> stack = new Stack<TreeNode>();
        public BinarySearchTreeIterator(TreeNode root)
        {
            while (root != null)
            {
                stack.Push(root);
                root = root.left;
            }
        }

        public int Next()
        {
            var next = stack.Pop();
            if (next.right != null)
            {
                var cur = next.right;
                while (cur != null)
                {
                    stack.Push(cur);
                    cur = cur.left;
                }
            }
            return next.val;
        }

        public bool HasNext()
        {
            return stack.Any();
        }
    }
}
