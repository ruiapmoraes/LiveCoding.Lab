using System;
using System.Collections.Generic;
using System.Text;

namespace LiveCoding.Lab.Core.Exercises.Strings
{
    public static class ReverseString
    {
        public static string Execute(string input)
        {
            if (string .IsNullOrEmpty(input))            
                return input;

            var chars = input.ToCharArray();

            Array.Reverse(chars);

            return new string(chars);
        }
    }
}
