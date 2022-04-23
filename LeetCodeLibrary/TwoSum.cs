namespace LeetCodeLibrary
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum/
    /// Given an array of integers nums and an integer target, 
    /// return indices of the two numbers such that they add up to target.    
    /// </summary>
    public class TwoSum
    {
        public static int[] Execute(int[] nums, int target)
        {
            var result = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int x = i + 1; x < nums.Length; x++)
                {
                    if (nums[i] + nums[x] == target)
                    {
                        result = new int[] { i, x };
                    }
                }
            }

            return result;
        }
    }
}