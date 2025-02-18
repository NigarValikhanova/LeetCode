using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution68
    {
        public IList<string> FullJustify(string[] words, int maxWidth)
        {
            IList<string> result = new List<string>();
            int index = 0;

            while (index < words.Length)
            {
                int totalChars = words[index].Length;
                int last = index + 1;

                while (last < words.Length && totalChars + 1 + words[last].Length <= maxWidth)
                {
                    totalChars += 1 + words[last].Length;
                    last++;
                }

                int gaps = last - index - 1;
                StringBuilder sb = new StringBuilder();

                if (last == words.Length || gaps == 0)
                {
                    for (int i = index; i < last; i++)
                    {
                        sb.Append(words[i]);
                        if (i < last - 1) sb.Append(" ");
                    }
                    sb.Append(new string(' ', maxWidth - sb.Length));
                }
                else
                {
                    int spaces = (maxWidth - totalChars + gaps) / gaps;
                    int extraSpaces = (maxWidth - totalChars + gaps) % gaps;

                    for (int i = index; i < last; i++)
                    {
                        sb.Append(words[i]);
                        if (i < last - 1)
                        {
                            sb.Append(new string(' ', spaces + (i - index < extraSpaces ? 1 : 0)));
                        }
                    }
                }

                result.Add(sb.ToString());
                index = last;
            }

            return result;
        }
    }
}
