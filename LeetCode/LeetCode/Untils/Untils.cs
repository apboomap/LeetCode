using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Untils
    {
        public static ListNode? GenrateListNode(int[]? nums)
        {
            if (nums == null || nums.Length == 0) return null;
            var fist = new ListNode(nums[0]);
            var current = fist;
            var i = 1;
            while (i < nums.Length)
            {
                current.next = new ListNode(nums[i]);
                current=  current.next;
                i++;
            }

            return fist;
        }
    }
}
