using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class MaximumUnits
    {
        public static int MaximumUnitsFunc(int[][] boxTypes, int truckSize)
        {
            int size = 0;
            int result = 0;
            var a = boxTypes.OrderByDescending(b => b[1]);
            
            foreach (var s in a)
            {
                var current = s;
                while(s[0] > 0)
                {
                    if (size == truckSize)
                        return result;

                    result += s[1];

                    size++;
                    s[0]--;
                }
            }
                    
            return result;
        }
    }
}
