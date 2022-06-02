using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class TopKFrequentElements
    {
        public static int[] TopKFrequent(int[] nums, int k)
        {
            #region dictionary + LINQ solution
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (dictionary.ContainsKey(item))
                    dictionary[item]++;
                else
                    dictionary.Add(item, 1);
            }
            return dictionary.OrderByDescending(x => x.Value).Take(k).Select(y => y.Key).ToArray();
            #endregion


            #region dictionary + sorted dictionary
            //Dictionary<int, int> dictionary = new Dictionary<int, int>();
            //foreach (var item in nums)
            //{
            //    if (dictionary.ContainsKey(item))
            //        dictionary[item]++;
            //    else
            //        dictionary.Add(item, 1);
            //}


            //var sortedDictionary = new SortedSet<(int frequency, int num)>();
            //foreach (var item in dictionary)
            //{
            //    sortedDictionary.Add((item.Value, item.Key));
            //    if (sortedDictionary.Count > k)
            //    {
            //       // var a = sortedDictionary.First().Key;
            //       sortedDictionary.Remove(sortedDictionary.Min);
            //       // sortedDictionary.Remove(sortedDictionary.First().Key);
            //    }
            //}

            //List<int> output = new List<int>();
            //foreach (var item in sortedDictionary)
            //    output.Add(item.num);


            //return output.ToArray();
            #endregion
        }
    }
}
