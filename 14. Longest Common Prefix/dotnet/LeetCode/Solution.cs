

namespace LeetCode;

public class Solution {
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0) return string.Empty;
        if (strs.Length == 1) return strs[0];
        int i = -1;
        while (true)
        {
            if (TheSameInIndex(strs, i + 1)) i++;
            else break;
        }

        return strs[0].Substring(0, i + 1);
    }

    private bool TheSameInIndex(string[] strs, int index)
    {
        for (int i = 0; i < strs.Length - 1; i++)
        {
            var current = strs[i];
            var next = strs[i + 1];
            if (current.Length <= index || next.Length <= index || current[index] != next[index]) return false;
        }

        return true;
    }

}

