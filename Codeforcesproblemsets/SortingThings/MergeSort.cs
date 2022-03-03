using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingThings
{
    
    public class MergeSort
    {
        public List<int> doSort(List<int> list)
        {
            if (list.Count <= 1)
                return list;

            List<int> left, right;
            
            int middle = list.Count / 2;
            left = list.GetRange(0, middle);
            right = list.GetRange(middle, (list.Count - middle));

            left = doSort(left);
            right = doSort(right);

            return MergeWhole(left, right);
        }

        private List<int> MergeWhole(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if(left.Count > 0 && right.Count > 0)
                {
                    if(left.First() <= right.First())
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if(left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }
            return result;
        }
    }
}
