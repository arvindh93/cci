using PracticePrgs;

namespace TestProject1;

[TestClass]
public class ParenthesisTest
{
    [TestMethod]
    public void ParenthesisForZero()
    {
        Parenthesis p = new Parenthesis();
        HashSet<string> actual = p.GetParens(0);
        HashSet<string> expected = new HashSet<string> {};
        AssertArrayCollections(actual, expected);
    }

    [TestMethod]
    public void ParenthesisForOne()
    {
        Parenthesis p = new Parenthesis();
        HashSet<string> actual = p.GetParens(1);
        HashSet<string> expected = ["()"];
        AssertArrayCollections(actual, expected);    
    }

    [TestMethod]
    public void ParenthesisForTwo()
    {
        Parenthesis p = new Parenthesis();
        HashSet<string> actual = p.GetParens(2);
        HashSet<string> expected = ["()()", "(())"];
        AssertArrayCollections(actual, expected);    
    }

    [TestMethod]
    public void ParenthesisForThree()
    {
        Parenthesis p = new Parenthesis();
        HashSet<string> actual = p.GetParens(3);
        HashSet<string> expected = ["()()()", "(()())","()(())","(())()","((()))"];
        AssertArrayCollections(actual, expected);    
    }

    static void AssertArrayCollections(HashSet<string> actual, HashSet<string> expected)
    {
        Assert.AreEqual(actual.Count, expected.Count);

        foreach (var exp in expected)
        {
            Assert.IsTrue(actual.Any(act => act.SequenceEqual(exp)));
        }
    }
}