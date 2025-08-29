// See https://aka.ms/new-console-template for more information

using LeetCode;


Console.WriteLine("Hello, World!");
var res = new Solution().FourSum([1000000000,1000000000,1000000000,1000000000], -294967296);

foreach (var intse in res)
{
    Console.WriteLine(string.Join(", ", intse));
}