namespace LeetCodeLibrary
{
    /// <summary>
    /// https://leetcode.com/problems/roman-to-integer/
    /// Given a roman numeral, convert it to an integer.
    /// </summary>
    public class RomanToInteger
    {
        enum RomanNumeral { I = 1, V = 5, X = 10, L = 50, C = 100, D = 500, M = 1000 }
        public static int Execute(string s)
        {
            List<int> nums = new();
            int previous = 0;
            foreach (var c in s.ToCharArray())
            {
                int current = (int)Enum.Parse(typeof(RomanNumeral), c.ToString());
                if (previous < current)
                {
                    current -= previous;
                    nums.Remove(previous);
                }
                previous = current;
                nums.Add(current);
            }

            return nums.Sum();
        }
    }
}