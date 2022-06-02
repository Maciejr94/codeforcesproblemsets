using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public class KthLargestElementInAStream
    {
        SortedDictionary<int, int> dictionary;
        int k = 0;
        int somethung = 0;
        public KthLargestElementInAStream(int k, int[] nums)
        {
            this.k = k;
            this.dictionary = new SortedDictionary<int, int>();

            foreach (var item in nums)
                Add(item);
        }

        public int Add(int val)
        {
            if (dictionary.ContainsKey(val))
                dictionary[val]++;
            else
                dictionary.Add(val, 1);
            somethung++;

            if(somethung > k)
            {
                var temp = dictionary.First();
                if (temp.Value == 1)
                    dictionary.Remove(temp.Key);
                else
                    dictionary[temp.Key]--;
                somethung--;
            }
            return dictionary.First().Key;
        }
    }
}
