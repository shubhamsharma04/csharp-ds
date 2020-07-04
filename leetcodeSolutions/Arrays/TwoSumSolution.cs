using System;
using System.Collections.Generic;

namespace Arrays
{
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, List<int>> elementById = GetElementById(nums);
            int[] output = new int[2];

            for(int index = 0; index < nums.Length - 1; index++)
            {
                if(elementById.TryGetValue(target - nums[index], out List<int> indices))
                {
                    output[0] = index;
                    if (nums[index] == target - nums[index])
                    {
                        if(indices.Count > 1)
                        {
                            output[1] = indices[1];
                            break;
                        }
                    } else
                    {
                        output[1] = indices[0];
                        break;
                    }
                }
            }

            return output;
        }

        private Dictionary<int, List<int>> GetElementById(int[] nums)
        {
            Dictionary<int, List<int>> elementById = new Dictionary<int, List<int>>();

            for(int index=0; index < nums.Length; index++)
            {
                if(elementById.TryGetValue(nums[index], out List<int> indices))
                {
                    indices.Add(index);
                } else
                {
                    indices = new List<int>(){index};
                    elementById.Add(nums[index], indices);
                }
            }
            return elementById;
        }
    }
}
