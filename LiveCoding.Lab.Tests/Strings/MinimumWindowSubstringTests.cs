using LiveCoding.Lab.Core.Exercises.Strings;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveCoding.Lab.Tests.Strings;

public class MinimumWindowSubstringTests
{
    [Theory]
    [InlineData("ADOBECODEBANC", "ABC", "BANC")]
    [InlineData("a", "a", "a")]
    [InlineData("a", "aa", "")]
    [InlineData("aa", "aa", "aa")]
    [InlineData("bba", "ab", "ba")]
    public void Should_Find_Minimum_Window(string s, string t, string expected)
    {
        var result = MinimumWindowSubstring.Execute(s, t);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("", "a")]
    [InlineData("a", "")]
    [InlineData("", "")]
    public void Should_Return_Empty_On_Invalid_Input(string s, string t)
    {
        var result = MinimumWindowSubstring.Execute(s, t);
        Assert.Equal(string.Empty, result);
    }
}
