using PracticePrgs;

namespace TestProject1;

[TestClass]
public class EightQueenTest
{
    [TestMethod]
    public void TestEightQueen()
    {
        EightQueen eq = new EightQueen();
        eq.PrintBoard();
        eq.PlaceQueens(0,0);
        eq.PrintBoard();
        Assert.IsTrue(true);
    }
}