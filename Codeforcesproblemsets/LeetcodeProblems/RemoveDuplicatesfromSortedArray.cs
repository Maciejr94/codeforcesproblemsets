using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    static public class RemoveDuplicatesfromSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            int i = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                nums[i++] = nums[j];
                while (j < nums.Length - 1 && nums[j] == nums[j+1])
                    j++;
               
            }

            //int i = 0;
            //for (int j = 1; j < nums.Length; j++)
            //{
            //    if (nums[i] != nums[j])
            //    {
            //        nums[i++ + 1] = nums[j];
            //    }
            //}
            return i;

        }
    }
}
