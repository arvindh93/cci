namespace PracticePrgs;

public class Parenthesis
{
    public HashSet<string> GetParens(int n)
    {
        if (n == 1)
        {
            return ["()"];
        }
        //get parens from prev no and add "()" to front, back and middle. 
        HashSet<string> prevResult = GetParens(n-1);
        HashSet<string> result = [];
        foreach (string p in prevResult)
        {
            result.Add(string.Concat("()", p));
            result.Add(string.Concat("(", p, ")"));
            result.Add(string.Concat(p, "()"));
        }
        
        return result;
    }
}