using LiveCoding.Lab.Core.Exercises.Strings;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveCoding.Lab.Tests.Strings
{
    public class PalindromeCheckTests
    {
        [Fact]
        public void Should_Return_True_For_Palindrome()
        {
            Assert.True(PalindromeCheck.Execute("radar"));
        }

        [Fact]
        public void Should_Ignore_Spaces_And_Case()
        {
            Assert.True(
                PalindromeCheck.Execute("A man a plan a canal Panama"));
        }

        [Fact]
        public void Should_Return_False_For_Non_Palindrome()
        {
            Assert.False(PalindromeCheck.Execute("live coding"));
        }
    }
}
