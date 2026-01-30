using LiveCoding.Lab.Core.Exercises.Strings;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveCoding.Lab.Tests.Strings
{
    public class RemoveVowelsTests
    {
        [Fact]
        public void Should_Remove_Vowels_From_String()
        {
            // Arrange
            var input = "Hello, Live Coding Lab!";
            var result = RemoveVowels.Execute(input); 
            
            Assert.Equal("Hll, Lv Cdng Lb!", result);
        }
        
        [Fact]
        public void Should_Return_Empty_When_Input_Is_Empty()
        {
            var result = RemoveVowels.Execute("");

            Assert.Equal("", result);
        }

        [Fact]
        public void Should_Work_With_Uppercase_Vowels()
        {
            var result = RemoveVowels.Execute("AEIOU are vowels");

            Assert.Equal(" r vwls", result);
        }
    }
}
