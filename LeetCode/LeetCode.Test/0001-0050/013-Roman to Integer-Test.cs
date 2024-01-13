namespace LeetCode.Test
{
    public class _013_Roman_to_Integer_Test
    {
        [Test]
        public void RomapToInteger_OneDigit()
        {
            var s = "III";
            var solution = new _013_Roman_to_Integer();
            var result = solution.RomanToInt(s);


            Assert.That(result, Is.EqualTo(3));

        }

        [Test]
        public void RomapToInteger_TwoDigit()
        {
            var s = "LVIII";
            var solution = new _013_Roman_to_Integer();
            var result = solution.RomanToInt(s);


            Assert.That(result, Is.EqualTo(58));

        }
        

        [Test]
        public void RomapToInteger_ThreeDigit()
        {
            var s = "DLXVII";
            var solution = new _013_Roman_to_Integer();
            var result = solution.RomanToInt(s);

            Assert.That(result, Is.EqualTo(567));

        }

        [Test]
        public void RomapToInteger_FourDigit()
        {
            var s = "MCMXCIV";
            var solution = new _013_Roman_to_Integer();
            var result = solution.RomanToInt(s);


            Assert.That(result, Is.EqualTo(1994));

        }

        [Test]
        public void RomapToInteger_FailString()
        {
            var s = "Z";
            var solution = new _013_Roman_to_Integer();

            Assert.Catch<ArgumentException>(() => solution.RomanToInt(s),"String input contains only the characters ('I', 'V', 'X', 'L', 'C', 'D', 'M').");
        }

        [Test]
        public void RomapToInteger_StringEmpty()
        {
            var s = "";
            var solution = new _013_Roman_to_Integer();

            Assert.Throws<ArgumentException>(() => solution.RomanToInt(s), "String input length 1 to 15.");
        }

        [Test]
        public void RomapToInteger_StringOverMaxLength15()
        {
            var s = "IIIIIIIIIIIIIIII";
            var solution = new _013_Roman_to_Integer();

            Assert.Throws<ArgumentException>(() => solution.RomanToInt(s), "String input length 1 to 15.");
        }

    }
}
