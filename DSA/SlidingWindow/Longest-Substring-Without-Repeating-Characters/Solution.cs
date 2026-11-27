public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int[] lastSeen = new int[128];
        Array.Fill(lastSeen, -1);

        int start = 0;
        int maxLength = 0;

        for (int end = 0; end < s.Length; end++)
        {
            int prev = lastSeen[s[end]];

            if (prev >= start)
                start = prev + 1;

            lastSeen[s[end]] = end;

            maxLength = Math.Max(maxLength, end - start + 1);
        }

        return maxLength;
    }
}
