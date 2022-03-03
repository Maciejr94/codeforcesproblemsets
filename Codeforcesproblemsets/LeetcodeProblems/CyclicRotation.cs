using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    static public class CyclicRotation
    {
        public static int[] CyclicRotationFunction(int[] A, int K)
        {
            var tttt = A.Min(x => x);
            int a = A.Length;
            int[] result = new int[a];
            int index = 0;
            for (int i = 0; i < a; i++)
            {
                result[(index + K) % A.Length] = A[i];
                index++;
            }

            foreach(var b in result)
            {
                Console.WriteLine(b);
            }
            return result;
        }
    }
}
