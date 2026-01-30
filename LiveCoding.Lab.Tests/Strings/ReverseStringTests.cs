using LiveCoding.Lab.Core.Exercises.Strings;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveCoding.Lab.Tests.Strings
{
    public class ReverseStringTests
    {
        [Fact]
        public void Should_Reverse_String_Correctly()
        {
            // Arrange
            var input = "Hello, Live Coding Lab!";
            var result = ReverseString.Execute(input);

            Assert.Equal("!baL gnidoC eviL ,olleH", result);
        }

        [Fact]
        public void Should_Return_Empty_When_Input_Is_Empty()
        {
            var result = ReverseString.Execute("");
            Assert.Equal("", result);
        }
    }
}
