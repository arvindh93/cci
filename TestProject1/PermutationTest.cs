using PracticePrgs;

namespace TestProject1;

[TestClass]
public class PermutationTest
{
    [TestMethod]
    public void PermWoDupsWithEmptyCharsReturnEmptyList()
    {
        Permutation pm = new Permutation();
        List<List<char>> actual = pm.PermuteWithoutDups([]);
        AssertArrayCollections(actual, []);
    }

    [TestMethod]
    public void PermWoDupsWithSingleChar()
    {
        Permutation pm = new Permutation();
        List<List<char>> actual = pm.PermuteWithoutDups(['a']);
        AssertArrayCollections(actual, [new List<char>{'a'}]);
    }

    [TestMethod]
    public void PermWoDupsWithTwoChars()
    {
        Permutation pm = new Permutation();
        List<List<char>> actual = pm.PermuteWithoutDups(['a', 'b']);
        AssertArrayCollections(actual, [new List<char>{'a', 'b'}, new List<char>{'b','a'}]);
    }

    [TestMethod]
    public void PermWoDupsWithThreeChars()
    {
        Permutation pm = new Permutation();
        List<List<char>> actual = pm.PermuteWithoutDups(['a', 'b','c']);
        AssertArrayCollections(actual, [
            new List<char>{'a', 'b', 'c'}, 
            new List<char>{'b', 'a', 'c'},
            new List<char>{'a', 'c', 'b'},
            new List<char>{'b', 'c', 'a'},
            new List<char>{'c', 'a', 'b'},
            new List<char>{'c', 'b', 'a'}
        ]);
    }

    static void AssertArrayCollections(IList<List<char>> actual, IList<List<char>> expected)
    {
        Assert.AreEqual(actual.Count, expected.Count);

        foreach (var exp in expected)
        {
            Assert.IsTrue(actual.Any(act => act.SequenceEqual(exp)));
        }
    }
}