namespace LeetCode;

public class Solution
{
    public int Search(int[] nums, int target)
    {
        var start = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] > nums[i + 1])
            {
                start = i + 1;
                break;
            }
        }

        int point = 0;
        int left = 0;
        int right = nums.Length - 1;
        while (true)
        {
            if (nums[left] < nums[right])
            {
                left = (right + left) / 2;
            }
            else if (nums[left] > nums[right])
            {
                right = (left + right) / 2;
            }

            if (left == right - 1)
            {
                if(nums[left] < nums[right]) point = left;
                else point = right;
                break;
            }
        }

        int rotation = point;

        while (true)
        {
            
        }
        
    }
    
}