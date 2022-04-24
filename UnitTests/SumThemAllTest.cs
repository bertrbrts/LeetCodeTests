using LeetCodeLibrary;
using NUnit.Framework;
using System.Collections.Generic;

namespace UnitTests
{
    [TestFixture]
    public class SumThemAllTest
    {
        [Test, TestCaseSource("cases")]
        public void Execute(List<int> numbers, int expectedResult)
        {
            var result = SumThemAll.Execute(numbers);
            Assert.AreEqual(expectedResult, result);
        }

        private static IEnumerable<TestCaseData> cases()
        {
            List<int> test1 = new() { 1,2,3,4,5 };
            int expectedResult1 = 15;
            yield return new TestCaseData(test1, expectedResult1);

            List<int> test2 = new() { 12, 12 };
            int expectedResult2 = 24;
            yield return new TestCaseData(test2, expectedResult2);

        }
    }
}
