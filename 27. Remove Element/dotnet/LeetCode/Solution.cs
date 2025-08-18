namespace LeetCode;

public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int i = 0;
        for (int j = 0; j < nums.Length; j++)
        {
            if (nums[j] == val) i++;
            if(j >= i && nums[j] != val)
                nums[j - i] = nums[j];
        }

        return nums.Length - i;
    }
}