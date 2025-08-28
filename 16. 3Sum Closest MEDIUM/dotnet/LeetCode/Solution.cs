namespace LeetCode;

public class Solution
{
    public int ThreeSumClosest(int[] nums, int target) {
        
        Array.Sort(nums);
        var sum = nums[0] + nums[1] + nums[2];

        for (int i = 0; i < nums.Length - 2; i++)
        {
            if(i>0 && nums[i-1] == nums[i]) continue;
            
            var left = i + 1;
            var right = nums.Length - 1;
            while (left < right)
            {
                var currentSum = nums[i] + nums[left] + nums[right];
                var currentDiff = currentSum - target;
                var diff = Math.Abs(sum - target);

                if (Math.Abs(currentDiff) < diff)
                {
                    sum = currentSum;
                }

                if (currentDiff > 0)
                {
                    right--;
                }
                else if (currentDiff < 0)
                {
                    left++;
                }
                else
                {
                    return currentSum;
                }
                
            }
        }

        return sum;
    }
    
}