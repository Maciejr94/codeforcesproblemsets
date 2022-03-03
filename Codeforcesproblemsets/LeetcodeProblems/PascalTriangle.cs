using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class PascalTriangle
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> array = new List<IList<int>>();
            array.Add(new List<int> { 1 });
            if (numRows == 1)
                return array;
            array.Add(new List<int> { 1, 1 });
            if (numRows == 2)
                return array;

            for (int i = 2; i < numRows; i++)
            {
                List<int> temp = array[i - 1] as List<int>;
                List<int> res = new List<int>() { 1 };
                for (int j = 1; j < temp.Count; j++)
                    res.Add(temp[j] + temp[j - 1]);

                res.Add(1);

                array.Add(res);
            }
            return array;
        }

        //some random guy solution
        public static IList<IList<int>> Generate2(int numRows)
        {
            IList<IList<int>> res = new List<IList<int>>() { new List<int>() { 1 } };

            for (int i = 2; i <= numRows; i++)
            {
                List<int> cur = new List<int>() { 1 };

                for (int j = 1; j < i - 1; j++)
                    cur.Add(res[i - 2][j - 1] + res[i - 2][j]);

                cur.Add(1);

                res.Add(cur);
            }

            return res;
        }
    }
}
