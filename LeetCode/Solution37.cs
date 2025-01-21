public class Solution37
{
    public void SolveSudoku(char[][] board)
    {
        Solve(board);
    }

    private bool Solve(char[][] board)
    {
        for (int row = 0; row < 9; row++)
        {
            for (int col = 0; col < 9; col++)
            {
                if (board[row][col] == '.')
                {
                    for (char num = '1'; num <= '9'; num++)
                    {
                        if (IsValid(board, row, col, num))
                        {
                            board[row][col] = num;

                            if (Solve(board))
                                return true;

                            board[row][col] = '.'; // Backtrack
                        }
                    }
                    return false; // No valid number found
                }
            }
        }
        return true; // Board is completely filled
    }

    private bool IsValid(char[][] board, int row, int col, char num)
    {
        for (int i = 0; i < 9; i++)
        {
            // Check row
            if (board[row][i] == num) return false;

            // Check column
            if (board[i][col] == num) return false;

            // Check 3x3 box
            int boxRow = 3 * (row / 3) + i / 3;
            int boxCol = 3 * (col / 3) + i % 3;
            if (board[boxRow][boxCol] == num) return false;
        }
        return true;
    }
