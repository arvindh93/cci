using PracticePrgs;

namespace TestProject1;

[TestClass]
public class RoboticGridTest
{
    [TestMethod]
    public void RoboticGridWithoutOffListTwoCrossTwo()
    {
        RobotGrid rg = new RobotGrid();
        Assert.IsTrue(rg.CanReach(0,0,2,2,new()));
    }

    [TestMethod]
    public void RoboticGridWithOffListTwoCrossTwoReturnFalse()
    {
        RobotGrid rg = new RobotGrid();
        Assert.IsFalse(rg.CanReach(0,0,2,2,new(){(0,1), (1,0)}));
    }

    [TestMethod]
    public void RoboticGridWithOffListTwoCrossTwoReturnFalse2()
    {
        RobotGrid rg = new RobotGrid();
        Assert.IsFalse(rg.CanReach(0,0,2,2,new(){(1,1)}));
    }
    
    [TestMethod]
    public void RobotGridWithOffListTenCrossTwelveReturnFalse()
    {
        RobotGrid rg = new RobotGrid();
        List<(int, int)> offList = new();
        //mark entire border with row = 5 and col = 5 as offlist
        for (int i = 4; i < 10; i++)
        {
            offList.Add((i, 4));
        }
        for (int j = 4; j < 12; j++)
        {
            offList.Add((4, j));
        }
        Assert.IsFalse(rg.CanReach(0,0,10,12,offList));
    }
}