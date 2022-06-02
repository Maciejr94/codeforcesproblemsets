using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class PermutationsII
    {
        public static IList<IList<int>> PermuteUnique(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>();
            Dictionary<int, int> visited = new Dictionary<int, int>();
            foreach(var item in nums)
            {
                if (!visited.ContainsKey(item))
                    visited.Add(item, 0);

                visited[item]++;
            }

            int[][] set = new int[visited.Count][];
            int i = 0;

            foreach (var item in visited.Keys)
                set[i++] = new int[] { item, visited[item] };

            //backtracking(nums, result, new List<int>(), visited);
            Helper(set, new List<int>(), nums.Length, result);
            
            return result;
        }


        private static void Helper(int[][] set, List<int> cur, int count, List<IList<int>> result)
        {
            if (cur.Count == count)
            {
                result.Add(new List<int>(cur));
                return;
            }

            foreach (var item in set)
                if (item[1] != 0)
                {
                    item[1] -= 1;
                    cur.Add(item[0]);

                    Helper(set, cur, count, result);

                    item[1] += 1;
                    cur.RemoveAt(cur.Count - 1);
                }
        }

        //private static void backtracking(int[] nums, List<IList<int>> result, List<int> list, Dictionary<int,int> dict)
        //{
        //    if (list.Count == nums.Length)
        //    {
        //        result.Add(new List<int>(list));
        //        return;
        //    }
                
           
        //    foreach(var item in dict.ToArray())
        //    {
        //        if (dict[item.Key] == 0)
        //            continue;
                
        //            dict[item.Key]--;
        //            list.Add(item.Key);

        //            backtracking(nums, result, list, dict);

        //            dict[item.Key]++;
        //            list.Remove(list.Last());
                
        //    }

            
        //    //for (int i = 0; i <= dict.Count; i++)
        //    //{
        //    //    if (dict[nums[i]] != 0)
        //    //    {
        //    //        dict[nums[i]]--;
        //    //        list.Add(nums[i]);
        //    //        backtracking(nums, result, list, dict);
        //    //        list.Remove(list.Last());
        //    //        dict[nums[i]]++;
        //    //    }

        //    //}
        //}


        
    }
}
