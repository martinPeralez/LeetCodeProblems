using System;
using System.Collections.Generic;
using System.Linq;

namespace _1431_Kids_With_the_Greatest_Number_of_Candies
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution test = new Solution();
            int[] testInts = new int[] { 12, 1, 12 };
            test.KidsWithCandies(testInts, 10);
        }
    }
    public class Solution
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            IList<bool> lists = new List<bool>();
            int maxCandy = candies.Max();
            for (int i = 0; i < candies.Length; i++)
            {
                int result = candies[i] + extraCandies;
                if (result >= maxCandy)
                {
                    lists.Add(true);
                }
                else
                {
                    lists.Add(false);
                }

            }
            return lists;
        }
    }
}
//Success
//Details 
//Runtime: 236 ms, faster than 71.92% of C# online submissions for Kids With the Greatest Number of Candies.
//Memory Usage: 31.1 MB, less than 91.96% of C# online submissions for Kids With the Greatest Number of Candies.