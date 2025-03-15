using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution93
    {
        public IList<string> RestoreIpAddresses(string s)
        {
            var result = new List<string>();
            Backtrack(s, 0, new List<string>(), result);
            return result;
        }

        private void Backtrack(string s, int index, List<string> segments, List<string> result)
        {
            if (segments.Count == 4)
            {
                if (index == s.Length)
                {
                    result.Add(string.Join(".", segments));
                }
                return;
            }

            for (int len = 1; len <= 3; len++)
            {
                if (index + len > s.Length) break;

                string segment = s.Substring(index, len);
                if (IsValid(segment))
                {
                    segments.Add(segment);
                    Backtrack(s, index + len, segments, result);
                    segments.RemoveAt(segments.Count - 1);
                }
            }
        }

        private bool IsValid(string segment)
        {
            if (segment.Length > 1 && segment[0] == '0') return false;
            int value = int.Parse(segment);
            return value >= 0 && value <= 255;
        }
    }
}
