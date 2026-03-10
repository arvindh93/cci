namespace PracticePrgs;

public class Parenthesis
{
    public HashSet<string> GetParens(int n)
    {
        if (n == 0)
        {
            return [];
        }
        if (n == 1)
        {
            return ["()"];
        }
        //get parens from prev no and add "()" to front, back and middle. 
        HashSet<string> prevResult = GetParens(n-1);
        HashSet<string> result = [];
        foreach (string p in prevResult)
        {
            //loop each string 
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] == '(')
                {
                    result.Add(p[..(i+1)] + "()" + p[(i+1)..]);
                }
            }
            result.Add("()" + p);
        }
        
        return result;
    }
}