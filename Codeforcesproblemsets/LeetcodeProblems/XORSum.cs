using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{

    //0	0	0
    //0	1	1
    //1	0	1
    //1	1	0

    public static class XORSum
    {
        public static int SubsetXORSum(int[] nums)
        {
            return XOR(nums, 0, 0);
        }

        private static int XOR(int[] nums, int index, int result)
        {
            if (nums.Length == index)
                return result;
            return XOR(nums, index + 1, result ^ nums[index]) + XOR(nums, index + 1, result);
        }
    }
}
