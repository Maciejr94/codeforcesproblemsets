using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    //
    // 0 | 0 | 0
    // 1 | 0 | 1
    // 0 | 1 | 2
    // 1 | 1 | 3
    //

    public static class GameOfLife
    {
        public static void GameOfLifeFunc(int[][] board)
        {
            int ROWS = board.Length;
            int COLUMNS = board[0].Length;
            for(int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {
                    int neighbor = NeighborCount(i, j, ROWS, COLUMNS, board);
                    if (new[] { 2, 3 }.Contains(neighbor) && board[i][j] == 1)
                        board[i][j] = 3;
                    else if (neighbor == 3 && board[i][j] == 0)
                        board[i][j] = 2;
                }
            }

            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {
                    if (board[i][j] == 1)
                        board[i][j] = 0;
                    else if (new int[] { 2, 3 }.Contains(board[i][j]))
                        board[i][j] = 1;
                }
            }
           
    }


        public static int NeighborCount(int i, int j, int rows, int columns, int [][] board)
        {
            int count = 0;
            for (int x = i - 1; x < i + 2; x++)
            {
                for (int y = j - 1; y < j + 2; y++)
                {
                    if ((x == i && y == j) || x < 0 || y < 0 || x == rows || y == columns)
                        continue;

                    if (new[] { 1, 3 }.Contains(board[x][y]))
                        count++;
                }
            }

            return count;
        }
    }
}
