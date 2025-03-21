public class Solution70 {
    public int ClimbStairs(int n) {
        if (n == 1) return 1;
        if (n == 2) return 2;

        int first = 1, second = 2, result = 0;
        for (int i = 3; i <= n; i++) {
            result = first + second;
            first = second;
            second = result;
        }
        return result;
    }
}
