namespace LeetCodeLibrary
{
    /// <summary>
    /// https://leetcode.com/problems/longest-substring-without-repeating-characters/
    /// Given a string s, 
    /// find the length of the longest substring without repeating characters.
    /// </summary>
    public class LongestSubstring
    {
        public static int Execute(string s)
        {
            Dictionary<char, int> charsWithIndex = new();
            int windowStart = 0, maxLength = 0;

            for (int windowEnd = 0; windowEnd < s.Length; windowEnd++)
            {
                char curChr = s[windowEnd];

                if (charsWithIndex.ContainsKey(curChr))
                {
                    windowStart = Math.Max(windowStart, charsWithIndex[curChr] + 1);
                }

                charsWithIndex[curChr] = windowEnd;
                maxLength = Math.Max(maxLength, windowEnd - windowStart + 1);
            }

            return maxLength;
        }
    }
}