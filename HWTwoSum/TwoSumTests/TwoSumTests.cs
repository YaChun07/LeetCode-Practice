using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TwoSum.Tests
{
    [TestClass()]
    public class TwoSumTests
    {
        [TestMethod()]
        public void four_positive_number()
        {
            CollectionAssert.AreEqual(new int[] { 0, 1 }, TwoSum.twoSum(new int[] { 2, 7, 11, 15 }, 9));
        }
        [TestMethod()]
        public void two_positive_number_two_negative_number()
        {
            CollectionAssert.AreEqual(new int[] { 1, 3 }, TwoSum.twoSum(new int[] { 2, 7, -11, -15 }, -8));
        }
        [TestMethod()]
        public void two_positive_number_one_negative_number_one_zero_()
        {
            CollectionAssert.AreEqual(new int[] { 2, 3 }, TwoSum.twoSum(new int[] { 2, 7, -11, 0 }, -11));
        }
        [TestMethod()]
        public void no_answer()
        {
            CollectionAssert.AreEqual(null, TwoSum.twoSum(new int[] { 2, 7, -11, 0 }, 20));
        }
    }
}