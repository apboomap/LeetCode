using LeetCode._0001_0050;

namespace LeetCode.Test._0001_0050
{
    public class _0013_Roman_to_Integer_Test
    {
         private _0013_Roman_to_Integer _solution = null!;
        [SetUp]
        public void SetUp()
        {
            _solution = new _0013_Roman_to_Integer();
        }

        [TestCase("III", 3)]
        [TestCase("LVIII", 58)]
        [TestCase("DLXVII", 567)]
        [TestCase("MCMXCIV", 1994)]
        public void RomapToInteger_OneDigit(string s, int expected)
        {
            var result = _solution.RomanToInt(s);
            Assert.That(result, Is.EqualTo(expected));

        }


        [TestCase("Z")]
        public void RomapToInteger_FailString(string s)
        {
            var solution = new _0013_Roman_to_Integer();

            Assert.Catch<ArgumentException>(() => _solution.RomanToInt(s), "String input contains only the characters ('I', 'V', 'X', 'L', 'C', 'D', 'M').");
        }

        [Test]
        public void RomapToInteger_StringEmpty()
        {
            var s = "";
            var solution = new _0013_Roman_to_Integer();

            Assert.Throws<ArgumentException>(() => _solution.RomanToInt(s), "String input length 1 to 15.");
        }

        [Test]
        public void RomapToInteger_StringOverMaxLength15()
        {
            var s = "IIIIIIIIIIIIIIII";
            var solution = new _0013_Roman_to_Integer();

            Assert.Throws<ArgumentException>(() => _solution.RomanToInt(s), "String input length 1 to 15.");
        }

    }
}
