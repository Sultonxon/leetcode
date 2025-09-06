namespace LeetCode;

public class Solution
{

    public int[] SearchRange(int[] nums, int target)
    {
        var left = 0;
        while (true)
        {
            if (nums[left] < target) left = (left + nums.Length - 1) / 2;
            else if (nums[left] > target) left = left / 2;
            else
            {
                if (left == 0 || nums[left - 1] < target) break;
                else left = left / 2;
            }
        }

        var right = nums.Length - 1;

        while (true)
        {
            if (nums[right] > target) right = (right + left) / 2;
            else if(nums[right] < target) right = (right + nums.Length - 1) / 2;
            else
            {
                if(right == nums.Length - 1 || nums[right + 1] > target) break;
                else right = (right + left) / 2;
            }
        }
        
        return new int[] { left, right };
    }
}