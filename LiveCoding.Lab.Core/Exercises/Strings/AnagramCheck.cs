using System;
using System.Collections.Generic;
using System.Text;

namespace LiveCoding.Lab.Core.Exercises.Strings;

public static class AnagramCheck
{
    public static bool Execute(string first, string second)
    {
        if (first is null || second is null)
            return false;

        var s1 = Normalize(first);
        var s2 = Normalize(second);

        if (s1.Length != s2.Length)
            return false;

        var counts = new Dictionary<char, int>();

        foreach (var character in s1)
        {
            counts[character] = counts.TryGetValue(character, out var value)
                ? value + 1
                : 1;
        }

        foreach (var character in s2)
        {
            if (!counts.TryGetValue(character, out var value))
                return false;

            if (value == 1)
                counts.Remove(character);
            else
                counts[character] = value - 1;
        }

        return counts.Count == 0;
    }

    private static string Normalize(string input) =>
        new string(
            input
                    .Where(char.IsLetterOrDigit)
                    .Select(char.ToUpperInvariant)
                    .ToArray()
            );
}
