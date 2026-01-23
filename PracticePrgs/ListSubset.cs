namespace PracticePrgs;

public class ListSubset
{
    public List<Stack<char>> ListSubsets(Stack<char> charSet)
    {
        if (charSet.Count == 0 || charSet.Count == 1)
        {
            return new() {charSet};
        }
        //get subsets of char 0 current char
        char c = charSet.Pop();

        List<Stack<char>> subsetMinusChar = ListSubsets(charSet);
        List<Stack<char>>  result = new (subsetMinusChar);
        foreach (var set in subsetMinusChar)
        {
            Stack<char> st = new Stack<char>(set);
            st.Push(c);
            result.Add(st);
        }
        result.Add(new Stack<char>(new char[1]{c}));
        return result;
    }
}