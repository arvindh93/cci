using PracticePrgs;
using System.Linq;

namespace TestProject1;

[TestClass]
public class MergeIntervalsTest
{
    private static bool AreJaggedEqual(int[][] expected, int[][] actual)
    {
        if (expected == null || actual == null) return expected == actual;
        if (expected.Length != actual.Length) return false;
        for (int i = 0; i < expected.Length; i++)
        {
            if (!expected[i].SequenceEqual(actual[i])) return false;
        }
        return true;
    }

    [TestMethod]
    public void MergeIntervals_NoOverlap_ReturnsSame()
    {
        MergeIntervals mi = new MergeIntervals();
        int[][] input = new int[][] {
            new int[] {1,2},
            new int[] {3,4},
            new int[] {5,6}
        };

        int[][] expected = new int[][] {
            new int[] {1,2},
            new int[] {3,4},
            new int[] {5,6}
        };

        int[][] actual = mi.Merge(input);
        Assert.IsTrue(AreJaggedEqual(expected, actual));
    }

    [TestMethod]
    public void MergeIntervals_SimpleOverlap_Merges()
    {
        MergeIntervals mi = new MergeIntervals();
        int[][] input = new int[][] {
            new int[] {1,3},
            new int[] {2,6},
            new int[] {8,10},
            new int[] {15,18}
        };

        int[][] expected = new int[][] {
            new int[] {1,6},
            new int[] {8,10},
            new int[] {15,18}
        };

        int[][] actual = mi.Merge(input);
        Assert.IsTrue(AreJaggedEqual(expected, actual));
    }

    [TestMethod]
    public void MergeIntervals_ContainedIntervals_MergesProperly()
    {
        MergeIntervals mi = new MergeIntervals();
        int[][] input = new int[][] {
            new int[] {1,4},
            new int[] {2,3}
        };

        int[][] expected = new int[][] {
            new int[] {1,4}
        };

        int[][] actual = mi.Merge(input);
        Assert.IsTrue(AreJaggedEqual(expected, actual));
    }
    [TestMethod]
    public void MergeIntervals_ContainedIntervals_MergesProperly2()
    {
        //[2,3],[4,5],[6,7],[8,9],[1,10]
        MergeIntervals mi = new MergeIntervals();
        int[][] input = new int[][] {
            new int[] {2,3},
            new int[] {4,5},
            new int[] {6,7},
            new int[] {8,9},
            new int[] {1,10},
        };

        int[][] expected = new int[][] {
            new int[] {1,10}
        };

        int[][] actual = mi.Merge(input);
        Assert.IsTrue(AreJaggedEqual(expected, actual));
    }
}
