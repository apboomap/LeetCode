

using LeetCode._0001_0050;

namespace LeetCode.Test._0001_0050
{
    public class _007_Reverse_Integer_Test
    {
        private _007_Reverse_Integer _solution = null!;
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
        }

        [SetUp]
        public void SetUp()
        {
            _solution = new _007_Reverse_Integer();
        }

        [TestCase(123, 321)]
        [TestCase(120, 21)]
        [TestCase(1534236469, 0)]
        public void Reverse_Integer_More_Than_Zero(int value, int expected)
        {
            var result = _solution.Reverse(value);

            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(0, 0)]
        public void Reverse_Integer_Than_Zero(int value, int expected)
        {
            var result = _solution.Reverse(value);

            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(-123, -321)]
        [TestCase(-120, -21)]
        [TestCase(-1534236469, 0)]
        public void Reverse_Integer_Less_Than_Zero(int value, int expected)
        {
            var result = _solution.Reverse(value);

            Assert.That(result, Is.EqualTo(expected));
        }

    }
}
