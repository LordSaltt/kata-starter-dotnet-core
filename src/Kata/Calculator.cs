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

        var elements = s.Split(new []{"\n",","},StringSplitOptions.None).Select(int.Parse);
        return elements.Sum();
    }
}