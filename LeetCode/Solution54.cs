namespace LeetCode
{
    public class Solution54
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            List<int> result = new List<int>();
            if (matrix == null || matrix.Length == 0) return result;

            int m = matrix.Length, n = matrix[0].Length;
            int left = 0, right = n - 1, top = 0, bottom = m - 1;

            while (left <= right && top <= bottom)
            {
                // Traverse from left to right
                for (int i = left; i <= right; i++)
                    result.Add(matrix[top][i]);
                top++;

                // Traverse from top to bottom
                for (int i = top; i <= bottom; i++)
                    result.Add(matrix[i][right]);
                right--;

                // Traverse from right to left
                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--)
                        result.Add(matrix[bottom][i]);
                    bottom--;
                }

                // Traverse from bottom to top
                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--)
                        result.Add(matrix[i][left]);
                    left++;
                }
            }

            return result;
        }
    }
}
