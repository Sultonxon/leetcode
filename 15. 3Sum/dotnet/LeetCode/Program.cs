// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using LeetCode;


var start = DateTime.Now;
var json = File.ReadAllText("testdata.json");
var array = JsonSerializer.Deserialize<int[]>(json);
var result = new Solution().ThreeSum(array); //[-2,0,1,1,2]);

var d1 = (DateTime.Now - start);
start = DateTime.Now;
var result2 = new Solution().ThreeSum2(array);
var d2 = (DateTime.Now - start);

// foreach (var item in result)
// {
//     Console.WriteLine($"[{string.Join(", ", item)}]");
// }


Console.WriteLine($"duration 1: {d1}    duration 2: {d2}");

var x = new List<int>(){1,2,3}.ToArray();

Console.WriteLine(x == new int[]{1,2,3});


