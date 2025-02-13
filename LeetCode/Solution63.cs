namespace LeetCode
{
    public class Solution63
    {
        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            int m = obstacleGrid.Length;
            int n = obstacleGrid[0].Length;

            if (obstacleGrid[0][0] == 1 || obstacleGrid[m - 1][n - 1] == 1)
                return 0; // If start or end cell has an obstacle, no path is possible.

            int[,] dp = new int[m, n];
            dp[0, 0] = 1;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (obstacleGrid[i][j] == 1)
                    {
                        dp[i, j] = 0; // No path through an obstacle
                    }
                    else
                    {
                        if (i > 0) dp[i, j] += dp[i - 1, j];
                        if (j > 0) dp[i, j] += dp[i, j - 1];
                    }
                }
            }

            return dp[m - 1, n - 1];
        }
    }
}
