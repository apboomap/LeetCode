using LeetCode._0001_0050;

namespace LeetCode.Test._0001_0050;

public class _0016_Three_Sum_Closeset_Test
{
    private _0016_Three_Sum_Closeset _solution;
    [SetUp]
    public void SetUp()
    {
        _solution = new();
    }

    public static IEnumerable<TestCaseData> ThreeSumClosetTestCases()
    {
        yield return new TestCaseData(new int[] { -1, 2, 1, -4 }, 1, 2);
        yield return new TestCaseData(new int[] { 0, 0, 0 }, 0, 0);
        yield return new TestCaseData(new int[] { 0, 1, 2 }, 0, 3);
        yield return new TestCaseData(new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90}, 1, 60);
    }

    [TestCaseSource(nameof(ThreeSumClosetTestCases))]
    public void Three_Sum_AdditionalCases(int[] values, int target, int expected)
    {
        Assert.That(_solution.ThreeSumClosest(values, target), Is.EqualTo(expected));
    }

    // [TestCase]
    // public void Three_Sum_Input_Empty()
    // {
    //     Assert.That(_solution.ThreeSum([]), Is.EquivalentTo(new List<List<int>>()));
    // }

    // [TestCase]
    // public void Three_Sum_Input_Not_Three_Index()
    // {
    //     Assert.That(_solution.ThreeSum(new int[] { 0, 0}), Is.EquivalentTo(new List<List<int>>()));
    // }
    
}