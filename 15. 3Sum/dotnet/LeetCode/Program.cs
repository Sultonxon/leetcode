// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using LeetCode;

int a = 1 - 1;
var i = 3 % a;

var start = DateTime.Now;
var json = File.ReadAllText("testdata.json");
var array = JsonSerializer.Deserialize<int[]>(json);
var result = new Solution().ThreeSum(array);
foreach (var item in result)
{
    Console.WriteLine($"[{string.Join(", ", item)}]");
}

Console.WriteLine(DateTime.Now - start);