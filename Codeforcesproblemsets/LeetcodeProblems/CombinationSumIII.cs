using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class CombinationSumIII
    {
        public static IList<IList<int>> CombinationSum3(int k, int n)
        {
            List<IList<int>> result = new List<IList<int>>();
            if (n < k || k == 0 || n == 0)
                return result;

            int[] numbersArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            backtracking(n, numbersArray, k, result, 0, new List<int>());

            return result;
        }

        private static void backtracking(int target, int[] numberArray, int k, List<IList<int>> result, int index, IList<int> current)
        {
            if (target == 0 && k == 0)
                result.Add(new List<int>(current));
            else if (target < 0)
                return;

            for (int i = index; i < numberArray.Length; i++)
            {
                current.Add(numberArray[i]);
                backtracking( target - numberArray[i], numberArray, k - 1, result, i + 1, current);
                current.Remove(current.Last());
            }
        }
    }
}
