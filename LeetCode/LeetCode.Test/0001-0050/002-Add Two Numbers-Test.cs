

using LeetCode._0001_0050;

namespace LeetCode.Test
{
    public class _002_Add_Two_Numbers_Test
    {
        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        public void AddTwoNumbers_ListEqual()
        {
            var l1 = Untils.GenrateListNode(new int[] { 2, 4, 3 });
            var l2 = Untils.GenrateListNode(new int[] { 5, 6, 4 });

            var solution = new _002_Add_Two_Numbers();
            var result = solution.AddTwoNumbers(l1, l2);

            AssertHelper.AssertNodeList(new int[] { 7, 0, 8 }, result);
        }

        [Test]
        public void AddTwoNumbers_ListOnlyZero()
        {
            var l1 = Untils.GenrateListNode(new int[] { 0 });
            var l2 = Untils.GenrateListNode(new int[] { 0 });

            var solution = new _002_Add_Two_Numbers();
            var result = solution.AddTwoNumbers(l1, l2);

            AssertHelper.AssertNodeList(new int[] { 0 }, result);
        }

        [Test]
        public void AddTwoNumbers_ListNotEqual()
        {
            var l1 = Untils.GenrateListNode(new int[] { 9, 9, 9, 9, 9, 9, 9 });
            var l2 = Untils.GenrateListNode(new int[] { 9, 9, 9, 9 });

            var solution = new _002_Add_Two_Numbers();
            var result = solution.AddTwoNumbers(l1, l2);

            AssertHelper.AssertNodeList(new int[] { 8, 9, 9, 9, 0, 0, 0, 1 }, result);
        }

        [Test]
        public void AddTwoNumbers_ListEmpty()
        {
            var l1 = Untils.GenrateListNode(new int[] { });
            var l2 = Untils.GenrateListNode(new int[] { });

            var solution = new _002_Add_Two_Numbers();
            var result = solution.AddTwoNumbers(l1, l2);

            AssertHelper.AssertNodeList(null, result);
        }

        [Test]
        public void AddTwoNumbers_ListNull()
        {
            var l1 = Untils.GenrateListNode(null);
            var l2 = Untils.GenrateListNode(null);

            var solution = new _002_Add_Two_Numbers();
            var result = solution.AddTwoNumbers(l1, l2);

            AssertHelper.AssertNodeList(null, result);
        }


        [Test]
        public void AddTwoNumbers_ListSoneNull()
        {
            var l1 = Untils.GenrateListNode(new int[] { 1, 2 });
            var l2 = Untils.GenrateListNode(null);

            var solution = new _002_Add_Two_Numbers();
            var result = solution.AddTwoNumbers(l1, l2);

            AssertHelper.AssertNodeList(new int[] { 1, 2 }, result);
        }





    }
}
