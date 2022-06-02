using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }
    class CopyListWithRandomPointer
    {
        public Node CopyRandomList(Node head)
        {
            Dictionary<Node, Node> dict = new Dictionary<Node, Node>();

            Node decoy = new Node(0);
            Node current = decoy;
            Node headDecoy = head;

            while(headDecoy != null)
            {
                Node newOne = new Node(headDecoy.val);
                
                dict.Add(headDecoy, newOne);

                headDecoy = headDecoy.next;

                current.next = newOne;
                current = current.next;
            }

            headDecoy = head;

            while (headDecoy != null)
            {
                dict[headDecoy].random = headDecoy.random == null ? null : dict[headDecoy.random];
                headDecoy = headDecoy.next;
            }

            return decoy.next;
        }
    }
}
