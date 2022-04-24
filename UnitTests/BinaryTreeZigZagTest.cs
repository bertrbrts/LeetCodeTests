using LeetCodeLibrary;
using NUnit.Framework;
using System.Collections.Generic;

namespace UnitTests
{
    [TestFixture]
    internal class BinaryTreeZigZagTest
    {
        [Test, TestCaseSource("cases")]
        public void Execute(TreeNode root, IList<IList<int>> expectedResult)
        {
            var result = BinaryTreeZigZag.Execute(root);
            var comparer = new ObjectsComparer.Comparer<IList<IList<int>>>();
            var isEqual = comparer.Compare(result, expectedResult);
            Assert.IsTrue(isEqual);
        }

        private static IEnumerable<TestCaseData> cases()
        {
            TreeNode test1 = new(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
            var expectedResult1 = new List<IList<int>>()
            {
                new List<int>() { 3 },
                new List<int>() { 20, 9 },
                new List<int>() { 15, 7 },
            };
            yield return new TestCaseData(test1, expectedResult1);

            TreeNode test2 = new(1);
            var expectedResult2 = new List<IList<int>>()
            {
                new List<int>() { 1 }
            };
            yield return new TestCaseData(test2, expectedResult2);

            TreeNode test3 = new();
            var expectedResult3 = new List<IList<int>>() { new List<int> { 0 } };
            yield return new TestCaseData(test3, expectedResult3);
        }
    }
}
