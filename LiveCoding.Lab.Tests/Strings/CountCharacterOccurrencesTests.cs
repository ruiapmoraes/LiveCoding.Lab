using LiveCoding.Lab.Core.Exercises.Strings;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveCoding.Lab.Tests.Strings;

public class CountCharacterOccurrencesTests
{
    [Fact]
    public void Should_Count_Character()
    {
        var result = CountCharacterOccurrences.Execute("banana");

        Assert.Equal(1,result['b']);
        Assert.Equal(3, result['a']);
        Assert.Equal(2, result['n']);
    }

    [Fact]
    public void Should_Return_Empty_For_Empty_String() 
    {
        var result = CountCharacterOccurrences.Execute("");

        Assert.Empty(result);
    }
}
