namespace TestProject1;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticePrgs;
internal static class CustomAssert
{
    public static void AssertListNode(ListNode? expected, ListNode? actual)
    {
        if (expected == null && actual == null)
        {
            return;
        }
        while (expected != null && actual != null)
        {
            if (expected.val != actual.val)
            {
                throw new AssertFailedException($"Values mismatch at expected - {expected.val} against actual {actual.val} ");
            }
            expected = expected.next;
            actual = actual.next;
        }
        if ((expected == null && actual != null) || (expected != null && actual == null))
        {
            string msg = (expected is null) ? "expected is null" : "actual is null";
            throw new AssertFailedException($"Assertion failed one {msg}");
        }

        return;
    }
}