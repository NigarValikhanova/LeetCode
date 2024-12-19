namespace LeetCode
{
    public class Solution7
    {
        public int Reverse(int x)
        {
            int result = 0;

            while (x != 0)
            {
                int digit = x % 10;
                x /= 10;

                // Check for overflow before actually adding the digit
                if (result > (int.MaxValue / 10) || (result == (int.MaxValue / 10) && digit > 7))
                {
                    return 0; // Overflow
                }
                if (result < (int.MinValue / 10) || (result == (int.MinValue / 10) && digit < -8))
                {
                    return 0; // Underflow
                }

                result = result * 10 + digit;
            }

            return result;
        }
    }
}
