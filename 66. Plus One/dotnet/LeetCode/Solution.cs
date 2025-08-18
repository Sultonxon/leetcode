namespace LeetCode;

public class Solution
{
    public int[] PlusOne(int[] digits) {
        int index = digits.Length - 1;
        while (true)
        {
            if (index == -1)
            {
                return [1, ..digits];
            }
            if(digits[index] < 9) {
                digits[index]++;
                return digits;
            }
            else
            {
                digits[index] = 0;
                index--;
            }
        }
    }

}