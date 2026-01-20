using PracticePrgs;

namespace TestProject1;

[TestClass]
public class JumpStepTest
{
    [TestMethod]
    public void JumptStepWithOneStep()
    {
        JumpStep js = new JumpStep();
        Assert.AreEqual(1, js.GetStepCount(1));
    }
    [TestMethod]
    public void JumptStepWithTwoSteps()
    {
        JumpStep js = new JumpStep();
        Assert.AreEqual(1, js.GetStepCount(2));
    }
    [TestMethod]
    public void JumptStepWithThreeSteps()
    {
        JumpStep js = new JumpStep();
        Assert.AreEqual(2, js.GetStepCount(3));
    }
    [TestMethod]
    public void JumptStepWithFiveSteps()
    {
        JumpStep js = new JumpStep();
        Assert.AreEqual(7, js.GetStepCount(5));
    }
}