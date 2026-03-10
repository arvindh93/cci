namespace TestProject1;

using PracticePrgs;

[TestClass]
public class TestNumIsland
{
    [TestMethod]
    public void GridWithAllZeros_ShouldReturn0()
    {
        // int[,] grid =
        // {
        //     {1,1,1,1,0},
        //     {1,1,0,1,0},
        //     {1,1,0,0,0},
        //     {0,0,0,0,0}
        // };

        char[][] grid =
        {
            new char[] {'0','0','0','0','0'},
            new char[] {'0','0','0','0','0'},
            new char[] {'0','0','0','0','0'},
            new char[] {'0','0','0','0','0'}
        };

        NumIsland ni = new NumIsland();
        Assert.AreEqual(0, ni.NumIslands(grid));
    }

    [TestMethod]
    public void GridWithOneIsland_ShouldReturn1()
    {
        // int[,] grid =
        // {
        //     {1,1,1,1,0},
        //     {1,1,0,1,0},
        //     {1,1,0,0,0},
        //     {0,0,0,0,0}
        // };

        char[][] grid =
        {
            new char[] {'1','1','1','1','0'},
            new char[] {'0','0','1','0','0'},
            new char[] {'1','1','1','0','0'},
            new char[] {'0','0','0','0','0'}
        };

        NumIsland ni = new NumIsland();
        Assert.AreEqual(1, ni.NumIslands(grid));
    }
    [TestMethod]
    public void GridWithThreeIsland_ShouldReturn3()
    {
        // int[,] grid =
        // {
        //     {1,1,1,1,0},
        //     {1,1,0,1,0},
        //     {1,1,0,0,0},
        //     {0,0,0,0,0}
        // };

        char[][] grid =
        {
            new char[] {'1','1','1','1','0'},
            new char[] {'1','1','0','0','0'},
            new char[] {'0','0','1','0','0'},
            new char[] {'0','0','0','1','1'}
        };

        NumIsland ni = new NumIsland();
        Assert.AreEqual(3, ni.NumIslands(grid));
    }
}