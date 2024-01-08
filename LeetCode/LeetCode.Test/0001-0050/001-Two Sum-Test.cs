

namespace LeetCode.Test
{
    public class _001_Two_Sum_Test
    {
        private int[] largeArray;
        [SetUp]
        public void SetUp()
        {
            largeArray = new int[20000];
            for (int i = 0; i < 20000; i++)
            {
                largeArray[i] = i * 2;
            }
        }

        [Test]
        public void TwoSumTest_Ordered()
        {
            var nums = new int[] { 2, 7, 11, 15 };
            var target = 9;

            var solution = new _001_Two_Sum();
            var result = solution.TwoSum(nums, target);

            Assert.That(result.Length, Is.EqualTo(2));
            Assert.That(result[0], Is.EqualTo(0));
            Assert.That(result[1], Is.EqualTo(1));
        }

        [Test]
        public void TwoSumTest_Unordered()
        {
            var nums = new int[] { 5, 75, 35, 25 };
            var target = 100;

            var solution = new _001_Two_Sum();
            var result = solution.TwoSum(nums, target);

            Assert.That(result.Length, Is.EqualTo(2));
            Assert.That(result[0], Is.EqualTo(1));
            Assert.That(result[1], Is.EqualTo(3));
        }

        [Test]
        public void TwoSumTest_AllSame()
        {
            var nums = new int[] { 1, 1, 1, 1 };
            var target = 2;

            var solution = new _001_Two_Sum();
            var result = solution.TwoSum(nums, target);

            Assert.That(result.Length, Is.EqualTo(2));
            Assert.That(result[0], Is.EqualTo(0));
            Assert.That(result[1], Is.EqualTo(1));
        }

        [Test]
        public void TwoSumTest_NoTarget()
        {
            var nums = new int[] { 1, 7, 11, 15 };
            var target = 6;

            var solution = new _001_Two_Sum();
            var result = solution.TwoSum(nums, target);

            Assert.That(result.Length, Is.EqualTo(0));
        }

        [Test]
        public void TwoSumTest_LargeArray()
        {
            var target = 9726;
            var solution = new _001_Two_Sum();
            var result = solution.TwoSum(largeArray, target);

            Assert.That(result.Length, Is.EqualTo(2));
            Assert.That(result[0], Is.EqualTo(2431));
            Assert.That(result[1], Is.EqualTo(2432));
        }

        [Test]
        public void TwoSumTest_LargeArray2()
        {
            var target = 38744;
            var solution = new _001_Two_Sum();
            var result = solution.TwoSum(largeArray, target);

            Assert.That(result.Length, Is.EqualTo(2));
            Assert.That(result[0], Is.EqualTo(9685));
            Assert.That(result[1], Is.EqualTo(9687));
        }



    }
}
