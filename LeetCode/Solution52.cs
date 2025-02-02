using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution52
    {
        public int TotalNQueens(int n)
        {
            int count = 0;
            int[] queens = new int[n]; // Track column positions of queens
            Solve(0, n, queens, ref count);
            return count;
        }

        private void Solve(int row, int n, int[] queens, ref int count)
        {
            if (row == n)
            {
                count++;
                return;
            }

            for (int col = 0; col < n; col++)
            {
                if (IsValid(queens, row, col))
                {
                    queens[row] = col;
                    Solve(row + 1, n, queens, ref count);
                }
            }
        }

        private bool IsValid(int[] queens, int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                if (queens[i] == col || Math.Abs(queens[i] - col) == row - i)
                    return false;
            }
            return true;
        }
    }
}
