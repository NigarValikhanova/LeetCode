public class Solution10 {
    public bool IsMatch(string s, string p) {
        int m = s.Length, n = p.Length;
        bool[,] dp = new bool[m + 1, n + 1];

        // Base case: empty string matches empty pattern
        dp[0, 0] = true;

        // Fill for patterns that include '*' which can match empty sequences
        for (int j = 2; j <= n; j++) {
            if (p[j - 1] == '*') {
                dp[0, j] = dp[0, j - 2];
            }
        }

        // Dynamic programming
        for (int i = 1; i <= m; i++) {
            for (int j = 1; j <= n; j++) {
                if (p[j - 1] == '.' || p[j - 1] == s[i - 1]) {
                    // Characters match or '.' matches any character
                    dp[i, j] = dp[i - 1, j - 1];
                } else if (p[j - 1] == '*') {
                    // '*' can match zero or more of the preceding character
                    dp[i, j] = dp[i, j - 2] || // Treat '*' as matching zero occurrences
                               (dp[i - 1, j] && (s[i - 1] == p[j - 2] || p[j - 2] == '.')); // Match one or more
                }
            }
        }

        return dp[m, n];
    }
}