namespace LeetCode;

public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int i = 0;
        for (int j = 0; j < n; j++)
        {
            var val = nums2[j];
            while (nums1[i] < val && i < m + j)
            {
                i++;
            }
            MoveValues(nums1, i);
            nums1[i] = val;
        }
    }

    public void MoveValues(int[] nums, int startIndex)
    {
        for (int i = nums.Length - 2; i >= startIndex; i--)
        {
            nums[i + 1] = nums[i];
        }
    }
}