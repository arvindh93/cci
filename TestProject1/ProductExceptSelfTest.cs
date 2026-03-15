namespace TestProject1;

using PracticePrgs;

[TestClass]
public class ProductExceptSelfTest
{
    [TestMethod]
    public void TestProdExSelfEx1()
    {
        /**
        Input: nums = [1,2,3,4]
        Output: [24,12,8,6]
        Example 2:
        **/

        ProductExceptSelf sut = new ProductExceptSelf();
        CollectionAssert.AreEquivalent(new int[]{24,12,8,6}, sut.ProductExSelf(new int[]{1,2,3,4}));
    }

    [TestMethod]
    public void TestProdExSelfEx2()
    {
        /**
        Input: nums = [-1,1,0,-3,3]
        Output: [0,0,9,0,0]
        **/
        ProductExceptSelf sut = new ProductExceptSelf();
        CollectionAssert.AreEquivalent(new int[]{0,0,9,0,0}, sut.ProductExSelf(new int[]{-1,1,0,-3,3}));
    }
}