namespace TestProject1;

using PracticePrgs;

[TestClass]
public class VisiblePeopleTest
{
    [TestMethod]
    public void TestWithOnlyOnePerson_shoudlReturnZero()
    {
        VisiblePeople sut = new VisiblePeople();
        CollectionAssert.AreEquivalent(new int[] {0},sut.CanSeePersonsCount([5]));
    }
    //Input: heights = [10,6,8,5,11,9]
    //Output: [3,1,2,1,1,0]
    [TestMethod]
    public void TestWithDiffHieghtEx1()
    {
        VisiblePeople sut = new VisiblePeople();
        CollectionAssert.AreEquivalent(new int[] {3,1,2,1,1,0},sut.CanSeePersonsCount([10,6,8,5,11,9]));
    }

    //Input: heights = [5,1,2,3,10]
    //Output: [4,1,1,1,0]
    [TestMethod]
    public void TestWithDiffHieghtEx2()
    {
        VisiblePeople sut = new VisiblePeople();
        CollectionAssert.AreEquivalent(new int[] {4,1,1,1,0},sut.CanSeePersonsCount([5,1,2,3,10]));
    }

    [TestMethod]
    public void TestWithDiffHieghtEx3()
    {
        VisiblePeople sut = new VisiblePeople();
        CollectionAssert.AreEquivalent(new int[] {1,0},sut.CanSeePersonsCount([5,3]));
    }
}