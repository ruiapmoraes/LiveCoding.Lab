using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;

namespace LiveCoding.Lab.Core.Exercises.Strings;

public static class CountCharacterOccurrences
{
    public static Dictionary<char, int> Execute(string input) 
    {
        var result = new Dictionary<char, int>();

        if (string.IsNullOrEmpty(input))
            return result;

        foreach (var character in input)
        {
            if (result.ContainsKey(character))
                result[character]++;
            else
                result[character] = 1;
        }

        return result;
    }
}
