namespace LeetCode
{
    public class Solution48
    {
        public void Rotate(int[][] matrix)
        {
            int n = matrix.Length;

            // First, transpose the matrix
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }

            // Then, reverse each row
            for (int i = 0; i < n; i++)
            {
                Array.Reverse(matrix[i]);
            }
        }
    }
}
