using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._0001_0050
{
    internal class _009_Palindrome_Number_Test
    {

        [Test]
        public void IsPalindrome_True()
        {
            var x = 121;

            var solution = new _009_Palindrome_Number();
            var result = solution.IsPalindrome(x);

            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void IsPalindrome_LessThanZero()
        {
            var x = -121;

            var solution = new _009_Palindrome_Number();
            var result = solution.IsPalindrome(x);

            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void IsPalindrome_False()
        {
            var x = 10;

            var solution = new _009_Palindrome_Number();
            var result = solution.IsPalindrome(x);

            Assert.That(result, Is.EqualTo(false));
        }
    }
}
