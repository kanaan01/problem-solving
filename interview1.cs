using System;
using System.Linq;

public class Kata
{
    public static string GetStrings(string city)
    {
        var result = "";
        var counts = city
            .Where(c => char.IsLetter(c))
            .GroupBy(c => char.ToLower(c))
            .OrderBy(g => city.IndexOf(g.First(), StringComparison.InvariantCultureIgnoreCase));

        foreach (var group in counts)
        {
            result += $"{group.Key}:{new string('*', group.Count())},";
        }

        return result.TrimEnd(',');
    }
}
