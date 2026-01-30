using System;
using System.Collections.Generic;
using System.Text;

namespace LiveCoding.Lab.Core.Exercises.Arrays
{
    public static class TwoSum
    {
        public static int[] Execute(int[] nums, int target) 
        {
            var map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++) 
            {
                int complement = target - nums[i];

                if (map.TryGetValue(complement, out int index))
                    return new[] { index, i };

                map[nums[i]] = i;
            }
            throw new ArgumentException("No solution found.");
        }
    }
}
