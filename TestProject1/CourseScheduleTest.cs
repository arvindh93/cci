namespace TestProject1;

using PracticePrgs;

[TestClass]
public class CourseScheduleTest
{
    [TestMethod]
    public void TestCourseWithNoCircularDep_RetursTrue()
    {
        CourseSchedule sut = new CourseSchedule();
        var result = sut.CanFinish(2, [[1,0]]);
        Assert.IsTrue(result);
    }

    /**
    Input: numCourses = 2, prerequisites = [[1,0],[0,1]]
    Output: false
    Explanation: There are a total of 2 courses to take. 
    To take course 1 you should have finished course 0, and to take course 0 you should also have finished course 1. So it is impossible.
    **/
    [TestMethod]
    public void TestCourseWithCircularDep_RetursFalse()
    {
        CourseSchedule sut = new CourseSchedule();
        var result = sut.CanFinish(2, [[1,0],[0,1]]);
        Assert.IsFalse(result);
    }
    //[[0,10],[3,18],[5,5],[6,11],[11,14],[13,1],[15,1],[17,4]]
    [TestMethod]
    public void TestCourseWithCircularDepEx2_RetursFalse()
    {
        CourseSchedule sut = new CourseSchedule();
        var result = sut.CanFinish(20, [[0,10],[3,18],[5,5],[6,11],[11,14],[13,1],[15,1],[17,4]]);
        Assert.IsFalse(result);
    }
    //[[1,4],[2,4],[3,1],[3,2]]
    [TestMethod]
    public void TestCourseWithoutCircularDepEx3_RetursTrue()
    {
        CourseSchedule sut = new CourseSchedule();
        var result = sut.CanFinish(5, [[1,4],[2,4],[3,1],[3,2]]);
        Assert.IsTrue(result);
    }
    //[[1,0],[0,2],[2,1]]
    [TestMethod]
    public void TestCourseWithCircularDepEx3_RetursFalse()
    {
        CourseSchedule sut = new CourseSchedule();
        var result = sut.CanFinish(3, [[1,0],[0,2],[2,1]]);
        Assert.IsFalse(result);
    }
}