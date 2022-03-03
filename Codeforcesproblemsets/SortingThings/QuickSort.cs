using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingThings
{
    class QuickSort
    {
        private List<int> unlisted;
        public QuickSort(List<int> list)
        {
            unlisted = list;
        }
        public void doSort(int left, int right)
        {
            if(left < right)
            {
                int p = part(unlisted, left, right);

                doSort(left,p-1);
                doSort(p+1, right);
            }
        }

        private int part(List<int> list, int left, int right)
        {
            int j = left;
            for (int i = left; i < right; i++)
            {
                if (list[i] < list[right])
                {
                    int temp = list[j];
                    list[j] = list[i];
                    list[i] = temp;
                    j++;
                }
            }
            
            int temp_1 = list[j];
            list[j] = list[right];
            list[right] = temp_1;

            return j;
        }

        public List<int> printlist2() => unlisted;
        public List<int> printList()
        {
            return unlisted;
        }
    }
}
