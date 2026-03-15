/**
Input: nums = [2,3,-2,4]
Output: 6
Explanation: [2,3] has the largest product 6.
Example 2:

Input: nums = [-2,0,-1]
Output: 0
Explanation: The result cannot be 2, because [-2,-1] is not a subarray.
*/
namespace TestProject1;

using PracticePrgs;

[TestClass]
public class MaxProductTest
{
    [TestMethod]
    public void TestMAxProductEx1()
    {
        int[] nums = [2,3,-2,4];
        MaxProduct mp = new MaxProduct();
        Assert.AreEqual(6, mp.GetMaxProduct(nums));
    }
    [TestMethod]
    public void TestMAxProductEx2()
    {
        int[] nums = [-2,0,-1];
        MaxProduct mp = new MaxProduct();
        Assert.AreEqual(0, mp.GetMaxProduct(nums));
    }
    [TestMethod]
    public void TestMAxProductEx3()
    {
        int[] nums = [0];
        MaxProduct mp = new MaxProduct();
        Assert.AreEqual(0, mp.GetMaxProduct(nums));
    }
    [TestMethod]
    public void TestMAxProductEx4()
    {
        int[] nums = [-4,-3];
        MaxProduct mp = new MaxProduct();
        Assert.AreEqual(12, mp.GetMaxProduct(nums));
    }
}