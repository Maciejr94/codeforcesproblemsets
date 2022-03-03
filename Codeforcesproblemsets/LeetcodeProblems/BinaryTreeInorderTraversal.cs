using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    
    static public class BinaryTreeInorderTraversal
    {
        public static IList<int> InorderTraversal(TreeNode root)
        {
            List<int> result = new List<int>();

            inOrder(root, result);

            return result;
        }

        private static void inOrder(TreeNode n, List<int> temp)
        {
            if (n != null)
            {
                inOrder(n.left, temp);
                temp.Add(n.val);
                inOrder(n.right, temp);
                
            }
        }
    }
}
