using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    // Minimum Spanning Tree (MST)
    // Kruskal's Algorithm
    // Disjoint ( Union() + QuickFind() )
    public class MinCostToConnectAllPoints
    {
        private int[] union;
        public int MinCostConnectPoints(int[][] points)
        {
            int result = 0;
            union = new int[points.Length];
            for (int i = 0; i < union.Length; i++)
                union[i] = i;

            List<int[]> list = new List<int[]>();

            for (int i = 0; i < points.Length - 1; i++)
                for (int j = i + 1; j < points.Length; j++)
                    list.Add(new int[] {i, j, Math.Abs(points[i][0] - points[j][0]) + Math.Abs(points[i][1] - points[j][1]) });

            list = list.OrderBy(x => x[2]).ToList();

            foreach(var item in list)
            {
                if(Find(item[0]) != Find(item[1]))
                {
                    result += item[2];
                    Union(item[0], item[1]);
                }
            }

            return result;
        }

        private int Find(int x)
        {
            //if (x != union[x])
            //    union[x] = Find(union[x]);

            return union[x];
        }

        private void Union(int x, int y)
        {
            int px = Find(x);
            int py = Find(y);

            if(px != py)
            {
                for(int i = 0; i < union.Length; i++)
                {
                    if (union[i] == py)
                        union[i] = px;
                }
            }
            //int px = Find(x),
            //    py = Find(y);

            //if (px != py)
            //    union[px] = py;
        }
    }
}
