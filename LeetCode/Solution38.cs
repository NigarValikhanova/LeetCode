using System.Text;

public class Solution38
{
    public string CountAndSay(int n)
    {
        if (n == 1) return "1";

        string prev = CountAndSay(n - 1);
        StringBuilder result = new StringBuilder();

        int count = 1;
        for (int i = 1; i < prev.Length; i++)
        {
            if (prev[i] == prev[i - 1])
            {
                count++;
            }
            else
            {
                result.Append(count).Append(prev[i - 1]);
                count = 1;
            }
        }

        result.Append(count).Append(prev[^1]); // Append the last group
        return result.ToString();
    }
}