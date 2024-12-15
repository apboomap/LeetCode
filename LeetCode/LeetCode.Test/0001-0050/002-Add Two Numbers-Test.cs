

using LeetCode._0001_0050;

namespace LeetCode.Test
{
    public class _002_Add_Two_Numbers_Test
    {
        private _002_Add_Two_Numbers _solution = null!;
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
        }

        [SetUp]
        public void SetUp()
        {
            _solution = new _002_Add_Two_Numbers();
        }

        [TestCase(new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 }, new int[] { 7, 0, 8 })] 
        [TestCase(new int[] { 0 }, new int[] { 0 }, new int[] { 0 })] 
        [TestCase(new int[] { 9, 9, 9, 9, 9, 9, 9 }, new int[] { 9, 9, 9, 9 }, new int[] { 8, 9, 9, 9, 0, 0, 0, 1 })]
        public void AddTwoNumbers_ListEqual(int[] l1Array, int[] l2Array, int[] expectedArray)
        {
            var l1 = Untils.GenrateListNode(l1Array);
            var l2 = Untils.GenrateListNode(l2Array); 

            var result = _solution.AddTwoNumbers(l1, l2);

            AssertHelper.AssertNodeList(expectedArray, result);
        }

        [Test]
        public void AddTwoNumbers_ListOnlyZero()
        {
            var l1 = Untils.GenrateListNode(new int[] { 0 });
            var l2 = Untils.GenrateListNode(new int[] { 0 });

            var result = _solution.AddTwoNumbers(l1, l2);

            AssertHelper.AssertNodeList(new int[] { 0 }, result);
        }

        [Test]
        public void AddTwoNumbers_ListEmpty()
        {
            var l1 = Untils.GenrateListNode(new int[] { });
            var l2 = Untils.GenrateListNode(new int[] { });

            var result = _solution.AddTwoNumbers(l1, l2);

            AssertHelper.AssertNodeList(null, result);
        }

        [Test]
        public void AddTwoNumbers_ListNull()
        {
            var l1 = Untils.GenrateListNode(null);
            var l2 = Untils.GenrateListNode(null);

            var result = _solution.AddTwoNumbers(l1, l2);

            AssertHelper.AssertNodeList(null, result);
        }


        [Test]
        public void AddTwoNumbers_ListSomeNull()
        {
            var l1 = Untils.GenrateListNode(new int[] { 1, 2 });
            var l2 = Untils.GenrateListNode(null);

            var result = _solution.AddTwoNumbers(l1, l2);

            AssertHelper.AssertNodeList(new int[] { 1, 2 }, result);
        }





    }
}
