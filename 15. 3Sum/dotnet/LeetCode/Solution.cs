namespace LeetCode;

public class Solution
{
    struct Triplet : IEquatable<Triplet>
    {
        public int A;
        public int B;
        public int C;

        public Triplet(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public bool Equals(Triplet other)
        {
            return A == other.A && B == other.B && C == other.C;
        }

        public override bool Equals(object? obj)
        {
            return obj is Triplet other && Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(A, B, C);
        }
    }
    
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var start = DateTime.Now;
        Array.Sort(nums);
        var result = new HashSet<Triplet>();

        int counter = 0;
        
        int i = 0;
        int j = 1;
        int k = nums.Length - 1;
        while (i < nums.Length)
        {
            if(i == nums.Length - 2) break;
            if (nums[i] > 0)
            {
                break;
            }
            
            var sum = nums[i] + nums[j] + nums[k];
            if (sum == 0)
            {
                var list = new Triplet(nums[i], nums[j], nums[k] );
                result.Add(list);

                if (j + 1 == k && nums[i] + nums[j] <= 0 && nums[k] >= 0)
                {
                    i++;
                    j = i + 1;
                    k = nums.Length - 1;
                }
                else
                {
                    j++;
                    k--;
                }
            }
            else if (sum > 0) k--;
            else j++;
            
            if(i == nums.Length - 2) break;
            if (k == j)
            {
                i++;
                j = i + 1;
                k=nums.Length - 1;
            }
        }
        
        var r = result.Select(x => (IList<int>)new List<int>(){x.A, x.B, x.C}).ToList();
        return r;
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