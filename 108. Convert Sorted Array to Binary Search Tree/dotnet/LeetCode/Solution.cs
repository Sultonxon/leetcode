namespace LeetCode;

public class Solution
{
    public TreeNode SortedArrayToBST(int[] nums)
    {
        return SortedArrayToBST(nums, 0, nums.Length - 1);
    }


    private TreeNode? SortedArrayToBST(int[] nums, int startIndex, int endIndex)
    {
        if(endIndex < startIndex)
        {
            return null;
        }
        var midIndex = (int)Math.Ceiling((startIndex + endIndex) / 2.0);

        var head = new TreeNode(nums[midIndex], SortedArrayToBST(nums, startIndex, midIndex - 1),
            SortedArrayToBST(nums, midIndex + 1, endIndex));

        return head;
    }
}
