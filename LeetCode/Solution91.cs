using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution91
    {
        public int NumDecodings(string s)
        {
            if (s == null || s.Length == 0 || s[0] == '0') return 0;

            int n = s.Length;
            int[] dp = new int[n + 1];

            dp[0] = 1; // Base case: empty string has one way to decode
            dp[1] = s[0] != '0' ? 1 : 0; // Single character decoding

            for (int i = 2; i <= n; i++)
            {
                int oneDigit = int.Parse(s.Substring(i - 1, 1));
                int twoDigits = int.Parse(s.Substring(i - 2, 2));

                if (oneDigit >= 1)
                {
                    dp[i] += dp[i - 1];
                }

                if (twoDigits >= 10 && twoDigits <= 26)
                {
                    dp[i] += dp[i - 2];
                }
            }

            return dp[n];
        }
    }

}
