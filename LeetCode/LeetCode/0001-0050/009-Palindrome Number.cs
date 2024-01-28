using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _009_Palindrome_Number
    {
        public bool IsPalindrome(int x)
        {
            int y  = 0,  copy = x;
            if (x < 0 ) return false;

            while (copy > 0)
            {
                y = (copy % 10) + (y * 10);
                copy /= 10;
            }
            return x == y;
        }
    }
}
