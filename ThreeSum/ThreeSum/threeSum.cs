using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSum
{
    public class threeSum
    {
        public static List<List<int>> threeSumRef(int[] nums)
        {
            Array.Sort(nums);

            List<List<int>> answers = new List<List<int>>();
            if (nums.Length < 3)
            {
                return answers;
            }
            for (int count = 0; count < nums.Length - 2; count++)
            {
                int target = 0 - nums[count];

                if (target < nums[count + 1])
                {
                    break;
                }

                for (int k = count + 1; k < nums.Length; k++)
                {

                    if (nums.Contains(target - nums[k]) && Array.LastIndexOf(nums, target - nums[k]) > k)
                    {

                        answers.Add(new List<int> { nums[count], nums[k], target - nums[k] });

                        while (k < nums.Length - 1 && nums[k] == nums[k + 1])
                        {
                            k++;
                        }
                    }
                }
                while (count < nums.Length - 1 && nums[count] == nums[count + 1])
                {
                    count++;
                }
            }
            return answers;
        }
    }

}
