using LeetCode._0001_0050;

namespace LeetCode.Test._0001_0050;

public class _008_String_to_Integer_atoi_Test
{
    private _008_String_to_Integer_atoi _solution;

    [SetUp]
    public void SetUp()
    {
            _solution = new();
    }

    [TestCase("42", 42)]
    [TestCase("  42", 42)]
    [TestCase("075", 75)]
    [TestCase("91283472332", int.MaxValue)]
    [TestCase("21474836460", 2147483647)]

    public void Sting_Positive(string value, int expected)
    {
       Assert.That(_solution.MyAtoi(value), Is.EqualTo(expected));
    }

    [TestCase("-42", -42)]
    [TestCase("  -42", -42)]
    [TestCase("-075", -75)]
    [TestCase("-91283472332", int.MinValue)]
    public void String_Minus(string value, int expected)
    {
       Assert.That(_solution.MyAtoi(value), Is.EqualTo(expected));
    }

    [TestCase("1997boom05", 1997)]
    [TestCase("1337c0d3", 1337)]
    public void String_Has_Prefix_Char(string value, int expected)
    {
        Assert.That(_solution.MyAtoi(value), Is.EqualTo(expected));
    }

    [TestCase("words and 987", 0)]
    [TestCase("0-1", 0)]
    [TestCase("25-1", 25)]
    public void String_Has_Not_Prefix_Char(string value, int expected)
    {
        Assert.That(_solution.MyAtoi(value), Is.EqualTo(expected));
    }

    [TestCase("", 0)]
    [TestCase("  ", 0)]
    public void String_Empty(string value, int expected)
    {
        Assert.That(_solution.MyAtoi(value), Is.EqualTo(expected));
    }
}