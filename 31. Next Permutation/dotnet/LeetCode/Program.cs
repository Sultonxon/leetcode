// See https://aka.ms/new-console-template for more information
using LeetCode;Console.WriteLine("Hello, World!");

Random rand = new Random();
int[] nums = Enumerable.Range(0, 99).OrderBy(x => rand.Next()).ToArray();


int[] arr = [2,3,1];
var start = DateTime.Now;
new Solution().NextPermutation(nums);
Console.WriteLine(DateTime.Now - start);
Console.WriteLine(string.Join(", ", nums));