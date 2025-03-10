using LeetCode._0001_0050;

namespace LeetCode.Test._0001_0050;

public class _003_Three_Sum_Test
{
    private _003_Three_Sum _solution;
    [SetUp]
    public void SetUp()
    {
        _solution = new();
    }

    public static IEnumerable<TestCaseData> ThreeSumTestCases()
    {
        yield return new TestCaseData(new int[] { 0, 0, 0 }, new List<List<int>> { new List<int> { 0, 0, 0 } });
        yield return new TestCaseData(new int[] { -1, 0, 1, 2,-1,-4 }, new List<List<int>> { new List<int> { -1,-1, 2 }, new List<int> { -1, 0, 1 } });
        yield return new TestCaseData(new int[] { 0, 1, 1 }, new List<List<int>>());
        yield return new TestCaseData(new int[] { 1, 2, -2, -1 }, new List<List<int>>());
        yield return new TestCaseData(new int[] { 3, 0, -2, -1, 1, 2 }, 
            new List<List<int>> { new List<int> { -2, -1, 3 }, new List<int> { -2, 0, 2 }, new List<int> { -1, 0, 1 } });
    }

    [TestCaseSource(nameof(ThreeSumTestCases))]
    public void Three_Sum_AdditionalCases(int[] values, List<List<int>> expected)
    {
        var result = _solution.ThreeSum(values);
        Assert.That(result, Is.EquivalentTo(expected));
        // CollectionAssert.AreEquivalent(expected, result);         
    }

    [TestCase]
    public void Three_Sum_Input_Empty()
    {
        Assert.That(_solution.ThreeSum([]), Is.EquivalentTo(new List<List<int>>()));
    }

    [TestCase]
    public void Three_Sum_Input_Not_Three_Index()
    {
        Assert.That(_solution.ThreeSum(new int[] { 0, 0}), Is.EquivalentTo(new List<List<int>>()));
    }
    
}