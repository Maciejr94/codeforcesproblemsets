using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class AddTwoNumbers
    {
        public static ListNode AddTwoNumbersFunc(ListNode l1, ListNode l2)
        {
            int rest = 0;
            ListNode current = new ListNode(0);
            ListNode head = current; 

            while(l1 != null || l2 != null || rest > 0)
            {
                int tempresult = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + rest;
                rest = tempresult >= 10 ? 1 : 0;

                head.next = new ListNode(tempresult % 10);
                head = head.next;
                //Console.WriteLine(l1.val + l2.val);
                if (l1 != null)
                    l1 = l1.next;

                if (l2 != null)
                    l2 = l2.next;
            }
            return current.next;
        }
    }
}
