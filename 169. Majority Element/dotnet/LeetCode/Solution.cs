namespace LeetCode;

public class Solution
{
    public int MajorityElement(int[] nums) {
        var dict = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (!dict.TryAdd(num, 1))
            {
                dict[num]++;
            }

            if (dict[num] > nums.Length / 2)
            {
                return num;
            }
        }
        
        foreach (var key in dict.Keys)
        {
            if (dict[key] > nums.Length / 2) return key;
        }

        return 0;
    }
}