using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public class DesignHashMap
    {
        Dictionary<int, int> dict;
        public DesignHashMap()
        {
            dict = new Dictionary<int, int>();
        }

        public void Put(int key, int value)
        {
            if (dict.ContainsKey(key))
            {
                dict[key] = value;
            }
            else
                dict.Add(key, value);
        }

        public int Get(int key)
        {
            if (!dict.ContainsKey(key))
                return -1;
            else
                return dict[key];
        }

        public void Remove(int key)
        {
            dict.Remove(key);
        }
    }
}
