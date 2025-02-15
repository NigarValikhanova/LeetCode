public class Solution65 {
    public bool IsNumber(string s) {
        s = s.Trim();
        bool seenDigit = false, seenDot = false, seenE = false;
        int n = s.Length;

        for (int i = 0; i < n; i++) {
            char c = s[i];
            
            if (char.IsDigit(c)) {
                seenDigit = true;
            } 
            else if (c == '+' || c == '-') {
                if (i > 0 && s[i - 1] != 'e' && s[i - 1] != 'E') return false;
            } 
            else if (c == '.') {
                if (seenDot || seenE) return false;
                seenDot = true;
            } 
            else if (c == 'e' || c == 'E') {
                if (seenE || !seenDigit) return false;
                seenE = true;
                seenDigit = false;
            } 
            else {
                return false;
            }
        }

        return seenDigit;
    }
}