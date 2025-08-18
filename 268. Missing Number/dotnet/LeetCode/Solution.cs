namespace LeetCode;

public class Solution
{
    public int MissingNumber(int[] nums)
    {
        var set = new HashSet<int>();

        var min = 0;
        var max = nums[0];

        foreach (var num in nums)
        {
            if (num > max) max = num;
            set.Add(num);
        }

        Console.WriteLine($"Min: {min}, Max: {max}");

        while (min <= max)
        {
            Console.WriteLine($"Iteration. Min: {min}, Max: {max},  set: ({string.Join(", ", set)})");
            if (!set.Contains(min)) return min;
            min++;
        }

        return max + 1;
    }
}