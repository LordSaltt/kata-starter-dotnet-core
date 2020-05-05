public class Calculator
{
    public int Add(string s = "")
    {
        if (string.IsNullOrEmpty(s))
        {
            return 0;            
        }

        var array = s.Split(",");
        var sum = 0;
        foreach (var item in array)
        {
            sum += int.Parse(item);
        }
        return sum;
    }
}