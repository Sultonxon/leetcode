namespace LeetCode;

public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2) {
        var nums1Set = new HashSet<int>(nums1);
        var intersectionSet = new HashSet<int>();
        
        foreach (var i in nums2)
        {
            if (nums1Set.Contains(i))
            {
                intersectionSet.Add(i);
            }
        }
        
        return intersectionSet.ToArray();

    }
    
    public int[] Intersection2(int[] nums1, int[] nums2) {
        var nums1Set = new HashSet<int>(nums1);
        var intersection = new Dictionary<int, int>();
        
        for (var i = 0; i < nums2.Length; i++)
        {
            if (nums1Set.Contains(nums2[i]) )
            {
                if(!intersection.TryAdd(nums2[i], i))
                    intersection[nums2[i]] = i;
            }
        }
        
        return intersection.Keys.ToArray();

    }
}