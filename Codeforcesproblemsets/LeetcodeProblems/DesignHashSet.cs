using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    class DesignHashSet
    {
        bool[] array = new bool[1000001];
        HashSet<int> hs;
        public DesignHashSet()
        {
            //hs = new HashSet<int>();
        }

        public void Add(int key)
        {
            array[key] = true;
        }

        public void Remove(int key)
        {
            array[key] = false;
        }

        public bool Contains(int key)
        {
            return array[key];
        }
    }
}


//int[] arr
//        public MyHashSet()
//{
//    hs = new HashSet<int>();
//}

//public void Add(int key)
//{
//    hs.Add(key);
//}

//public void Remove(int key)
//{
//    hs.Remove(key);
//}

//public bool Contains(int key)
//{
//    return hs.Contains(key);
//}