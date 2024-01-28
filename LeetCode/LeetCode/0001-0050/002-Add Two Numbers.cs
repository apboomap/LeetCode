using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._0001_0050
{
    public class _002_Add_Two_Numbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return AddTwoNumbers(l1, l2, 0);
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2, int plus)
        {
            if (l1 is null && l2 is null) return plus > 0 ? new ListNode(plus) : null;

            int v1 = 0, v2 = 0, remainder = 0, divided = 0;

            if (l1 is not null)
            {
                v1 = l1.val;
                l1 = l1.next;
            }

            if (l2 is not null)
            {
                v2 = l2.val;
                l2 = l2.next;
            }

            remainder = (v1 + v2 + plus) % 10;
            divided = (v1 + v2 + plus) / 10;
            return new ListNode(remainder, AddTwoNumbers(l1, l2, divided));
        }
    }
}
