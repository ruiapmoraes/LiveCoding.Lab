using System;
using System.Collections.Generic;
using System.Text;
using LiveCoding.Lab.Core.Exercises.Strings;
using Xunit;

namespace LiveCoding.Lab.Tests.Strings;

public class LongestSubstringWithoutRepeatingCharactersTests
{
    [Theory]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    [InlineData("", 0)]
    [InlineData("dvdf", 3)]
    public void Should_Find_Longest_Substring_Length(string input, int expected)
    {
        var result = LongestSubstringWithoutRepeatingCharacters.Execute(input);
        Assert.Equal(expected, result);
    }
}
