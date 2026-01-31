using LiveCoding.Lab.Core.Exercises.StackQueue;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveCoding.Lab.Tests.StackQueue;

public class ValidParenthesesTests
{
    [Theory]
    [InlineData("{[()]}", true)]
    [InlineData("{[(])}", false)]
    [InlineData("((()))", true)]
    [InlineData("(", false)]
    [InlineData("", true)]
    public void Should_Validate_Parentheses(string input, bool expected)
    {
        var result = ValidParentheses.Execute(input);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Should_Return_False_For_Null()
    {
        Assert.False(ValidParentheses.Execute(null));
    }
}
