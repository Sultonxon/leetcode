// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using LeetCode;

Console.WriteLine(JsonSerializer.Serialize(new Solution().Generate(5)));