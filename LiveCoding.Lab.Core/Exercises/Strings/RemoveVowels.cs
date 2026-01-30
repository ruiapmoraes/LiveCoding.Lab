using System;
using System.Collections.Generic;
using System.Text;

namespace LiveCoding.Lab.Core.Exercises.Strings
{
    public static class RemoveVowels
    {
        public static string Execute(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            var vowels = "aeiouAEIOU";

            var result = new System.Text.StringBuilder();

            foreach (var c in input)
            {
                if(!vowels.Contains(c))
                    result.Append(c);
            }

            #region Trecho de resolução avançado
            /*
               HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u',
                                                          'A', 'E', 'I', 'O', 'U' };
               StringBuilder result = new StringBuilder();
               foreach (char c in input)
               {
                   if (!vowels.Contains(c))
                   {
                       result.Append(c);
                   }
               }
               */ 
            #endregion

            return result.ToString();
        }
    }
}
