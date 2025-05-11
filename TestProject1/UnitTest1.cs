using PracticePrgs;

namespace TestProject1;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        StringEdit1 stred = new StringEdit1();
        Assert.AreEqual(true, stred.CheckStrings("hai", "hai"));
    }

    [TestMethod]
    public void ShouldFaileIfBothStringsAreNotEqualMoreThanOneEdit()
    {
        StringEdit1 stred = new StringEdit1();
        Assert.AreEqual(false, stred.CheckStrings("hai", "hawai"));
    }

    [TestMethod]
    public void ShouldPassIfBothStringsAreLessThanOrEqualToOneEdit()
    {
        StringEdit1 stred = new StringEdit1();
        Assert.AreEqual(true, stred.CheckStrings("hai", "hui"));
    }

    [TestMethod]
    public void ShouldPassIfBothStringsAreLessThanOrEqualToOneEdit1()
    {
        StringEdit1 stred = new StringEdit1();
        Assert.AreEqual(true, stred.CheckStrings("pale", "ple"));
    }

    [TestMethod]
    public void ShouldPassIfBothStringsAreLessThanOrEqualToOneEdit2()
    {
        StringEdit1 stred = new StringEdit1();
        Assert.AreEqual(true, stred.CheckStrings("pale", "bale"));
    }

    [TestMethod]
    public void ShouldPassIfBothStringsAreLessThanOrEqualToOneEdit3()
    {
        StringEdit1 stred = new StringEdit1();
        Assert.AreEqual(true, stred.CheckStrings("pales", "pale"));
    }

    [TestMethod]
    public void ShouldFailIfBothStringsAreMoreThanOrEqualToOneEdit4()
    {
        StringEdit1 stred = new StringEdit1();
        Assert.AreEqual(false, stred.CheckStrings("pale", "bake"));
    }   

    [TestMethod]
    public void StringCompressShouldReturnEmptyStringIfEmptyPassed()
    {
        StringCompress stred = new StringCompress();
        Assert.AreEqual("", stred.Compress(""));
    } 

    [TestMethod]
    public void StringCompressShouldReturnCompressedStringIfValidStringPassed()
    {
        StringCompress stred = new StringCompress();
        Assert.AreEqual("a3b2c1", stred.Compress("aaabbc"));
    }

    [TestMethod]
    public void StringCompressShouldReturnCompressedStringIfValidStringPassed2()
    {
        StringCompress stred = new StringCompress();
        Assert.AreEqual("a3b2", stred.Compress("aaabb"));
    } 

    [TestMethod]
    public void StringCompressShouldReturnCompressedStringIfValidStringPassed3()
    {
        StringCompress stred = new StringCompress();
        Assert.AreEqual("a1", stred.Compress("a"));
    }      

    [TestMethod]
    public void StringCompressShouldReturnCompressedStringIfValidStringPassed4()
    {
        StringCompress stred = new StringCompress();
        Assert.AreEqual("a8", stred.Compress("aaaaaaaa"));
    }

    [TestMethod]
    public void ShouldPassStringRotation()
    {
        StringEdit1 stred = new StringEdit1();
        Assert.IsTrue(stred.IsRotation("terwa", "water"));
    }      

    [TestMethod]
    public void ShouldFailStringRotation1()
    {
        StringEdit1 stred = new StringEdit1();
        Assert.IsFalse(stred.IsRotation("terwat", "water"));
    }   

    [TestMethod]
    public void ShouldFailStringRotation3()
    {
        StringEdit1 stred = new StringEdit1();
        Assert.IsFalse(stred.IsRotation("tewra", "water"));
    }                     
}