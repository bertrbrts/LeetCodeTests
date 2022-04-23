using LeetCodeLibrary;
using NUnit.Framework;
using System.Collections.Generic;

namespace UnitTests
{
    [TestFixture]
    public class PalindromeNumberTest
    {
        [Test, TestCaseSource("cases")]
        public void Execute(int x, bool expectedResult)
        {
            var result = PalindromeNumber.Execute(x);
            Assert.AreEqual(expectedResult, result);
        }

        private static IEnumerable<TestCaseData> cases()
        {
            int test1 = 121;
            bool expectedResult1 = true;
            yield return new TestCaseData(test1, expectedResult1);

            int test2 = -121;
            bool expectedResult2 = false;
            yield return new TestCaseData(test2, expectedResult2);

            int test3 = 10;
            bool expectedResult3 = false;
            yield return new TestCaseData(test3, expectedResult3);
        }
    }
}
