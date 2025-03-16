using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    public static class AssertHelper
    {

        public static ListNode? CreateList(int[] values)
        {
            if (values.Length == 0) return null;

            ListNode head = new ListNode(values[0]);
            ListNode current = head;

            for (int i = 1; i < values.Length; i++)
            {
                current.next = new ListNode(values[i]);
                current = current.next;
            }

            return head;
        }

        public static void AreListsEqual(ListNode? list1, ListNode? list2)
        {
            while (list1 != null && list2 != null)
            {
                Assert.That(list1.val, Is.EqualTo(list2.val));
                // if (list1.val != list2.val) 
                // {
                //     return false;
                // }
                list1 = list1.next;
                list2 = list2.next;
            }
            // return list1 == null && list2 == null;
        }
        public static void AssertNodeList(int[]? expected, ListNode? actual)
        {
            if (actual is null && expected is null)
            {
                Assert.True(true);
                return;
            }
            
            if (expected is null) {
                Assert.IsNotNull(expected);
                return;
            }

            if (actual is null){
                Assert.IsNotNull(actual);
                return;
            }
          

            ListNode? current = actual;
            for (int i = 0;i < expected.Length;i++)
            {
                Assert.IsNotNull(current);
                Assert.That(expected[i], Is.EqualTo(current?.val));
                current = current?.next;
            }
            Assert.IsNull(current);
        }
    }
}
