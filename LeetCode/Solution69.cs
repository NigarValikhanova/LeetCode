public class Solution69 {
    public int MySqrt(int x) {
        if (x == 0 || x == 1)
            return x;

        int left = 0, right = x, result = 0;

        while (left <= right) {
            long mid = left + (right - left) / 2;
            long square = mid * mid;

            if (square == x)
                return (int)mid;
            else if (square < x) {
                result = (int)mid; // Mümkün cavab
                left = (int)mid + 1;
            } else {
                right = (int)mid - 1;
            }
        }
        return result;
    }
}
