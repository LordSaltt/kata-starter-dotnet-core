using System;
using System.Linq;

public class Calculator
{
    public int Add(string s = "")
    {
        
        if (string.IsNullOrEmpty(s))
        {
            return 0;            
        }

        var delimiters = new[] {"\n", ","};
        if (s.Contains("//"))
        {
            var splitText = s.Split("\n");
            
            delimiters = new[] {splitText[0].Replace("/", "")};
            s = splitText[1];
        }

        var elements = s.Split(delimiters,StringSplitOptions.None).Select(int.Parse).ToList();

        var negatives = elements.Where(x => x < 0);
        if (negatives.Any(x=> x <0) )
        {
            throw new Exception("negatives not allowed: " + string.Join(",",negatives));
        }
        
        return elements.Sum();
    }
}