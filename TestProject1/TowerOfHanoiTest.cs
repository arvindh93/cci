using PracticePrgs;

namespace TestProject1;

[TestClass]
public class TowerOfHanoiTest
{
    [TestMethod]
    public void TOHWithOneDisk()
    {
        Tower t1 = new Tower(1, new Stack<int>(new int[] {1}));
        Tower t2 = new Tower(2, new());
        Tower t3 = new Tower(3, new());

        TowerOfHanoi toh = new TowerOfHanoi();
        toh.moveDisks(1, t1, t3, t2);
        CollectionAssert.AreEquivalent(new int[] {1}, t3.GetDisksArray());
    }
    [TestMethod]
    public void TOHWithTwoDisks()
    {
        Tower t1 = new Tower(1, new Stack<int>(new int[] {2, 1}));
        Tower t2 = new Tower(2, new());
        Tower t3 = new Tower(3, new());

        TowerOfHanoi toh = new TowerOfHanoi();
        toh.moveDisks(2, t1, t3, t2);
        CollectionAssert.AreEquivalent(new int[] {1, 2}, t3.GetDisksArray());
    }
    [TestMethod]
    public void TOHWithThreeDisks()
    {
        Tower t1 = new Tower(1, new Stack<int>(new int[] {3, 2, 1}));
        Tower t2 = new Tower(2, new());
        Tower t3 = new Tower(3, new());

        TowerOfHanoi toh = new TowerOfHanoi();
        toh.moveDisks(3, t1, t3, t2);
        CollectionAssert.AreEquivalent(new int[] {1, 2, 3}, t3.GetDisksArray());
    }
    [TestMethod]
    public void TOHWithFourDisks()
    {
        Tower t1 = new Tower(1, new Stack<int>(new int[] {4, 3, 2, 1}));
        Tower t2 = new Tower(2, new());
        Tower t3 = new Tower(3, new());

        TowerOfHanoi toh = new TowerOfHanoi();
        toh.moveDisks(4, t1, t3, t2);
        CollectionAssert.AreEquivalent(new int[] {1, 2, 3, 4}, t3.GetDisksArray());
    }
    [TestMethod]
    public void TOHWithTwentyFiveDisks()
    {
        Stack<int> st1 = new();
        for (int i = 25; i > 0; i--)
        {
            st1.Push(i);
        }
        int[] expected = st1.ToArray();
        Tower t1 = new Tower(1, st1);
        Tower t2 = new Tower(2, new());
        Tower t3 = new Tower(3, new());

        TowerOfHanoi toh = new TowerOfHanoi();
        toh.moveDisks(25, t1, t3, t2);
        CollectionAssert.AreEquivalent(expected, t3.GetDisksArray());
    }
}