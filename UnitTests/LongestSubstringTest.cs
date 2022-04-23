using NUnit.Framework;
using System.Collections.Generic;
using LeetCodeLibrary;

namespace UnitTests
{
    [TestFixture]
    internal class LongestSubstringTest
    {
        [Test, TestCaseSource("cases")]
        public void Execute(string s, int expectedResult)
        {
            int result = LongestSubstring.Execute(s);
            Assert.AreEqual(expectedResult, result);
        }

        private static IEnumerable<TestCaseData> cases()
        {
            string test1 = "abcabcbb";
            int expectedResult1 = 3;
            yield return new TestCaseData(test1, expectedResult1);

            string test2 = "bbbbb";
            int expectedResult2 = 1;
            yield return new TestCaseData(test2, expectedResult2);

            string test3 = "pwwkew";
            int expectedResult3 = 3;
            yield return new TestCaseData(test3, expectedResult3);

            string test4 = "au";
            int expectedResult4 = 2;
            yield return new TestCaseData(test4, expectedResult4);

            string test5 = "dvdf";
            int expectedResult5 = 3;
            yield return new TestCaseData(test5, expectedResult5);

        }
    }
}