namespace LeetCode;

public class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        var dict = new Dictionary<int, int[]>();
        for (var i = 0; i < nums.Length; i++)
        {
            var distance = nums[i] - i;
            if (!dict.ContainsKey(distance))
            {
                dict[distance] = new int[] { nums[i], nums[i] };
            }
            else
            {
                dict[distance][1] = nums[i];
            }
        }
        
        var result = new List<string>();
        foreach (var key in dict.Keys)
        {
            var fist = dict[key][0];
            var second = dict[key][1];
            if (fist == second)
                result.Add(fist.ToString());
            else
                result.Add($"{fist}->{second}");
        }

        return result;
    }
}