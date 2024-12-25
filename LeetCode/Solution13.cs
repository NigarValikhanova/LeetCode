namespace LeetCode
{
    public class Solution13
    {
        public int RomanToInt(string s)
        {
            // Dictionary to map Roman numerals to their integer values
            var romanMap = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

            int total = 0;
            int prevValue = 0;

            // Traverse the Roman numeral string from right to left
            for (int i = s.Length - 1; i >= 0; i--)
            {
                int currentValue = romanMap[s[i]];

                // Check if we need to subtract or add the current value
                if (currentValue < prevValue)
                {
                    total -= currentValue;
                }
                else
                {
                    total += currentValue;
                }

                prevValue = currentValue; // Update the previous value
            }

            return total;
        }
    }
}
