namespace LeetCode;

public class Solution {
    public int SearchInsert(int[] nums, int target)
    {
        int start = 0;
        int end = nums.Length - 1;
        while (start <= end)
        {
            int mid = (start + end) / 2;
            if(nums[mid] == target) return mid;
            if (end - start == 1)
            {
                if(nums[start] >= target) return start;
                if (nums[end] >= target) return end;
                return end + 1;
            }

            if (end == start)
            {
                if(nums[start] >= target) return start;
                return start + 1;
            }
            
            if (nums[mid] < target)
            {
                start = mid + 1;
            }
            else
            {
                end = mid;
            }
        }

        return 0;
    }
}

