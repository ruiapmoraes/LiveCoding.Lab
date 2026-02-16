using LiveCoding.Lab.Core.Exercises.Strings;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveCoding.Lab.Tests.Strings;

public class GroupAnagramsTests
{
    [Fact]
    public void Should_Group_Anagrams()
    {
        var input = new[] {"eat", "tea","ate"};

        var result = GroupAnagrams.Execute(input);

        Assert.Single(result);
        Assert.Equal(3, result[0].Count);
    }
}
