using System;

namespace SudokuSolver
{
    public class Program
    {
        private static readonly int GRID_SIZE = 9;

        private static bool isNumberInRow(int [,] board, int number, int row)
        {
            for(int i = 0; i < GRID_SIZE; i++)
            {
                if (board[row,i] == number)
                    return true;
            }
            return false;
        }
        private static bool isNumberInColumn(int [,] board, int number, int column)
        {
            for(int i = 0; i < GRID_SIZE; i++)
            {
                if (board[i,column] == number)
                    return true;
            }
            return false;
        }

        private static bool isNumberInBox(int[,] board, int number, int row, int column)
        {
            int localRow = row - row % 3;
            int localColumn = column - column % 3;

            for(int i = localRow; i < localRow + 3; i++)
            {
                for(int j = localColumn; j < localColumn + 3; j++)
                {
                    if (board[i,j] == number)
                        return true;
                }
            }
            return false;
        }

        private static bool isValid(int[,] board, int number, int row, int column)
        {
            return !isNumberInRow(board, number, row) &&
                    !isNumberInColumn(board, number, column) &&
                        !isNumberInBox(board, number, row, column);
        }

        private static bool SolveBoard(int [,] board)
        {
            for(int i = 0; i < GRID_SIZE; i++)
            {
                for(int j = 0; j < GRID_SIZE; j++)
                {
                    if(board[i,j] == 0)
                    {
                        for(int k = 1; k <= GRID_SIZE; k++)
                        {
                            if (isValid(board, k, i, j))
                            {
                                board[i, j] = k;

                                if (SolveBoard(board))
                                    return true;
                                else
                                    board[i, j] = 0;
                            }
                                
                        }
                        return false;
                    }
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            //int[,] board = new int[,]
            //{
            //    { 7, 0, 2, 0, 5, 0, 6, 0, 0 },
            //    { 0, 0, 0, 0, 0, 3, 0, 0, 0 },
            //    { 1, 0, 0, 0, 0, 9, 5, 0, 0 },
            //    { 8, 0, 0, 0, 0, 0, 0, 9, 0 },
            //    { 0, 4, 3, 0, 0, 0, 7, 5, 0 },
            //    { 0, 9, 0, 0, 0, 0, 0, 0, 8 },
            //    { 0, 0, 9, 7, 0, 0, 0, 0, 5 },
            //    { 0, 0, 0, 2, 0, 0, 0, 0, 0 },
            //    { 0, 0, 7, 0, 4, 0, 2, 0, 3 }
            //};

            int[,] board = new int[,]
            {
                { 5, 3, 0, 0, 7, 0, 0, 0, 0 },
                { 6, 0, 0, 1, 9, 5, 0, 0, 0 },
                { 0, 9, 8, 0, 0, 0, 0, 6, 0 },
                { 8, 0, 0, 0, 6, 0, 0, 0, 3 },
                { 4, 0, 0, 8, 0, 3, 0, 0, 1 },
                { 7, 0, 0, 0, 2, 0, 0, 0, 6 },
                { 0, 6, 0, 0, 0, 0, 2, 8, 0 },
                { 0, 0, 0, 4, 1, 9, 0, 0, 5 },
                { 0, 0, 0, 0, 8, 0, 0, 7, 9 }
            };

            if (SolveBoard(board))
                printBorad(board);



            Console.ReadKey();
        }

        private static void printBorad(int[,] board)
        {
            for (int i = 0; i < GRID_SIZE; i++)
            {
                for (int j = 0; j < GRID_SIZE; j++)
                {
                    Console.Write(board[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
