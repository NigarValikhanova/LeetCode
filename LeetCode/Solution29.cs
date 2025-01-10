namespace LeetCode
{
    public class Solution29
    {
        public int Divide(int dividend, int divisor)
        {
            // Handle edge case where result exceeds 32-bit integer range
            if (dividend == int.MinValue && divisor == -1) return int.MaxValue;
            if (dividend == int.MinValue && divisor == 1) return int.MinValue;

            // Determine the sign of the result
            bool isNegative = (dividend < 0) ^ (divisor < 0);

            // Convert both dividend and divisor to long to avoid overflow
            long absDividend = Math.Abs((long)dividend);
            long absDivisor = Math.Abs((long)divisor);

            long quotient = 0;

            // Perform division using subtraction and bit shifting
            while (absDividend >= absDivisor)
            {
                long tempDivisor = absDivisor;
                long multiple = 1;

                // Double the divisor until it exceeds the dividend
                while (absDividend >= (tempDivisor << 1))
                {
                    tempDivisor <<= 1;
                    multiple <<= 1;
                }

                // Subtract the largest possible multiple of divisor from the dividend
                absDividend -= tempDivisor;
                quotient += multiple;
            }

            // Apply the sign to the quotient
            if (isNegative) quotient = -quotient;

            // Clamp the result to the 32-bit signed integer range
            if (quotient > int.MaxValue) return int.MaxValue;
            if (quotient < int.MinValue) return int.MinValue;

            return (int)quotient;
        }
    }
}
