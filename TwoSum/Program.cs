using System;
using System.Collections.Generic;

namespace TwoSum
{
    internal static class Program
    {
        private static void Main()
        {
            // Test input
            int[] nums = { 2, 7, 11, 15 };
            const int target = 6;

            // Get indices of the two numbers that add up to the target
            var indices = TwoSum(nums, target);

            // Print the indices
            Console.WriteLine($"[{indices[0]}, {indices[1]}]");
        }

        private static int[] TwoSum(int[] nums, int target)
        {
            // Store the difference between each number and the target in a dictionary
            var diffs = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];
                diffs[diff] = i;
            }

            // Iterate over the numbers again and check if the difference exists in the dictionary
            // If it does, return the current index and the index stored in the dictionary
            for (var i = 0; i < nums.Length; i++)
            {
                if (diffs.ContainsKey(nums[i]) && diffs[nums[i]] != i)
                {
                    return new[] { i, diffs[nums[i]] };
                }
            }

            // If no indices are found, return an empty array
            return Array.Empty<int>();
        }
    }
}