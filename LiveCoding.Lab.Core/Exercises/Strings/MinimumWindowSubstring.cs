using System;
using System.Collections.Generic;
using System.Text;

namespace LiveCoding.Lab.Core.Exercises.Strings;

public static class MinimumWindowSubstring
{
    public static string Execute(string s, string t)
    {
        if(string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t))
            return string.Empty;

        // Necessário: contagem de chars em t
        var need = new Dictionary<char, int>();
        foreach (var c in t)
        {
            need[c] = need.TryGetValue(c, out var v) ? v + 1 : 1;
        }

        int required = need.Count; // Quantos chars únicos precisamos encontrar

        // Janela atual: contagem de chars revelantes atendidos
        var window = new Dictionary<char, int>();
        int formed = 0;

        int left = 0;

        int bestLen = int.MaxValue;
        int bestStart = 0;

        for (int right = 0; right < s.Length; right++)
        {
            char c = s[right];

            if (need.ContainsKey(c))
            {
                window[c] = window.TryGetValue(c, out var w) ? w + 1 : 1;

                if (window[c] == need[c])
                    formed++;
            }

            // Se janela atende todos os chars necessários, tenta encolher
            while (left <= right && formed == required)
            {
                int len = right - left + 1;
                if (len < bestLen)
                {
                    bestLen = len;
                    bestStart = left;
                }

                char leftChar = s[left];

                if (need.ContainsKey(leftChar))
                {
                    window[leftChar]--;

                    if (window[leftChar] < need[leftChar])
                        formed--;
                }

                left++;
            }
        }
        return bestLen == int.MaxValue
           ? string.Empty
           : s.Substring(bestStart, bestLen);
    }
}
