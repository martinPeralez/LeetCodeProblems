using System;

namespace _1748_SumOfUniqueElements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example 1:

            //Input: nums = [1, 2, 3, 2]
            //Output: 4
            //Explanation: The unique elements are[1, 3], and the sum is 4.
            Solution problem = new Solution();
            int[] nums = new int[] { 1, 1, 1, 1 };
            problem.SumOfUnique(nums);
        }
    }
    public class Solution
    {
        public int SumOfUnique(int[] nums)
        {
            int sumOfNums = 0;
            Array.Sort(nums);

            if (nums.Length == 0)
            {
                return 0;
            }

            if (nums.Length ==1)
            {
                return 0;
            }

            for (int i = 1; i < nums.Length - 1; i++)
            {
                if (nums[i-1] != nums[i] && nums[i] != nums[i+1])
                {
                    sumOfNums += nums[i];
                }
            }

            if (nums[0] != nums[1])
            {
                sumOfNums += nums[0];
            }
            if (nums[nums.Length - 1] != nums[nums.Length - 2])
            {
                sumOfNums += nums.Length - 1;
            }

            return sumOfNums;
        }
    }
}

//Success

//Details 
//Runtime: 96 ms, faster than 27.35% of C# online submissions for Sum of Unique Elements.
//Memory Usage: 24.7 MB, less than 82.65% of C# online submissions for Sum of Unique Elements.