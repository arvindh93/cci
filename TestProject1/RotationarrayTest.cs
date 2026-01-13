using PracticePrgs;

namespace TestProject1;

[TestClass]
public class RotationarrayTest
{
    [TestMethod]
    public void ShouldRotateArrayByK()
    {
        RotationArray ra = new RotationArray();
        int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
        int k = 3;
        int[] expected = new int[] { 5, 6, 7, 1, 2, 3, 4 };
        ra.RotateArray(arr, k);
        CollectionAssert.AreEqual(expected, arr);
    }

    [TestMethod]
    public void ShouldRotateArrayByK2()
    {
        RotationArray ra = new RotationArray();
        int[] arr = new int[] { -1, -100, 3, 99 };
        int k = 2;
        int[] expected = new int[] { 3, 99, -1, -100 };
        ra.RotateArray(arr, k);
        CollectionAssert.AreEqual(expected, arr);
    }

    [TestMethod]
    public void ShouldRotateInplaceArrayByK()
    {
        RotationArray ra = new RotationArray();
        int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
        int k = 3;
        int[] expected = new int[] { 5, 6, 7, 1, 2, 3, 4 };
        ra.RotateArrayInPlace(arr, k);
        CollectionAssert.AreEqual(expected, arr);
    }

    [TestMethod]
    public void ShouldRotateInplaceArrayByK2()
    {
        RotationArray ra = new RotationArray();
        int[] arr = new int[] { -1, -100, 3, 99 };
        int k = 2;
        int[] expected = new int[] { 3, 99, -1, -100 };
        ra.RotateArrayInPlace(arr, k);
        CollectionAssert.AreEqual(expected, arr);
    }
}