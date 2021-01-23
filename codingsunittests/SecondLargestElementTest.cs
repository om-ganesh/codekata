using System;

using interviewcodings2018;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace codingsunittests
{
    [TestClass]
    public class SecondLargestElementTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] arr = { 2, 1, 3, 4, 5 };
            Assert.AreEqual(4, SecondLargestElement.FindSecondLargest(arr));

            arr = new int[] { 2, 1 };
            Assert.AreEqual(1, SecondLargestElement.FindSecondLargest(arr));

            arr = new int[] { 2, 2 };
            Assert.AreEqual(2, SecondLargestElement.FindSecondLargest(arr));

            arr = new int[] { 5, 2, 3 };
            Assert.AreEqual(3, SecondLargestElement.FindSecondLargest(arr));

            arr = new int[] { 5, 1, 1 };
            Assert.AreEqual(1, SecondLargestElement.FindSecondLargest(arr));

            arr = new int[] { -2, -1 };
            Assert.AreEqual(-2, SecondLargestElement.FindSecondLargest(arr));

            arr = new int[] { -2 };
            Assert.AreEqual(null, SecondLargestElement.FindSecondLargest(arr));

            arr = new int[] { };
            Assert.AreEqual(null, SecondLargestElement.FindSecondLargest(arr));
        }
    }
}
