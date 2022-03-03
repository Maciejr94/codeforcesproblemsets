using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class BinaryGap
    {
        public static int BinaryGapFunction(int N)
        {
            var temp = Convert.ToString(N, 2).Trim('0').Split(new[] { '1' }).Max(x => x.Length);
            Console.WriteLine(temp);
            return temp;
        }
    }
}
