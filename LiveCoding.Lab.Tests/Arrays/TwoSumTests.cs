using System;
using System.Collections.Generic;
using System.Text;

namespace LiveCoding.Lab.Tests.Arrays;

public class TwoSumTests
{
    [Fact]
    public void Should_Return_Correct_Indices_For_Two_Sum()
    {
        // Arrange
        var nums = new[] { 2, 7, 11, 15 };
        var target = 9;
        // Act
        var result = Core.Exercises.Arrays.TwoSum.Execute(nums, target);
        // Assert
        Assert.Equal(new[] { 0, 1 }, result);
    }
    [Fact]
    public void Should_Throw_Exception_When_No_Solution()
    {
        // Arrange
        var nums = new[] { 1, 2, 3 };
        var target = 7;
        // Act & Assert
        Assert.Throws<ArgumentException>(() =>
            Core.Exercises.Arrays.TwoSum.Execute(nums, target));
    }
}
