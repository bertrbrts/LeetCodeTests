using NUnit.Framework;
using LeetCodeLibrary;
using System.Collections.Generic;

namespace UnitTests
{
    [TestFixture]
    public class TwoSumTest
    {
        [Test, TestCaseSource("cases")]
        public void Execute(int[] nums, int target, int[] expectedResult)
        {
            var result = TwoSum.Execute(nums, target);
            Assert.AreEqual(expectedResult, result);
        }

        private static IEnumerable<TestCaseData> cases()
        {
            int[] nums1 = { 2, 7, 11, 15 };
            int target1 = 9;
            int[] expectedResult1 = { 0, 1 };
            yield return new TestCaseData(nums1, target1, expectedResult1);

            int[] nums2 = { 3,2,4 };
            int target2 = 6;
            int[] expectedResult2 = { 1, 2 };
            yield return new TestCaseData(nums2, target2, expectedResult2);

            int[] nums3 = { 3,3 };
            int target3 = 6;
            int[] expectedResult3 = { 0, 1 };
            yield return new TestCaseData(nums3, target3, expectedResult3);

        }
    }
}