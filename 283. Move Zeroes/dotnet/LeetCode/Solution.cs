namespace LeetCode;

public class Solution {
    public void MoveZeroes(int[] nums)
    {
        int firstZero = 0;
        int nextNonZero = 0;

        while (firstZero <= nextNonZero && firstZero < nums.Length && nextNonZero < nums.Length)
        {

            if (nums[firstZero] == 0 && nums[nextNonZero] != 0)
            {
                nums[firstZero] = nums[nextNonZero];
                nums[nextNonZero] = 0;
            }
            
            
            nextNonZero++;
            if (nums[firstZero] != 0) firstZero++;
        }
    }
}