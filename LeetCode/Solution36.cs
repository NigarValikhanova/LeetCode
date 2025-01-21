public class Solution36
{
    public bool IsValidSudoku(char[][] board)
    {
        HashSet<string> seen = new HashSet<string>();

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                char currentVal = board[i][j];

                if (currentVal != '.')
                {
                    string rowCheck = $"{currentVal} in row {i}";
                    string colCheck = $"{currentVal} in col {j}";
                    string boxCheck = $"{currentVal} in box {i / 3}-{j / 3}";

                    if (seen.Contains(rowCheck) || seen.Contains(colCheck) || seen.Contains(boxCheck))
                        return false;

                    seen.Add(rowCheck);
                    seen.Add(colCheck);
                    seen.Add(boxCheck);
                }
            }
        }

        return true;
    }
}
