using LeetCodeLibrary;
using NUnit.Framework;
using System.Collections.Generic;

namespace UnitTests
{
    [TestFixture]
    public class RomanToIntegerTest
    {
        [Test, TestCaseSource("cases")]
        public void Execute(string s, int expectedResult)
        {
            var result = RomanToInteger.Execute(s);
            Assert.AreEqual(expectedResult, result);
        }

        private static IEnumerable<TestCaseData> cases()
        {
            string test1 = "III";
            int expectedResult1 = 3;
            yield return new TestCaseData(test1, expectedResult1);

            string test2 = "LVIII";
            int expectedResult2 = 58;
            yield return new TestCaseData(test2, expectedResult2);

            string test3 = "MCMXCIV";
            int expectedResult3 = 1994;
            yield return new TestCaseData(test3, expectedResult3);
        }
    }
}
