namespace LeetCode
{
    public class Solution51
    {
        public IList<IList<string>> SolveNQueens(int n)
        {
            var result = new List<IList<string>>();
            var board = new char[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    board[i, j] = '.';

            Solve(0, board, result, n);
            return result;
        }

        private void Solve(int row, char[,] board, List<IList<string>> result, int n)
        {
            if (row == n)
            {
                result.Add(GenerateBoard(board, n));
                return;
            }

            for (int col = 0; col < n; col++)
            {
                if (IsSafe(board, row, col, n))
                {
                    board[row, col] = 'Q';
                    Solve(row + 1, board, result, n);
                    board[row, col] = '.';
                }
            }
        }

        private bool IsSafe(char[,] board, int row, int col, int n)
        {
            for (int i = 0; i < row; i++)
                if (board[i, col] == 'Q') return false;

            for (int i = row, j = col; i >= 0 && j >= 0; i--, j--)
                if (board[i, j] == 'Q') return false;

            for (int i = row, j = col; i >= 0 && j < n; i--, j++)
                if (board[i, j] == 'Q') return false;

            return true;
        }

        private List<string> GenerateBoard(char[,] board, int n)
        {
            var solution = new List<string>();
            for (int i = 0; i < n; i++)
            {
                var row = new char[n];
                for (int j = 0; j < n; j++)
                    row[j] = board[i, j];
                solution.Add(new string(row));
            }
            return solution;
        }
    }
}
