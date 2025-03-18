using LeetCode._0001_0050;

namespace LeetCode.Test._0001_0050;

public class _0035_Search_Insert_Position_Test
{
    private _0035_Search_Insert_Position _solution;

    [SetUp]
    public void SetUp() 
    {
        _solution = new _0035_Search_Insert_Position();
    }

    [TestCase(new int[] { 1,3,5,6 }, 5, 2)]
    [TestCase(new int[] { 1,3,5,6 }, 2, 1)]
    [TestCase(new int[] { 1,3,5,6 }, 7, 4)]
    [TestCase(new int[] { }, 7, 0)]
    public void Search(int[] nums, int target, int expected)
    {
        Assert.That(_solution.SearchInsert(nums, target), Is.EqualTo(expected));
    }


}