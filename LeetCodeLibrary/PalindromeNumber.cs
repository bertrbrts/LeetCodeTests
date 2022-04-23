using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    /// <summary>
    /// https://leetcode.com/problems/palindrome-number/
    /// Given an integer x, return true if x is palindrome integer.
    /// </summary>
    public class PalindromeNumber
    {
        public static bool Execute(int x)
        {
            bool result = false;
            int sign = Math.Sign(x);
            if (sign == 0)
            {
                result = true;
            }
            else if (sign == 1)
            {
                int d = x;
                var digits = new List<int>();
                var reverse = new List<int>();
                while (d != 0)
                {
                    int n = d % 10;
                    digits.Add(n);
                    reverse.Add(n);
                    d /= 10;
                }

                digits.Reverse();

                result = digits.SequenceEqual(reverse);
            }

            return result;
        }
    }
}
