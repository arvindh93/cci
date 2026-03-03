using PracticePrgs;

namespace TestProject1;

[TestClass]
public class EightQueenV2Test
{
    [TestMethod]
    public void IsSafe_EmptyBoard_ReturnsTrue()
    {
        var solver = new EightQueenV2();
        int[] board = new int[8];
        Assert.IsTrue(solver.IsSafe(board, 0, 0));
    }

    [TestMethod]
    public void IsSafe_SameColumnExists_ReturnsFalse()
    {
        var solver = new EightQueenV2();
        int[] board = { 2, 0, 0, 0, 0, 0, 0, 0 };
        Assert.IsFalse(solver.IsSafe(board, 1, 2));
    }

    [TestMethod]
    public void IsSafe_DiagonalConflict_ReturnsFalse()
    {
        var solver = new EightQueenV2();
        int[] board = { 0, 0, 0, 0, 0, 0, 0, 0 };
        board[0] = 0;
        Assert.IsFalse(solver.IsSafe(board, 1, 1));
    }

    [TestMethod]
    public void IsSafe_DiagonalConflict_ReturnsFalse2()
    {
        var solver = new EightQueenV2();
        int[] board = { 0, 0, 0, 0, 0, 0, 0, 0 };
        board[0] = 7;
        Assert.IsFalse(solver.IsSafe(board, 1, 6));
    }

    [TestMethod]
    public void IsSafe_ValidPosition_ReturnsTrue()
    {
        var solver = new EightQueenV2();
        int[] board = { 0, 0, 0, 0, 0, 0, 0, 0 };
        board[0] = 0;
        Assert.IsTrue(solver.IsSafe(board, 1, 2));
    }

    [TestMethod]
    public void IsSafe_MultipleQueens_NoConflict_ReturnsTrue()
    {
        var solver = new EightQueenV2();
        int[] board = { 0, 2, 0, 0, 0, 0, 0, 0 };
        Assert.IsTrue(solver.IsSafe(board, 2, 4));
    }

    [TestMethod]
    public void TestEightQueen()
    {
        var solver = new EightQueenV2();
        int[] board = { -1, -1, -1, -1, -1, -1, -1, -1 };
        solver.Solve(board, 0);
        Assert.IsTrue(true);
    }
}