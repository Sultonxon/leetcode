namespace LeetCode;

public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k) {

        var set = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!set.Contains(nums[i]))
            {
                set.Add(nums[i]);
            }
            else
            {
                return true;
            }
            
            if (set.Count > k && i - k > 0)
            {
                set.Remove(nums[i - k]);
            }

        }

        return false;
    }
}