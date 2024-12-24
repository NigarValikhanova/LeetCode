using System.Text;

namespace LeetCode
{
    public class Solution12
    {
        public string IntToRoman(int num)
        {
            // Define the Roman numeral symbols and their corresponding values
            string[] romanSymbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            StringBuilder result = new StringBuilder();

            // Iterate through the values and symbols
            for (int i = 0; i < values.Length && num > 0; i++)
            {
                while (num >= values[i])
                {
                    result.Append(romanSymbols[i]);
                    num -= values[i];
                }
            }

            return result.ToString();
        }
    }
}
