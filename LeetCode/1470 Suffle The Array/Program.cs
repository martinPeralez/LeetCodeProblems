using System;
using System.Collections.Generic;

namespace _1470_Suffle_The_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution test = new Solution();
            int[] nums = new int[] { 2, 5, 1, 3, 4, 7 };

            test.Shuffle(nums, 3);
        }
    }
    public class Solution
    {
        public int[] Shuffle(int[] nums, int n)
        {
            List<int> list = new List<int>();
            int j = n;
            for (int i = 0; i < n; i++)
            {
                list.Add(nums[i]);
                list.Add(nums[j]);
                j++;
            }
            int[] array = list.ToArray();
            return array;
        }
    }
}

//Success
//Details 
//Runtime: 240 ms, faster than 71.17% of C# online submissions for Shuffle the Array.
//Memory Usage: 33 MB, less than 72.64% of C# online submissions for Shuffle the Array.
