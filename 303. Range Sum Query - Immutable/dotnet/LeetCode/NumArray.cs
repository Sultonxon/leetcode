namespace LeetCode;

public class NumArray
{
    private readonly int[] _nums;
    public NumArray(int[] nums)
    {
        _nums = nums;
    }
    
    public int SumRange(int left, int right)
    {
        int summ = 0;
        for (int i = left; i <= right; i++)
        {
            summ += _nums[i];
        }

        return summ;
    }
}