using NUnit.Framework;
using interviewcodings2020.Facebook;

namespace codingsunittests
{
    [TestFixture]
    class FirstAndLastElementInArrayTest
    {
        [Test]
        public void EmptyList()
        {
            int[] nums = new int[] {};
            int target = 11;
            var result = new FirstAndLastElementInArray().SearchRange(nums, target);
            Assert.AreEqual(-1, result[0]);
            Assert.AreEqual(-1, result[1]);
        }

        [Test]
        public void ListWithSingleElement()
        {
            int[] nums = new int[] { 5};
            int target = 4;
            var result = new FirstAndLastElementInArray().SearchRange(nums, target);
            Assert.AreEqual(-1, result[0]);
            Assert.AreEqual(-1, result[1]);

            target = 5;
            result = new FirstAndLastElementInArray().SearchRange(nums, target);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(0, result[1]);

            target = 13;
            result = new FirstAndLastElementInArray().SearchRange(nums, target);
            Assert.AreEqual(-1, result[0]);
            Assert.AreEqual(-1, result[1]);


        }

        [Test]
        public void ListWithTwoElements()
        {
            int[] nums = new int[] { 5, 5 };
            int target = 4;
            var result = new FirstAndLastElementInArray().SearchRange(nums, target);
            Assert.AreEqual(-1, result[0]);
            Assert.AreEqual(-1, result[1]);

            target = 5;
            result = new FirstAndLastElementInArray().SearchRange(nums, target);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);

            target = 6;
            result = new FirstAndLastElementInArray().SearchRange(nums, target);
            Assert.AreEqual(-1, result[0]);
            Assert.AreEqual(-1, result[1]);
        }

        [Test]
        public void AvailableSingleValue()
        {
            int[] nums = new int[] { 5, 7, 7, 8, 8, 10, 12 };
            int target = 10;
            var result = new FirstAndLastElementInArray().SearchRange(nums, target);
            Assert.AreEqual(5, result[0]);
            Assert.AreEqual(5, result[1]);
        }

        [Test]
        public void AvailableDoubleValue()
        {
            int[] nums = new int[] { 5, 7, 7, 8, 8, 10, 12 };
            int target = 7;
            var result = new FirstAndLastElementInArray().SearchRange(nums, target);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
        }

        [Test]
        public void NotAvailableValues()
        {
            int[] nums = new int[] { 5, 7, 7, 8, 8, 10, 12 };
            
            int target = 2;
            var result = new FirstAndLastElementInArray().SearchRange(nums, target);
            Assert.AreEqual(-1, result[0]);
            Assert.AreEqual(-1, result[1]);

            target = 6;
            result = new FirstAndLastElementInArray().SearchRange(nums, target);
            Assert.AreEqual(-1, result[0]);
            Assert.AreEqual(-1, result[1]);

            target = 13;
            result = new FirstAndLastElementInArray().SearchRange(nums, target);
            Assert.AreEqual(-1, result[0]);
            Assert.AreEqual(-1, result[1]);
        }
    }
}
