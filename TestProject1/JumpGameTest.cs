using PracticePrgs;

namespace TestProject1;

[TestClass]
public class JumpGameTest
{
    [TestMethod]
    public void JumpGame_ShouldReturnTrue()
    {
        JumpGame jg = new JumpGame();
        int[] arr = new int[5] {2,3,1,1,4};
        Assert.IsTrue(jg.Jump(arr));
    }
    
    [TestMethod]
    public void JumpGame_ShouldReturnFalse()
    {
        JumpGame jg = new JumpGame();
        int[] arr = new int[5] {3,2,1,0,4};
        Assert.IsFalse(jg.Jump(arr));
    }
    [TestMethod]
    public void JumpGame_ShouldReturnTrue2()
    {
        JumpGame jg = new JumpGame();
        int[] arr = new int[2] {1, 2};
        Assert.IsTrue(jg.Jump(arr));
    }
}