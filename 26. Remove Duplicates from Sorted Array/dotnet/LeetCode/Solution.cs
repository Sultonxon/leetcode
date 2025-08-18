namespace LeetCode;

public class Solution {
    public int RemoveDuplicates(int[] nums)
    {
        var set = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if(!set.Contains(nums[i])) set.Add(nums[i]);
        }

        int j = 0;
        foreach (var val in set)
        {
            nums[j] = val;
            j++;
        }

        return set.Count;
    }
}