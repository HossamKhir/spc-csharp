// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] nums = new int[10];
var rnd = new Random();
for (int i = 0; i < nums.Length; ++i)
{
    nums[i] = rnd.Next();
}

// classic for
// for (int i = 0; i < nums.Length; ++i)
// {
//     Console.WriteLine(nums[i]);
// }

// enhanced for (foreach)
foreach (var i in nums)
{
    Console.WriteLine(i);
}