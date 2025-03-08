

using LeetCode._0001_0050;
using NUnit.Framework.Internal;

namespace LeetCode.Test._0001_0050
{
    [TestFixture]
    public class _001_Two_Sum_Test
    {
        private int[] largeArray = new int[20000];
        private _001_Two_Sum _solution = null!;
        
         // สร้างข้อมูลเพียงครั้งเดียวก่อนรันชุดการทดสอบทั้งหมด
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            for (int i = 0; i < 20000; i++)
            {
                largeArray[i] = i * 2;
            }
        }

        [SetUp]
        public void SetUp()
        {
            _solution = new _001_Two_Sum();
        }

        [TestCase(new int[] { 2, 7, 11, 15 }, 9)]
        public void TwoSumTest_Ordered(int[] nums, int target)
        {
            var result = _solution.TwoSum(nums, target);

            Assert.That(result.Length, Is.EqualTo(2));

            Assert.That(result, Is.EquivalentTo(new[] {0, 1}));
            
        }

        [TestCase(new int[] { 5, 75, 35, 25 }, 100)]
        public void TwoSumTest_Unordered(int[] nums, int target)
        {
            var result = _solution.TwoSum(nums, target);

            Assert.That(result.Length, Is.EqualTo(2));

            Assert.That(result, Is.EquivalentTo(new[] {1, 3}));
        }

        [TestCase(new int[] { 2, 2, 2, 2 }, 4)]
        [TestCase(new int[] { 1, 1, 1, 1 }, 2)]
        public void TwoSumTest_AllSame(int[] nums, int target)
        {
            var result = _solution.TwoSum(nums, target);

            Assert.That(result.Length, Is.EqualTo(2));
            Assert.That(result[0], Is.EqualTo(0));
            Assert.That(result[1], Is.EqualTo(1));
        }

        [TestCase(new int[] { 1, 7, 11, 15 }, 6)]
        public void TwoSumTest_NoTarget(int[] nums, int target)
        {
            var result = _solution.TwoSum(nums, target);

            Assert.That(result.Length, Is.EqualTo(0));
        }

        [Test]
        public void TwoSumTest_LargeArray()
        {
            var target = 9726;
            var result = _solution.TwoSum(largeArray, target);

            Assert.That(result.Length, Is.EqualTo(2));
            Assert.That(result[0], Is.EqualTo(2431));
            Assert.That(result[1], Is.EqualTo(2432));
        }

        [Test]
        public void TwoSumTest_LargeArray2()
        {
            var target = 38744;
            var result = _solution.TwoSum(largeArray, target);

            Assert.That(result.Length, Is.EqualTo(2));
            Assert.That(result[0], Is.EqualTo(9685));
            Assert.That(result[1], Is.EqualTo(9687));
        }



    }
}
