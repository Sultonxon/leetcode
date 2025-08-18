namespace LeetCode;

public class Solution
{
    public IList<IList<int>> Generate(int numRows) {
        
        var result = new List<IList<int>>();
        while (numRows > 0)
        {
            numRows--;
            var above = result.Count > 0 ? result[result.Count - 1] : null;
            var row = new List<int>();
            if (above == null)
            {
                row.Add(1);
            }
            else
            {
                row.Add(1);
                for (int i = 1; i <= above.Count - 1; i++)
                {
                    row.Add(above[i] + above[i - 1]);
                }
                row.Add(1);
            }
            result.Add(row);
        }

        return result;
    }
}