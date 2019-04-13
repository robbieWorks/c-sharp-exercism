using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        try
        {
            var result = new Dictionary<char, int>
            {
                ['A'] = 0,
                ['C'] = 0,
                ['G'] = 0,
                ['T'] = 0
            };

            foreach (var c in sequence)
            {
                result[c]++;
            }

            return result;
        }
        catch
        {
            throw new ArgumentException();
        }
    }
}