namespace LeetCode
{
    public class Solution17
    {
        public IList<string> LetterCombinations(string digits)
        {
            if (string.IsNullOrEmpty(digits))
            {
                return new List<string>();
            }

            // Mapping of digits to corresponding letters
            string[] digitToLetters = new string[]
            {
            "",     // 0
            "",     // 1
            "abc",  // 2
            "def",  // 3
            "ghi",  // 4
            "jkl",  // 5
            "mno",  // 6
            "pqrs", // 7
            "tuv",  // 8
            "wxyz"  // 9
            };

            List<string> result = new List<string>();
            Backtrack(digits, 0, new char[digits.Length], result, digitToLetters);
            return result;
        }

        private void Backtrack(string digits, int index, char[] combination, List<string> result, string[] digitToLetters)
        {
            if (index == digits.Length)
            {
                // If we have formed a valid combination, add it to the result
                result.Add(new string(combination));
                return;
            }

            string letters = digitToLetters[digits[index] - '0'];
            foreach (char letter in letters)
            {
                combination[index] = letter;
                Backtrack(digits, index + 1, combination, result, digitToLetters);
            }
        }
    }
}
