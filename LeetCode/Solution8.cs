namespace LeetCode
{
    public class Solution8
    {
        public int MyAtoi(string s)
        {
            int i = 0, sign = 1, result = 0;
            int n = s.Length;

            // Step 1: Ignore leading whitespaces
            while (i < n && s[i] == ' ')
            {
                i++;
            }

            // Step 2: Determine the sign
            if (i < n && (s[i] == '-' || s[i] == '+'))
            {
                sign = s[i] == '-' ? -1 : 1;
                i++;
            }

            // Step 3: Convert the digits
            while (i < n && Char.IsDigit(s[i]))
            {
                int digit = s[i] - '0';

                // Check for overflow and handle the result
                if (result > (Int32.MaxValue - digit) / 10)
                {
                    return sign == 1 ? Int32.MaxValue : Int32.MinValue;
                }

                result = result * 10 + digit;
                i++;
            }

            // Step 4: Apply the sign and return the result
            return result * sign;
        }
    }
}

