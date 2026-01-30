using System;
using System.Collections.Generic;
using System.Text;

namespace LiveCoding.Lab.Core.Exercises.Strings
{
    public static class PalindromeCheck
    {
        public static bool Execute(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            //remove spaces and convert to lowercase
            var clean = input
                .Replace(" ", "")
                .ToLowerInvariant();

            int left = 0;
            int right = clean.Length - 1;

            while (left < right)
            {
                if (clean[left] != clean[right])
                    return false;

                left++;
                right--;
            }

            return true;
        }
    }
}
