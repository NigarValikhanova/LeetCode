using System;
using System.Collections.Generic;

public class Solution87 {
    private Dictionary<string, bool> memo = new Dictionary<string, bool>();

    public bool IsScramble(string s1, string s2) {
        if (s1 == s2) return true;
        if (s1.Length != s2.Length) return false;
        
        string key = s1 + "#" + s2;
        if (memo.ContainsKey(key)) return memo[key];

        int[] charCount = new int[26];
        for (int i = 0; i < s1.Length; i++) {
            charCount[s1[i] - 'a']++;
            charCount[s2[i] - 'a']--;
        }

        foreach (int count in charCount) {
            if (count != 0) {
                memo[key] = false;
                return false; // If the characters don't match, return false
            }
        }

        int n = s1.Length;
        for (int i = 1; i < n; i++) {
            // Case 1: Without swapping
            if (IsScramble(s1.Substring(0, i), s2.Substring(0, i)) &&
                IsScramble(s1.Substring(i), s2.Substring(i))) {
                memo[key] = true;
                return true;
            }

            // Case 2: With swapping
            if (IsScramble(s1.Substring(0, i), s2.Substring(n - i)) &&
                IsScramble(s1.Substring(i), s2.Substring(0, n - i))) {
                memo[key] = true;
                return true;
            }
        }

        memo[key] = false;
        return false;
    }
}
