using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._0001_0050
{
    public class _002_Add_Two_Numbers
    {
        public ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2, int carry =  0)
        {
           if (l1 is null && l2 is null && carry == 0) return null;

           int sum = (l1 is null ? 0 : l1.val) + (l2 is null ? 0 : l2.val) + carry;
           ListNode node = new(sum%10);

           node.next = AddTwoNumbers(l1?.next, l2?.next, sum/10);
           return node;
        }
    }
}
