namespace LeetCode;

public class Solution
{
    public int MaxProfit(int[] prices) {
        int profit = 0;

        int previousMax = int.MinValue;
        for (int i = 0; i < prices.Length - 1; i++)
        {
            if (previousMax == prices[i])
            {
                profit = Math.Max(profit, 0);
                previousMax = int.MinValue;
                continue;
            }
            if (previousMax == int.MinValue)
            {
                
                var max = prices[i + 1];
                for (int j = i + 1; j < prices.Length; j++)
                {
                    max = Math.Max(max, prices[j]);
                }

                previousMax = max;
            }
            else if(previousMax != prices[i])
            {
                profit = Math.Max(profit, previousMax - prices[i]);
            }

            //profit = Math.Max(profit, previousMax - prices[i]);
        }

        return profit;
    }
    
    public int MaxProfit2(int[] prices) {
            int profit = 0;
    
            for (int i = 0; i < prices.Length - 1; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    int currentProfit = prices[j] - prices[i];
                    profit = profit < currentProfit ? currentProfit : profit;
                }
            }
    
            return profit;
        }
    
    
    public int MaxProfit3(int[] prices)
    {

        int windowSize = (int)Math.Sqrt(prices.Length);
        var maxWindowPrices = new Dictionary<int, int>();
        int profit = 0;

        for (int i = 0; i < prices.Length - 1; i++)
        {
            int initialWindowIndex = GetNearWindow(i, windowSize);
            for (int j = i + 1; j < Math.Min(initialWindowIndex, prices.Length); j++)
            {
                profit = Math.Max(profit, prices[j] - prices[i]);
            }
            
            for (int windowIndex = initialWindowIndex; windowIndex < prices.Length; windowIndex+=windowSize)
            {
                if (!maxWindowPrices.ContainsKey(windowIndex))
                {
                    var start = windowIndex;
                    int end = windowIndex + windowSize - 1;
                    var max = prices[start];
                    for (int j = start; j <= end && j < prices.Length; j++)
                    {
                        max = Math.Max(max, prices[j]);
                    }
                    maxWindowPrices[windowIndex] = max;
                }
                
                profit = Math.Max(profit, maxWindowPrices[windowIndex] - prices[i]);
            }
        }


        return profit;
    }
    
    public int GetNearWindow(int index, int windowSize)
    {
        return (index + 1) % windowSize == 0 ? (index + 1)  : index + 1 + windowSize - (index + 1) % windowSize;
    }
}