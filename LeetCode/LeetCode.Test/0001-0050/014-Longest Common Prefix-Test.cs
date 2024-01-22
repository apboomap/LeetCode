
namespace LeetCode.Test
{
    public class _014_Longest_Common_Prefix_Test
    {

        [Test]
        public void RomapToInteger_EmptyArray()
        {
            string[] s = [];
            var solution = new _014_Longest_Common_Prefix();
            var result = solution.LongestCommonPrefix(s);


            Assert.That(result, Is.EqualTo(""));

        }

        [Test]
        public void RomapToInteger_LengthStringNotEqual()
        {
            string[] s = ["ab", "a"];
            var solution = new _014_Longest_Common_Prefix();
            var result = solution.LongestCommonPrefix(s);


            Assert.That(result, Is.EqualTo("a"));

        }


        [Test]
        public void RomapToInteger_ZeroDigit()
        {
            string[] s = ["dog", "racecar", "car"];
            var solution = new _014_Longest_Common_Prefix();
            var result = solution.LongestCommonPrefix(s);


            Assert.That(result, Is.EqualTo(""));

        }

        [Test]
        public void LongestCommonPrefix_TwoDigit()
        {
            string[] s = ["flower", "flow", "flight"];
            var solution = new _014_Longest_Common_Prefix();
            var result = solution.LongestCommonPrefix(s);


            Assert.That(result, Is.EqualTo("fl"));

        }

    }
}
