using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    public class TwoSum
    {
        public static int[] twoSum(int[] inputArray, int target)
        {
            int[] twoSumList = new int[2];
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[i] + inputArray[j] == target)
                    {
                        twoSumList[0] = i;
                        twoSumList[1] = j;
                    }
                }
            }
            return twoSumList;
        }
    }
}