using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tarjan's algorithm

namespace LeetcodeProblems
{

    public static class CriticalConnectionsInANetwork
    {
        private static List<IList<int>> result = new List<IList<int>>();
        private static Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
        private static bool[] visited;

        private static int[] id = null;
        private static int[] low = null;

        private static int[] visitedTimes = null;
        private static int[] lowTimes = null;
        private static int time;

        public static IList<IList<int>> CriticalConnections(int n, IList<IList<int>> connections)
        {
            visitedTimes = Enumerable.Repeat(-1, n).ToArray();
            time = 0;
            lowTimes = new int[n];
            visited = new bool[n];
            id = new int[n];
            low = new int[n];


            // creating graph. Vertex with connections
            foreach(var connection in connections)
            {
                if (!graph.ContainsKey(connection[0]))
                    graph.Add(connection[0], new List<int>());

                if (!graph.ContainsKey(connection[1]))
                    graph.Add(connection[1], new List<int>());

                graph[connection[0]].Add(connection[1]);
                graph[connection[1]].Add(connection[0]);
            }

            DFS(connections[0][0], -1);
            return result;
        }

        private static void DFS(int current, int parent)
        {
            visited[current] = true;
            id[current] = time++;
            low[current] = time++;

            foreach (var node in graph[current])
            {
                if(node != parent)
                {
                    if (!visited[node])
                    {
                        DFS(node, current);

                        if (id[current] < low[node])
                            result.Add(new List<int>() { current, node });
                        else
                            low[current] = Math.Min(low[current], low[node]);
                    }
                    else
                        low[current] = Math.Min(low[current], id[node]);
                }
            }
        }
        //private static void DFS(int current, int parent)
        //{
        //    visited[current] = true;
        //    visitedTimes[current] = ++time;
        //    lowTimes[current] = ++time;

        //    foreach (var node in graph[current])
        //    {
        //        if (node != parent)
        //        {
        //            if (!visited[node])
        //            {
        //                DFS(node, current);

        //                if (visitedTimes[current] < lowTimes[node])
        //                    result.Add(new List<int>() { current, node });
        //                else
        //                    lowTimes[current] = Math.Min(lowTimes[current], lowTimes[node]);
        //            }
        //            else
        //                lowTimes[current] = Math.Min(lowTimes[current], visitedTimes[node]);
        //        }
        //    }
        //}
    }
}
