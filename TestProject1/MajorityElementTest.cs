using PracticePrgs;

namespace TestProject1;

[TestClass]
public class MajorityElementTest
{
    [TestMethod]
    public void MajorityElement_ShouldReturnMajorityElement()
    {
        MajorityElement me = new MajorityElement();
        int[] arr = new int[] { 3, 3, 4, 2, 4, 4, 2, 4, 4 };
        Assert.AreEqual(4, me.FindMajorityElement(arr));
    }

    [TestMethod]
    public void MajorityElement_ShouldReturnMajorityElement2()
    {
        MajorityElement me = new MajorityElement();
        int[] arr = new int[] { 3, 2, 3};
        Assert.AreEqual(3, me.FindMajorityElement(arr));
    }
    
    [TestMethod]
    public void MajorityElement_ShouldReturnMajorityElement3()
    {
        MajorityElement me = new MajorityElement();
        int[] arr = new int[] { 2,2,1,1,1,2,2};
        Assert.AreEqual(2, me.FindMajorityElement(arr));
    }
}