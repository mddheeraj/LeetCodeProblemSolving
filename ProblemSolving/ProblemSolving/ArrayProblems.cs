using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class ArrayProblems
    {

        public static void PrintResult(int[] nums, int target, Func<int[], int, int[]> method)
        {
            int[] result = method(nums, target);
            if (result != null)
            {
                foreach (int val in result)
                {
                    Console.WriteLine(val);
                }
            }
        }

        public static void PrintResult(int[] nums, Func<int[], int> methodName)
        {
            int? result = methodName(nums);
            if(result != null)
            {
                Console.WriteLine(result);
            }
        }

        //https://leetcode.com/problems/two-sum/description/
        public static int[] TwoSum(int[] nums, int target)
        {
            //variable to store results
            int[] results = new int[2];
            //variable to store indices
            Dictionary<int, int> dictionaryIndices = new Dictionary<int, int>();

            for(int i = 0; i < nums.Length; i++)
            {
                int difference = target - nums[i];
                if(dictionaryIndices.ContainsKey(difference))
                {
                    results[0] = i;
                    results[1] = dictionaryIndices[difference];
                    return results;
                }
                if(!dictionaryIndices.ContainsKey(difference))
                {
                    dictionaryIndices.Add(nums[i], i);
                }
            }

            results = null;
            return results;
        }

        public static int[] TwoSum2(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                dict[nums[i]] = i;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int j;
                if (dict.TryGetValue(target - nums[i], out j) && j != i)
                {
                    return new[] { i, j };
                }
            }

            return null;
        }

        //https://leetcode.com/problems/container-with-most-water/description/
        public static int MaxArea(int[] height)
        {
            int highest = -1;
            int l = 0, r = height.Length-1;
            while(l<r)
            {
                highest = Math.Max((Math.Min(height[l], height[r]) * (r - l)), highest);

                if (height[l] < height[r])
                    l++;
                else
                    r--;
            }
            return highest;
        }
    }
}
