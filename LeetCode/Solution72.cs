
namespace LeetCode
{
    public class Solution72
    {
        public int MinDistance(string word1, string word2)
        {
            int m = word1.Length, n = word2.Length;
            int[,] dp = new int[m + 1, n + 1];

            // Initialize base cases
            for (int i = 0; i <= m; i++) dp[i, 0] = i;
            for (int j = 0; j <= n; j++) dp[0, j] = j;

            // Fill DP table
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (word1[i - 1] == word2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1]; // No operation needed
                    }
                    else
                    {
                        dp[i, j] = Math.Min(
                            dp[i - 1, j - 1], // Replace
                            Math.Min(dp[i, j - 1], // Insert
                                     dp[i - 1, j]) // Delete
                        ) + 1;
                    }
                }
            }

            return dp[m, n];
        }

    }

}
