using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class _3SumWithMultiplicity
    {
        public static int ThreeSumMulti(int[] arr, int target)
        {
            int MOD = 1000000007;
            long result = 0;
            Array.Sort(arr);

            for(int i = 0; i < arr.Length; ++i)
            {
                int T = target - arr[i];
                int j = i + 1;
                int k = arr.Length - 1;

                while(j < k)
                {
                    if (arr[j] + arr[k] < T)
                        j++;
                    else if (arr[j] + arr[k] > T)
                        k--;
                    else if(arr[j] != arr[k])
                    {
                        int left = 1;
                        int right = 1;
                        while(j + 1 < k && arr[j] == arr[j + 1])
                        {
                            left++;
                            j++;
                        }
                        while (k - 1 > j && arr[k] == arr[k - 1])
                        {
                            right++;
                            k--;
                        }

                        result += left * right;
                        result %= MOD;
                        j++;
                        k--;
                    }
                    else
                    {
                        result += (k - j + 1) * (k - j) / 2;
                        result %= MOD;
                        break;
                    }
                }
            }

            return (int)result;
        }
        
    }
}
