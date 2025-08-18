// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using LeetCode;

int[] nums1 = [1, 2, 3, 0, 0, 0];
int m = 3;
int[] nums2 = [2, 5, 6];
int n = 3;
new Solution().Merge(nums1, m, nums2, n);
Console.WriteLine(JsonSerializer.Serialize(nums1));
