using PracticePrgs;

namespace PracticePrgsTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        StringEdit1 stred = new StringEdit1();
        Assert.AreEqual(true, stred.CheckStrings("hai", "hai"));
    }
}