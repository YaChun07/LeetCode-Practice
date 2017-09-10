using System;
using System.Collections.Generic;
using System.Linq;

namespace TwoSum
{
    public class TwoSum
    {
        public static int[] twoSum(int[] nums, int target)
        {
            var numDictionary = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                numDictionary.Add(i, nums[i]);
            }

            for (int j = 0; j < nums.Length; j++)
            {
                numDictionary.Remove(j);
                if (numDictionary.ContainsValue(target - nums[j]))
                {
                    return new int[] { j, numDictionary.FirstOrDefault(x => x.Value == target - nums[j]).Key };
                }
            }
            return null;
        }
    }
}