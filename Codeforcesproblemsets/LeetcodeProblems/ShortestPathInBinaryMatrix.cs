using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public static class ShortestPathInBinaryMatrix
    {
        public static int ShortestPathBinaryMatrix(int[][] grid)
        {
            if (grid == null || grid[0][0] != 0)
                return -1;

            int x = grid.Length;
            int y = grid[0].Length;
            int result = 0;
            bool[,] visited = new bool[x, y];
            int[,] directions = new int[,] { {-1,-1}, {0,-1}, {1,-1}, {-1,0}, {1,0}, {-1,1}, {0,1}, {1,1} };
            Queue<(int, int)> que = new Queue<(int, int)>();
            que.Enqueue((0, 0));
            visited[0, 0] = true;

            while(que.Count > 0)
            {
                result++;
                int size = que.Count;
                for(int i = 0; i < size; i++)
                {
                    var current = que.Dequeue();
                    if (current.Item1 == x - 1 && current.Item2 == y - 1)
                        return result;

                    for(int j = 0; j < 8; j++)
                    {
                        int nextRow = current.Item1 + directions[j, 0];
                        int nextColumn = current.Item2 + directions[j, 1];
                        if ( nextRow >= 0 && nextRow < x && nextColumn >= 0 && nextColumn < y && grid[nextRow][nextColumn] == 0 && !visited[nextRow, nextColumn])
                        {
                            que.Enqueue((nextRow, nextColumn));
                            visited[nextRow, nextColumn] = true;
                        }
                           
                    }
                }
            }

            return -1;
        }
    }
}
