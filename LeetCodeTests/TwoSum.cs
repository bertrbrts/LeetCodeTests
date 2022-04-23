namespace LeetCodeTests
{
    internal class TwoSum
    {
       public static int[] GetTwoSum(int[] nums, int target)
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