using NUnit.Framework;
using LeetCodeLibrary;
using System.Collections.Generic;

namespace UnitTests
{
    [TestFixture]
    public class FizzBuzzTest
    {
        [Test, TestCaseSource("cases")]
        public void Execute(int n, List<string> expectedResult)
        {
            var result = FizzBuzz.Execute(n);
            var comparer = new ObjectsComparer.Comparer<List<string>>();
            var isEqual = comparer.Compare(expectedResult, result);
            Assert.IsTrue(isEqual);
        }

        private static IEnumerable<TestCaseData> cases()
        {
            int test1 = 15;
            List<string> expectedResult1 = new()
            {
                "1",
                "2",
                "Fizz",
                "4",
                "Buzz",
                "Fizz",
                "7",
                "8",
                "Fizz",
                "Buzz",
                "11",
                "Fizz",
                "13",
                "14",
                "FizzBuzz"
            };
            yield return new TestCaseData(test1, expectedResult1);

        }

    }
}
