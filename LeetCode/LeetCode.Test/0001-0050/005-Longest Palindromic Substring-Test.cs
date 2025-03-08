

using LeetCode._0001_0050;

namespace LeetCode.Test._0001_0050
{
    public class _005_Longest_Palindromic_Substring_Test
    {
        private _005_Longest_Palindromic_Substring _solution = null!;
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
        }

        [SetUp]
        public void SetUp()
        {
            _solution = new _005_Longest_Palindromic_Substring();
        }

        [TestCase("a" , "a")]
        [TestCase("ac" , "a")]
        [TestCase("babadb" , "bab")]
        [TestCase("cbbd", "bb")]
        [TestCase("abaxyzzyxf", "xyzzyx")]
        [TestCase("bananas", "anana")]
        [TestCase("abacdffdcaba", "abacdffdcaba")]
        [TestCase("forgeeksskeegfor", "geeksskeeg")]
        [TestCase("aacabdkacaa", "aca")]
        public void Palindrome_Longest(string value, string expected)
        {
            var result = _solution.LongestPalindrome(value);

            Assert.That(result, Is.EqualTo(expected));
        }

    }
}
