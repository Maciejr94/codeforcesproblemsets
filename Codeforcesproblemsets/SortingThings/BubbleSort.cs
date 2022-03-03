using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingThings
{
    class BubbleSort
    {
        private List<int> unSortedList;
        public BubbleSort(List<int> list)
        {
            unSortedList = list;
        }

        public List<int> doSort()
        {
            int lenght = unSortedList.Count;
            for(int i = 0; i < lenght; i++)
            {
                for(int j = 1; j < i; j++)
                {
                    if (unSortedList[j] < unSortedList[j - 1])
                        swap(j, i);
                }
                lenght--;
            }
            return unSortedList;
        }

        private void swap(int second, int first)
        {
            int temp = unSortedList[second];
            unSortedList[second] = unSortedList[first];
            unSortedList[first] = temp;
        }
    }
}
