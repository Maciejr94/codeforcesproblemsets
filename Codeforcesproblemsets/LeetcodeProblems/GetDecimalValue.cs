using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public static class GetDecimalValue
    {
        public static int GetDecimalValueFunc(ListNode head)
        {
            #region firstSolution
            //string binaryStr = string.Empty;
            //while (head != null)
            //{
            //    binaryStr += head.val;
            //    head = head.next;
            //}
            //return Convert.ToInt32(binaryStr, 2);
            #endregion firstSolution
            #region weird stuff
            int num = 0;
            while (head != null)
            {
                num = (num * 2) + head.val;
                head = head.next;
            }
            return num;
            #endregion weird stuff

            string binaryStr = string.Empty;
            int result = 0;
            while (head != null)
            {
                binaryStr = head.val + binaryStr;
                head = head.next;
            }

            for (int i = 0; i < binaryStr.Length; i++)
            {
                if(binaryStr[i] == '1')
                {
                    result += Convert.ToInt32(Math.Pow(2, i));
                }
            }
            

            return result;
        }
    }
}
