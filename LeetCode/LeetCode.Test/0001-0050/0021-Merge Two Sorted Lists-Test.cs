using LeetCode._0001_0050;

namespace LeetCode.Test._0001_0050;

public class _0021_Merge_Two_Sorted_Lists_Test
{
    private _0021_Merge_Two_Sorted_Lists _solution;

    [SetUp]
    public void SetUp() 
    {
        _solution = new _0021_Merge_Two_Sorted_Lists();
    }

    [TestCase(new int[] { 1, 2, 4 }, new int[] { 1, 3, 4 }, new int[] { 1, 1, 2, 3, 4, 4 })]
    [TestCase(new int[] { }, new int[] { 0 }, new int[] { 0 })]
    public void List_Merge_Two_List_Test(int[] list1Array, int[] list2Array, int[] expectedArray)
    {
        // Arrange
        var list1 = AssertHelper.CreateList(list1Array);
        var list2 = AssertHelper.CreateList(list2Array);
        var expected = AssertHelper.CreateList(expectedArray);

        // Act
        var result = _solution.MergeTwoLists(list1, list2);

        // Assert
        AssertHelper.AreListsEqual(result, expected);
    }

    [TestCase(new int[] { 0 }, new int[] { }, new int[] { 0 })]
    [TestCase(new int[] { }, new int[] { 0 }, new int[] { 0 })]

    public void List_Merge_One_Empty_List_Test(int[] list1Array, int[] list2Array, int[] expectedArray)
    {
        var list1 = AssertHelper.CreateList(list1Array);
        var list2 = AssertHelper.CreateList(list2Array);
        var expected = AssertHelper.CreateList(expectedArray);

        // Act
        var result = _solution.MergeTwoLists(list1, list2);

        // Assert
        AssertHelper.AreListsEqual(result, expected);
    }

    [TestCase(new int[] { }, new int[] { }, new int[] { })]

    public void List_Merge_Empty_List_Test(int[] list1Array, int[] list2Array, int[] expectedArray)
    {
         var list1 = AssertHelper.CreateList(list1Array);
        var list2 = AssertHelper.CreateList(list2Array);
        var expected = AssertHelper.CreateList(expectedArray);

        // Act
        var result = _solution.MergeTwoLists(list1, list2);

        // Assert
        AssertHelper.AreListsEqual(result, expected);
    }
    

}