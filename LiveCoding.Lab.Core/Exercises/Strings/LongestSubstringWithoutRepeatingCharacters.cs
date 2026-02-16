using System;
using System.Collections.Generic;
using System.Text;

namespace LiveCoding.Lab.Core.Exercises.Strings;

public static class LongestSubstringWithoutRepeatingCharacters
{
    public static int Execute(string input)
    {
        if (string.IsNullOrEmpty(input))
            return 0;

        //guarda o último índice de cada caractere
        var lastIndex = new Dictionary<char, int>();

        int left = 0; // início da janela
        int best = 0; // melhor resultado

        for (int right = 0; right < input.Length; right++)
        {
            char c = input[right];

            if (lastIndex.TryGetValue(c, out int prev) && prev >= left)
                left = prev + 1;

            lastIndex[c] = right;

            int windowsSize = right - left + 1;
            if (windowsSize > best)
                best = windowsSize;

        }

        return best;
    }
}

