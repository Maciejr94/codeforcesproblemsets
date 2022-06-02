using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class PopulatingNextRightPointersInEachNodeII
    {
        public static NodeTree Connect(NodeTree root)
        {
            if (root == null)
                return root;

            Queue<NodeTree> que = new Queue<NodeTree>();
            que.Enqueue(root);

            while(que.Count > 0)
            {
                int size = que.Count;

                while(size > 0)
                {
                    NodeTree current = que.Dequeue();

                    if (size != 1)
                        current.next = que.Peek();

                    if (current.left != null)
                        que.Enqueue(current.left);

                    if (current.right != null)
                        que.Enqueue(current.right);

                    size--;
                }
            }

            return root;
        }
    }
}
