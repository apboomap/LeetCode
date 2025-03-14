using LeetCode._0001_0050;

namespace LeetCode.Test._0001_0050;

public class _0018_Four_Sum_Test
{
    private _0018_Four_Sum _solution;
    [SetUp]
    public void SetUp()
    {
        _solution = new();
    }

    public static IEnumerable<TestCaseData> FourSumTestCases()
    {
        yield return new TestCaseData(new int[] { 0, 0, 0, 0 }, 0, new List<List<int>> { new List<int> { 0, 0, 0 , 0} });
        yield return new TestCaseData(new int[] { 1, 0, -1, 0, -2, 2 }, 0, new List<List<int>> { new List<int> { -2, -1, 1, 2 }, new List<int> { -2, 0, 0, 2 }, new List<int> { -1, 0, 0, 1 } });
        yield return new TestCaseData(new int[] { 2, 2, 2, 2, 2 }, 8, new List<List<int>> { new List<int> { 2, 2, 2, 2} });
        yield return new TestCaseData(new int[] { 1, 2, -2, -1 }, 0, new List<List<int>> { new List<int> { 1, 2, -2, -1 } });
        yield return new TestCaseData(new int[] { 3, -2, -1, 1, 2 }, 0, new List<List<int>> { new List<int> { -2, -1, 1, 2 } });
    }

    [TestCaseSource(nameof(FourSumTestCases))]
    public void FourSum_AdditionalCases(int[] values, int target, List<List<int>> expected)
    {
        // Act
        var result = _solution.FourSum(values, target);

        // Assert
        Assert.That(result, Has.Count.EqualTo(expected.Count));

        for (int i = 0; i < expected.Count; i++)
        {
            CollectionAssert.AreEquivalent(expected[i], result[i]);
        }
    }

    [TestCase]
    public void FourSum_Input_Empty()
    {
        Assert.That(_solution.FourSum([], 8), Is.EquivalentTo(new List<List<int>>()));
    }

    [TestCase]
    public void FourSum_Input_Not_FourIndex()
    {
        Assert.That(_solution.FourSum(new int[] { 0, 0}, 0), Is.EquivalentTo(new List<List<int>>()));
    }

    [TestCase]
    public void FourSum_Input_Over_Int()
    {
        Assert.That(_solution.FourSum(new int[] { 1000000000,1000000000,1000000000,1000000000}, -294967296), Is.EquivalentTo(new List<List<int>>()));
    }
    
}