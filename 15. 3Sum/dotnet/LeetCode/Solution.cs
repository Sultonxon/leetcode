namespace LeetCode;

public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        var result = new List<IList<int>>();

        int i=0, j=1, k = nums.Length-1;
        int lastI = int.MinValue;
        var lastJ = int.MinValue;
        var lastK = int.MinValue;

        while (i < nums.Length - 1 && j < nums.Length && k >= 0)
        {
            if (k == j)
            {
                k++;
                continue;
            }

            if (k == i)
            {
                i++;
                k = nums.Length - 1;
                j = i + 1;
                if(i == nums.Length - 1) break;
                continue;
            }
            
            var sum = nums[i] + nums[j] + nums[k];
//
//             Console.WriteLine(
//                 $"(i, j, k): ({i}, {j}, {k}),  nums[i]: {nums[i]}, nums[j]: {nums[j]}, nums[k]: {nums[k]},  sum: {sum}, result count: {result.Count}");
// //                                  $"lastI: {lastI}, lastJ: {lastJ}, lastK: {lastK},  {lastI == nums[i] && lastJ == nums[j] && lastK == nums[k]}, ");
//             

            
            if (sum == 0)
            {

                if (lastI == nums[i] && lastJ == nums[j] && lastK == nums[k])
                {
                    if (j == k - 1)
                    {
                        i++;
                        j = i + 1;
                    }
                    else
                    {
                        j++;
                    }
                }
                else
                {
                    result.Add(new List<int> { nums[i], nums[j], nums[k] });
                }
                lastI = nums[i];
                lastJ = nums[j];
                lastK = nums[k];
            }
            else if (sum > 0)
            {
                lastI = nums[i];
                lastJ = nums[j];
                lastK = nums[k];
                k--;
            }
            else if (sum < 0)
            {
                lastI = nums[i];
                lastJ = nums[j];
                lastK = nums[k];
                if (j == nums.Length - 1)
                {
                    i++;
                    j = i + 1;
                    k = nums.Length - 1;
                }
                else
                {
                    j++;
                }
            }
        }

        return result;
    }
    
    public IList<IList<int>> ThreeSum2(int[] nums)
    {
        var result = new List<IList<int>>();
        for (int i = 0; i < nums.Length - 2; i++)
        {
            for (int j = i + 1; j < nums.Length - 1; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[j] + nums[k] == 0)
                    {
                        var list = new List<int>() { nums[i], nums[j], nums[k] };
                        list.Sort();
                        if(result.Any(x => x.SequenceEqual(list)))
                        {
                            continue;
                        }
                        result.Add(list);
                    }
                }
            }
        }

        return result;
    }
}