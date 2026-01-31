using LiveCoding.Lab.Core.Exercises.Strings;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveCoding.Lab.Tests.Strings;

public class AnagramCheckTests
{
    [Theory]
    [InlineData("listen", "silent", true)]
    [InlineData("evil", "vile", true)]
    [InlineData("restful", "fluster", true)]
    [InlineData("live", "coding", false)]
    [InlineData("Dormitory", "Dirty room", true)]
    public void Should_Check_Anagram(string a, string b, bool expected)
    {
        var result = AnagramCheck.Execute(a, b);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Should_Return_False_When_Null() 
    {
        Assert.False(AnagramCheck.Execute(null, "abc"));
    }
}
