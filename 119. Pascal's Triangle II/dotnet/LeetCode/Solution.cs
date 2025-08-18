namespace LeetCode;

public class Solution
{
    public IList<int> GetRow(int rowIndex)
    {
        IList<int> above = null;
        while (rowIndex > 0)
        {
            rowIndex--;
            var current = new List<int>(above?.Count ?? 1);
            if (above == null)
            {
                current.Add(1);
            }
            else
            {
                current.Add(1);
                for (int i = 0; i < above.Count - 1; i++)
                {
                    current.Add(above[i] + above[i + 1]);
                }
                current.Add(1);
            }
            above = current;
        }

        return above;
    }
}