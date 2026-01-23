using PracticePrgs;

namespace TestProject1;

[TestClass]
public class ListSubsetTest
{
    [TestMethod]
    public void ListSubsetReturnEmptyOnEmptySet()
    {
        Stack<char> charSet = new Stack<char>();
        ListSubset ls = new ListSubset();
        List<Stack<char>> actual = ls.ListSubsets(charSet);
        List<Stack<char>> expected = new() {new Stack<char>()};
        AssertArrayCollections(expected, actual);
    }

    [TestMethod]
    public void ListSubsetReturnSingleCharListOnSingleChar()
    {
        Stack<char> charSet = new Stack<char>(new char[1] {'a'});
        ListSubset ls = new ListSubset();
        List<Stack<char>> actual = ls.ListSubsets(charSet);
        List<Stack<char>> expected = new();
        expected.Add(new Stack<char>(new char[1] {'a'}));
        AssertArrayCollections(actual, expected);
    }

    [TestMethod]
    public void ListSubsetReturnSingleCharListOnTwoChar()
    {
        Stack<char> charSet = new Stack<char>(new char[] {'a', 'b'});
        ListSubset ls = new ListSubset();
        List<Stack<char>> actual = ls.ListSubsets(charSet);
        List<Stack<char>> expected = new() {new Stack<char>(new char[] {'a'}), new Stack<char>(new char[] {'b'}), new Stack<char>(new char[] {'a', 'b'})};
        AssertArrayCollections(actual, expected);
    }

    static void AssertArrayCollections(IList<Stack<char>> actual, IList<Stack<char>> expected)
    {
        Assert.AreEqual(actual.Count, expected.Count);

        foreach (var exp in expected)
        {
            Assert.IsTrue(actual.Any(act => act.SequenceEqual(exp)));
        }
    }
}