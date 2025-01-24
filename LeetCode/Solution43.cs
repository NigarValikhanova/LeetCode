using System.Text;

namespace LeetCode
{
    public class Solution43
    {
        public string Multiply(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0") return "0";

            int n1 = num1.Length, n2 = num2.Length;
            int[] result = new int[n1 + n2];

            // Multiply each digit from num1 with each digit from num2
            for (int i = n1 - 1; i >= 0; i--)
            {
                for (int j = n2 - 1; j >= 0; j--)
                {
                    int product = (num1[i] - '0') * (num2[j] - '0');
                    int sum = product + result[i + j + 1];

                    result[i + j + 1] = sum % 10; // Place the current digit
                    result[i + j] += sum / 10;   // Carry over the remainder
                }
            }

            // Convert result array to a string
            StringBuilder sb = new StringBuilder();
            foreach (var digit in result)
            {
                if (!(sb.Length == 0 && digit == 0))
                { // Skip leading zeros
                    sb.Append(digit);
                }
            }

            return sb.ToString();
        }
    }

}
