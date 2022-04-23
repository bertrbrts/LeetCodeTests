using LeetCodeLibrary;
using NUnit.Framework;
using System.Collections.Generic;

namespace UnitTests
{
    [TestFixture]
    public class AddTwoNumbersTest
    {
        [Test, TestCaseSource("cases")]        
        public void Execute(ListNode l1, ListNode l2, ListNode? expectedResult)
        {
            ListNode? result = AddTwoNumbers.Execute(l1, l2);

            bool isEqual = false;
            if (expectedResult != null && result != null)
            {
                var comparer = new ObjectsComparer.Comparer<ListNode>();
                isEqual = comparer.Compare(expectedResult, result);
            }

            Assert.IsTrue(isEqual);
        }

        private static IEnumerable<TestCaseData> cases()
        {
            ListNode l1 = new(2, new ListNode(4, new ListNode(3)));
            ListNode l2 = new(5, new ListNode(6, new ListNode(4)));
            ListNode? expectedResult1 = new(7, new ListNode(0, new ListNode(8)));
            yield return new TestCaseData(l1, l2, expectedResult1);

            ListNode l3 = new(0);
            ListNode l4 = new(0);
            ListNode expectedResult2 = new(0);
            yield return new TestCaseData(l3, l4, expectedResult2);

            ListNode l5 = new(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
            ListNode l6 = new(9, new ListNode(9, new ListNode(9, new ListNode(9))));
            ListNode expectedResult3 = new(8, new ListNode(9, new ListNode(9, 
                new ListNode(9, new ListNode(0, new ListNode(0, new ListNode(0, new ListNode(1))))))));
            yield return new TestCaseData(l5, l6, expectedResult3);
        }
    }
}