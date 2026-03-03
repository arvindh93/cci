using PracticePrgs;

namespace TestProject1;

[TestClass]
public class BoolEvalTest
{
    [DataTestMethod]
    [DataRow("", true, 0)]
    [DataRow("", false, 0)]
    [DataRow("1", true, 1)]
    [DataRow("1", false, 0)]
    [DataRow("0", true, 0)]
    [DataRow("0", false, 1)]
    [DataRow("0|1", true, 1)]
    [DataRow("0|1", false, 0)]
    [DataRow("0&1", true, 0)]
    [DataRow("1&1", false, 0)]
    [DataRow("0|0", true, 0)]
    [DataRow("0^0", true, 0)]
    [DataRow("0^0", false, 1)]
    [DataRow("1^0|0|1", true, 3)]
    [DataRow("1^0|0|1", false, 2)]
    [DataRow("0&0&0&1^1|0", true, 10)]
    [DataRow("0&0&0&1^1|0", false, 32)]
    public void CountEval_ReturnsExpectedCount(string expression, bool expectedResult, int expectedCount)
    {
        BoolEval evaluator = new BoolEval();

        int actual = evaluator.CountEval(expression, expectedResult);

        Assert.AreEqual(expectedCount, actual);
    }
}
