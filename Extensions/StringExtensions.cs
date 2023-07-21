﻿using ScratchScript.Helpers;

namespace ScratchScript.Extensions;

public static class StringExtensions
{
    public static string RemoveEmptyLines(this string s) => string.Join('\n', s.Split("\n").Where(x => !string.IsNullOrEmpty(x)));
    public static string RemoveQuotes(this string s) => s.Replace("\"", "");
    public static string Format(this object o, bool rawColor = true)
    {
        return o switch
        {
            bool b => $"\"{b.ToString().ToLower()}\"",
            ScratchColor c => rawColor ? $"#{c.Value.ToLower()}": $"\"0x{c.Value.ToLower()}\"",
            _ => o.ToString()
        };
    }
}