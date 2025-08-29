namespace LeetCode;

public class Solution
{
    public void NextPermutation(int[] nums)
    {
        int point = -1;

        for (int i = nums.Length - 2; i >= 0 ; i--)
        {
            if (nums[i] < nums[i + 1])
            {
                point = i;
                break;
            }
        }
        if (point == -1)
        {
            Array.Sort(nums);
            return;
        }
        var pointValue = nums[point];
        var replacementIndex = point + 1;
        var replacementValue = nums[replacementIndex];
        for (int i = nums.Length - 1 ; i > point; i--)
        {
            if (pointValue < nums[i])
            {
                replacementIndex = i;
                replacementValue = nums[i];
                break;
            }
        }
        
        nums[point] = nums[replacementIndex];
        nums[replacementIndex] = pointValue;
        Array.Sort(nums, point + 1, nums.Length - point - 1);
    }
}