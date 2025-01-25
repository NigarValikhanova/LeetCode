public class Solution44 {
    public bool IsMatch(string s, string p) {
        int m = s.Length, n = p.Length;
        bool[,] dp = new bool[m + 1, n + 1];
        
        dp[0, 0] = true;  // Empty string matches empty pattern
        
        // Initialize the first row (matching an empty string with the pattern)
        for (int j = 1; j <= n; j++) {
            if (p[j - 1] == '*') {
                dp[0, j] = dp[0, j - 1];  // * can match empty sequence
            }
        }

        // Fill the DP table
        for (int i = 1; i <= m; i++) {
            for (int j = 1; j <= n; j++) {
                if (p[j - 1] == '*') {
                    dp[i, j] = dp[i - 1, j] || dp[i, j - 1];  // * can match empty or one or more characters
                } else if (p[j - 1] == '?' || s[i - 1] == p[j - 1]) {
                    dp[i, j] = dp[i - 1, j - 1];  // ? matches one character, or exact match
                }
            }
        }
        
        return dp[m, n];  // Return the result for the full string and pattern
    }
}
