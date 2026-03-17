namespace TestProject1;

using PracticePrgs;
/**
Example 1:

Input: nums = [1,1,1], k = 2
Output: 2
Example 2:

Input: nums = [1,2,3], k = 3
Output: 2
**/
[TestClass]
public class MaxSumSubArrayTest
{
    [TestMethod]
    public void TestMaxSubArrayEx1()
    {
        MaxSumSubArray sut = new MaxSumSubArray();
        Assert.AreEqual(2, sut.SubarraySum(new int[]{1,1,1}, 2));
    }
    [TestMethod]
    public void TestMaxSubArrayEx2()
    {
        MaxSumSubArray sut = new MaxSumSubArray();
        Assert.AreEqual(2, sut.SubarraySum(new int[]{1,2,3}, 3));
    }
}