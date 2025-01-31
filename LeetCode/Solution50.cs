namespace LeetCode
{
    public class Solution50
    {
        public double MyPow(double x, int n)
        {
            if (n == 0) return 1;
            if (n < 0)
            {
                x = 1 / x;
                if (n == int.MinValue)
                {
                    // Handle edge case where n is the minimum integer value
                    n += 1;
                    x *= x;
                }
                n = -n;
            }

            double result = 1;
            while (n > 0)
            {
                if ((n & 1) == 1)
                {
                    result *= x;
                }
                x *= x;
                n >>= 1; // Right shift n (n = n / 2)
            }
            return result;
        }
    }
}
