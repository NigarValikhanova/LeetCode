public class Solution58 {
    public int LengthOfLastWord(string s) {
         if (string.IsNullOrWhiteSpace(s)) return 0;
        
        s = s.Trim(); // Remove leading and trailing spaces
        int lastSpaceIndex = s.LastIndexOf(' ');
        
        return s.Length - lastSpaceIndex - 1;
    }
}