namespace LeetCode;

public class Solution
{
    public int MaxArea(int[] height)
    {
        int start = 0;
        int end = height.Length - 1;
        
        int maxArea = 0;
        
        while (start < end)
        {
            int width = end - start;
            int currentHeight = Math.Min(height[start], height[end]);
            int currentArea = width * currentHeight;
            maxArea = Math.Max(maxArea, currentArea);
            Console.WriteLine($"start: {start}, end: {end}, width: {width}, currentHeight: {currentHeight}, currentArea: {currentArea}, maxArea: {maxArea}");

            if (height[start] < height[end])
            {
                start++;
            }
            else
            {
                end--;
            }
            
            Console.WriteLine($"start: {start}, end: {end}, width: {width}, currentHeight: {currentHeight}, currentArea: {currentArea}, maxArea: {maxArea}");

        }
        return maxArea;
    }
}