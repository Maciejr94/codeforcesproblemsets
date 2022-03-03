using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class FindClosestElements
    {
        public static IList<int> FindClosestElementsFunc(int[] arr, int k, int x)
        {
            int l = 0;
            List<int> result = new List<int>();
            int count = 0;
            int n = arr.Length - 1;
            if(n > 0)
                l = BinarySearchIterative(arr, x);

            int r = l + 1;
            while (l >= 0 && r < n && count < k)
            {
                if ((Math.Abs(arr[l] - x) < Math.Abs(arr[r] - x)) || (Math.Abs(arr[l] - x) == Math.Abs(arr[r] - x) && l < r))
                    result.Add(arr[l--]);
                //if (x - arr[l] < arr[r] - x)
                //    result.Add(arr[l--]);
                else
                    result.Add(arr[r++]);
                count++;
            }

            while (count < k && l >= 0)
            {
                result.Add(arr[l--]);
                count++;
            }

            while (count < k && r < n)
            {
                result.Add(arr[r++]);
                count++;
            }

            return result.OrderBy(z => z).ToList();
        }

        

        static int BinarySearchIterative(int[] array, int x)
        {
            int l = 0;
            int r = array.Length - 1;
            while (l <= r)
            {
                int M = l + (r - l) / 2;
                if (array[M] == x)
                    return M;
                if (array[M] > x)
                    r = M - 1;
                if (array[M] < x)
                    l = M + 1;
            }
            return -1;
        }
    }
}
