namespace TestProject1;

using PracticePrgs;

[TestClass]
public class RottenOrangesTest
{
    [TestMethod]
    public void TestWithNoRottenOranges_ShouldReturnMinusOne()
    {
        //[[2,1,1],[1,1,0],[0,1,1]]
        // int[][] grid =
        // [
        //     [2,1,1],
        //     [1,1,0],
        //     [0,1,1]
        // ];

        int[][] grid =
        [
            [0,0,0],
            [1,1,0],
            [0,1,0]
        ];

        RottenOranges ro = new RottenOranges();
        Assert.AreEqual(-1, ro.OrangesRotting(grid));
    }
    [TestMethod]
    public void TestWithOnlyRottenOranges_ShouldReturnMinusOne()
    {
        //[[2,1,1],[1,1,0],[0,1,1]]
        // int[][] grid =
        // [
        //     [2,1,1],
        //     [1,1,0],
        //     [0,1,1]
        // ];

        int[][] grid =
        [
            [0,0,0],
            [2,2,0],
            [0,2,0]
        ];

        RottenOranges ro = new RottenOranges();
        Assert.AreEqual(0, ro.OrangesRotting(grid));
    }
    [TestMethod]
    public void TestWithOneRottenOranges1_ShouldReturnFour()
    {
        //[[2,1,1],[1,1,0],[0,1,1]]
        int[][] grid =
        [
            [2,1,1],
            [1,1,0],
            [0,1,1]
        ];

        RottenOranges ro = new RottenOranges();
        Assert.AreEqual(4, ro.OrangesRotting(grid));
    }
    [TestMethod]
    public void TestWithOneRottenOranges1_ShouldReturnMinusOne()
    {
        //[[2,1,1],[1,1,0],[0,1,1]]
        int[][] grid =
        [
            [0,2]
        ];

        RottenOranges ro = new RottenOranges();
        Assert.AreEqual(0, ro.OrangesRotting(grid));
    }
    [TestMethod]
    public void TestWithNoOragnes_ShouldReturnZero()
    {
        //[[2,1,1],[1,1,0],[0,1,1]]
        int[][] grid =
        [
            [0]
        ];

        RottenOranges ro = new RottenOranges();
        Assert.AreEqual(0, ro.OrangesRotting(grid));
    }
}