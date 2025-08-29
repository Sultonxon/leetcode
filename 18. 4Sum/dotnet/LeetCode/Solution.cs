namespace LeetCode;

public class Solution
{
    public IList<IList<int>> FourSum(int[] nums, int target) {
        Array.Sort(nums);
        var result = new List<IList<int>>();

        for (int i = 0; i < nums.Length - 3; i++)
        {
            if(i > 0 && nums[i-1] == nums[i]) continue;
            for (int j = i + 1; j < nums.Length - 2; j++)
            {
                if(j > i + 1 && nums[j-1] ==  nums[j]) continue;
                var left = j + 1;
                var right = nums.Length - 1;

                bool leftIncr = false;
                bool rightIncr = false;
                while (left < right)
                {
                    if(leftIncr && left > j + 1 && nums[left] == nums[left - 1])
                    {
                        left++;
                        continue;
                    }

                    if (rightIncr && right < (nums.Length - 1) && nums[right] == nums[right + 1])
                    {
                        right--;
                        continue;
                    }
                    var sum = (long)nums[left] + (long)nums[right] + (long)nums[i] +(long) nums[j];
                    if (sum == target)
                    {
                        Console.WriteLine($"sum: {sum},  nums[i]: {nums[i]}, nums[j]: {nums[j]}, nums[left]: { nums[left]}, nums[right]: {nums[right]}");
                        result.Add(new List<int>() { nums[i], nums[j], nums[left], nums[right] });
                        left++;
                        right--;
                        leftIncr = true;
                        rightIncr = true;
                    }
                    else if (sum < target)
                    {
                        left++;
                        leftIncr = true;
                        rightIncr = false;
                    }
                    else
                    {
                        right--;
                        rightIncr = true;
                        leftIncr = false;
                    }
                }
            }
        }

        return result;

    }
}