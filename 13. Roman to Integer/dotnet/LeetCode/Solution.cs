using System.Collections.Frozen;
namespace LeetCode;

public class Solution {
    
    private static int GetNumber(char c) =>
    c switch
    {
        'I' => 1,
        'V' => 5,
        'X' => 10,
        'L' => 50,
        'C' => 100,
        'D' => 500,
        'M' => 1000,
        _ => 0
    };

    public int RomanToInt(string s) {
        int n = 0;
        int max = 0;
        for(int i = s.Length - 1; i >= 0; i--)
        {
            var num = GetNumber(s[i]);
            if(num < max){
                n -= num;
            }
            else{
                n += num;
                max = num;
            }
        }

        return n;
    }
}