namespace LeetCode
{
    public class Solution30
    {
        public IList<int> FindSubstring(string s, string[] words)
        {
            var result = new List<int>();
            if (words == null || words.Length == 0 || string.IsNullOrEmpty(s))
            {
                return result;
            }

            int wordLength = words[0].Length;
            int wordCount = words.Length;
            int totalWordsLength = wordLength * wordCount;
            if (s.Length < totalWordsLength)
            {
                return result;
            }

            // Create a frequency map for the words
            var wordMap = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (wordMap.ContainsKey(word))
                    wordMap[word]++;
                else
                    wordMap[word] = 1;
            }

            // Iterate through each possible starting offset within a word length
            for (int offset = 0; offset < wordLength; offset++)
            {
                int left = offset, right = offset, matchCount = 0;
                var windowMap = new Dictionary<string, int>();

                while (right + wordLength <= s.Length)
                {
                    // Get the next word from the right
                    string word = s.Substring(right, wordLength);
                    right += wordLength;

                    if (wordMap.ContainsKey(word))
                    {
                        if (!windowMap.ContainsKey(word))
                            windowMap[word] = 0;
                        windowMap[word]++;

                        // If this word is within the allowed frequency, count it
                        if (windowMap[word] <= wordMap[word])
                            matchCount++;
                        else
                        {
                            // Adjust the left pointer to remove excess words
                            while (windowMap[word] > wordMap[word])
                            {
                                string leftWord = s.Substring(left, wordLength);
                                windowMap[leftWord]--;
                                if (windowMap[leftWord] < wordMap[leftWord])
                                    matchCount--;
                                left += wordLength;
                            }
                        }

                        // If all words are matched, record the starting index
                        if (matchCount == wordCount)
                            result.Add(left);
                    }
                    else
                    {
                        // Reset the window if the word is invalid
                        windowMap.Clear();
                        matchCount = 0;
                        left = right;
                    }
                }
            }

            return result;
        }
    }
}
