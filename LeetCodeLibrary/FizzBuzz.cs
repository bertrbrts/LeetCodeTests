using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class FizzBuzz
    {
        public static List<string> Execute(int n)
        {
            List<string> result = new();
            for (int i = 1; i <= n; i++)
            {
                string s = string.Empty;
                if (i % 3 == 0)
                {
                    s += "Fizz";
                }

                if (i % 5 == 0)
                {
                    s += "Buzz";
                }

                if (string.IsNullOrEmpty(s))
                {
                    s = i.ToString();
                }

                result.Add(s);
            }

            return result;
        }
    }
}
