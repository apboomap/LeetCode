using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    public class AssertHelper
    {

        public static void AssertNodeList(int[] expected, ListNode actual)
        {
            if (actual is null && expected is null)
            {
                Assert.True(true);
                return;
            }

            Assert.IsNotNull(actual);
            Assert.IsNotNull(expected);
            Assert.IsTrue(expected.Any());

            ListNode current = actual;
            for (int i = 0;i < expected.Length;i++)
            {
                Assert.IsNotNull(current);
                Assert.That(expected[i], Is.EqualTo(current.val));
                current = current.next;
            }
            Assert.IsNull(current);
        }
    }
}
