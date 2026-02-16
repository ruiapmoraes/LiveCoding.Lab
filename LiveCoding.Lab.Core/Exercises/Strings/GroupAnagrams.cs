using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LiveCoding.Lab.Core.Exercises.Strings;

public static class GroupAnagrams
{
    public static List<List<string>> Execute(string[] words) 
    {
        var map = new Dictionary<string, List<string>>();

        foreach (var word in words)
        {
            var key = GetKey(word);

            if (!map.ContainsKey(key))            
                map[key] = new List<string>();
            
            map[key].Add(word);
        }

        return map.Values.ToList();                                                                                                                                                                                                     
    }

    private static string GetKey(string word) 
    {
        var chars = word.ToLowerInvariant().ToCharArray();
        Array.Sort(chars);
        return new string(chars);
    }
}
