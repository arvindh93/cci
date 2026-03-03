namespace PracticePrgs;

public class BoolEval
{
    public Dictionary<string, int> TrueCache = new();
    public Dictionary<string, int> FalseCache = new();
    public int CountEval(string exp, bool expectedResult)
    {
        if (expectedResult)
        {
            //lookup TrueCache
            if (TrueCache.TryGetValue(exp, out int cachedCount))
            {
                return cachedCount;
            }
        } else
        {
            //lookup FalseCache
            if (FalseCache.TryGetValue(exp, out int cachedCount))
            {
                return cachedCount;
            }
        }
        exp = exp.Trim();
        if (!IsValidExpression(exp))
        {
            return 0;
        }
        if (exp.Length == 1)
        {
            bool deducedExp = (exp == "1") ? true : false;
            if (deducedExp == expectedResult)
            {
                return 1;
            }
            return 0;
        }
        int result = 0;
        for (int i = 0; i < exp.Length; i++)
        {
            if (IsOperator(exp[i]))
            {
                string left = exp[..i];
                string right = exp[(i+1)..];
                int leftTrue = CountEval(left, true);
                int rightTrue = CountEval(right, true);
                int leftFalse = CountEval(left, false);
                int rightFalse = CountEval(right, false);
                int totalOps = (leftTrue + leftFalse) * (rightTrue + rightFalse);
                int totalTrue = 0;
                if (exp[i] == '&')
                {
                    totalTrue = (leftTrue * rightTrue);
                } 
                if (exp[i] == '^')
                {
                    totalTrue = (leftTrue * rightFalse) + (rightTrue * leftFalse);
                }
                if (exp[i] == '|')
                {
                    totalTrue = (leftTrue * rightFalse) + (leftTrue * rightTrue) + (leftFalse * rightTrue);
                }
                result += (expectedResult) ? totalTrue : (totalOps - totalTrue);
            }
        }
        if (expectedResult)
        {
            TrueCache.Add(exp, result);
        } else
        {
            FalseCache.Add(exp, result);
        }
        return result;
    }

    private bool IsOperator(char c)
    {
        char[] ops = {'|', '&', '^'};
        return Array.Exists(ops, v => v == c);
    }

    private bool IsValidExpression(string exp)
    {
        //if string is empty
        if (string.IsNullOrEmpty(exp))
        {
            return false;
        }
        return true;
    }
}