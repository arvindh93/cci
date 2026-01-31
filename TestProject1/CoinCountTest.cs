using PracticePrgs;

namespace TestProject1;

[TestClass]
public class CoinCountTest
{
    private CoinCount _sut;
    [TestInitialize]
    public void Setup()
    {
        _sut = new CoinCount(new float[]{25,10,5,1});
    }
    
    [DataTestMethod]
    [DynamicData(nameof(AddTestData), DynamicDataSourceType.Method)]
    public void CointCountTest(int sum, int count)
    {
        
        int actual = _sut.CountDenoms(sum);
        Assert.AreEqual(count, actual);
    }

    public static IEnumerable<object[]> AddTestData()
    {
        return new[] {
            new object[] {0, 0},
            new object[] {1, 1},
            new object[] {2, 1},
            new object[] {5, 2}
        };
    }
}