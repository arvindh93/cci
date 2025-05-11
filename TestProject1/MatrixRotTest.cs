namespace TestProject1;

using PracticePrgs;

[TestClass]
public class MatrixRotTest{
    [TestMethod]
    public void shouldRotateMatrixArrayby90()
    {
        int[,] mat = {{1,2,3}, {4,5,6}, {7,8,9}};
        int[,] exp = {{7,4,1}, {8,5,2}, {9,6,3}};
        MatrixRotation mr = new MatrixRotation();
        mr.RotateNxN90(ref mat);
        Console.WriteLine(mat);
        AssertArrays(exp, mat);
    }

    [TestMethod]
    public void ShouldChangeMatRowColumnToZeroIfZeroPresents()
    {
        int [,] mat = {{1,0,1}, {1,3,4}, {8,9,5}};
        int [,] exp = {{0,0,0}, {1,0,4}, {8,0,5}};
        ZeroMatrix zm = new ZeroMatrix();
        zm.CheckAndAddZeroes(ref mat);
        AssertArrays(exp, mat);
    }

    public void AssertArrays(int[,] exp, int[,] act)
    {
        for(int i =  0; i < act.GetLength(0); i++) {
            for (int j = 0; j < act.GetLength(0); j++) {
                Assert.AreEqual(exp[i,j], act[i,j]);
            }
        }
    }
}