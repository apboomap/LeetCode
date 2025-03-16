using LeetCode._0001_0050;

namespace LeetCode.Test._0001_0050;

public class _0012_Integer_to_Roman_Test
{
    private _0012_Integer_to_Roman _solution;

    [SetUp]
    public void SetUp()
    {
        _solution = new _0012_Integer_to_Roman();
    }

    [TestCase(3, "III")]
    [TestCase(4, "IV")]
    [TestCase(9, "IX")]
    [TestCase(58, "LVIII")]
    [TestCase(567, "DLXVII")]
    [TestCase(1994, "MCMXCIV")]
    [TestCase(3749, "MMMDCCXLIX")]
    public void IntegerToRoman_OneDigit(int value, string expected)
    {
        var result = _solution.IntToRoman(value);
        Assert.That(result, Is.EqualTo(expected));

    }

    [TestCase(-4000)]
    [TestCase(0)]
    [TestCase(4000)]
    public void RomanToInteger_FailString(int value)
    {
        var solution = new _0013_Roman_to_Integer();

        Assert.Catch<ArgumentException>(() => _solution.IntToRoman(value), "1 <= Input(num) <= 3999");
    }
}