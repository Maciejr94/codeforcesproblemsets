using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class CombinationSum
    {
        public static List<IList<int>> result = new List<IList<int>>();
        public static IList<IList<int>> CombinationSumFunc(int[] candidates, int target)
        {

            //List<int> combination = new List<int>();
            //Array.Sort(candidates);
            //CombinationSumFuncHelp(result, candidates, combination, target, 0);
            DoCom(candidates, target, 0, new List<int>());
            return result;
        }

        private static void DoCom(int[] candidates, int target, int index, IList<int>current)
        {
            if (target == 0)
                result.Add(new List<int>(current));
            else if (target < 0)
                return;

            for(int i = index; i < candidates.Length; i++)
            {
                current.Add(candidates[i]);
                DoCom(candidates, target - candidates[i], i, current);
                current.Remove(current.Last());
            }
        }
        //private static void CombinationSumFuncHelp(IList<IList<int>> result, int[] candidates, IList<int> combination, int target, int start)
        //{
        //    if (target == 0)
        //    {
        //        result.Add(new List<int>(combination));
        //        return;
        //    }

        //    for (int i = start; i != candidates.Length && target >= candidates[i]; ++i)
        //    {
        //        combination.Add(candidates[i]);
        //        CombinationSumFuncHelp(result, candidates, combination, target - candidates[i], i);
        //        combination.Remove(combination.Last());
        //    }
        //}
    }
}
