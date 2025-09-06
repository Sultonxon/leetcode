namespace LeetCode;

public class Solution
{
    public int Search(int[] nums, int target)
    {

        int point = 0;
        int left = 0;
        int right = nums.Length - 1;
        while (left < right)
        {
            if (nums[left] > nums[right])
            {
                left++;
            }
            else if (nums[left] < nums[right])
            {
                right--;
            }

            if (left == right - 1)
            {
                if(nums[left] < nums[right]) point = left;
                else point = right;
                break;
            }
        }

        int rotation = point;

        int l = 0;
        int r = nums.Length - 1;
        while (r - l > 1)
        {
            var rotatedL = GetRotatedIndex(l, rotation, nums);
            var rotatedR = GetRotatedIndex(r, rotation, nums);
            var mid = (l + r) / 2;
            var rotatedMid = GetRotatedIndex(mid, rotation, nums);
            if (nums[rotatedMid] == target) return rotatedMid;
            else if (nums[rotatedMid] > target) r = mid;
            else l = mid;
        }


        if(nums[GetRotatedIndex(l, rotation, nums)] == target) return GetRotatedIndex(l, rotation, nums);
        if(nums[GetRotatedIndex(r, rotation, nums)] == target) return GetRotatedIndex(r, rotation, nums);

        return -1;

    }

    private int GetRotatedIndex(int actualIndex, int rotation, int[] array)
    {
        var length = array.Length;
        var rotatedIndex = actualIndex + rotation;
        return rotatedIndex >= length ? rotatedIndex - length : rotatedIndex;
    }
    
}