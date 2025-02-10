namespace LeetCode
{
    public class Solution60
    {
        public string GetPermutation(int n, int k)
        {
            List<int> numbers = new List<int>();
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                numbers.Add(i);
                fact *= i;
            }

            k--; // Convert to 0-based index
            string result = "";

            for (int i = n; i > 0; i--)
            {
                fact /= i; // Get factorial of (i-1)
                int index = k / fact;
                result += numbers[index];
                numbers.RemoveAt(index);
                k %= fact;
            }

            return result;
        }

    }
}
