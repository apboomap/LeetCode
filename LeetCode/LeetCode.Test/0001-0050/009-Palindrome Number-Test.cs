﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    internal class _009_Palindrome_Number_Test
    {

        private _009_Palindrome_Number _solution = null!;
        [SetUp]
        public void SetUp()
        {
            _solution = new _009_Palindrome_Number();
        }

        [TestCase(121, true)]
        [TestCase(0, true)]
        [TestCase(10, false)]
        public void IsPalindrome_True(int value, bool expected)
        {
            var result = _solution.IsPalindrome(value);

            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(-121, false)]
        public void IsPalindrome_LessThanZero(int value, bool expected)
        {
            var result = _solution.IsPalindrome(value);

            Assert.That(result, Is.EqualTo(expected));
        }

    }
}
