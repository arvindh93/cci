namespace TestProject1;

using PracticePrgs;
/**
Example 1:

Input: lists = [[1,4,5],[1,3,4],[2,6]]
Output: [1,1,2,3,4,4,5,6]
Explanation: The linked-lists are:
[
  1->4->5,
  1->3->4,
  2->6
]
merging them into one sorted linked list:
1->1->2->3->4->4->5->6
Example 2:

Input: lists = []
Output: []
Example 3:

Input: lists = [[]]
Output: []
**/
[TestClass]
public class TestKSortedList
{
    public ListNode? ConvertIntArrayToListNode(int[] intArr)
    {
        if (intArr.Length == 0)
        {
            return null;
        }
        ListNode head = new ListNode();
        head.val = intArr[intArr.Length - 1];
        head.next = null;
        for (int i = intArr.Length - 2; i >= 0; i--)
        {
            ListNode node = new ListNode();
            node.val = intArr[i];
            node.next = head;
            head = node;
        }

        return head;
    }

    [TestMethod]
    public void TestKSortedListEx1()
    {
        KSortedList sut = new KSortedList();
        ListNode ln1 = new ListNode();
        ListNode[] lnList = [
            ConvertIntArrayToListNode(new int[]{1,4,5}),
            ConvertIntArrayToListNode(new int[]{1,3,4}),
            ConvertIntArrayToListNode(new int[]{2,6})
        ];
        ListNode expected = ConvertIntArrayToListNode(new int[]{1,1,2,3,4,4,5,6});
        ListNode actual = sut.MergeKLists(lnList);
        CustomAssert.AssertListNode(expected, actual);

    }

    [TestMethod]
    public void TestKSortedListEx2()
    {
        KSortedList sut = new KSortedList();
        ListNode ln1 = new ListNode();
        ListNode[] lnList = [ln1];
        ListNode actual = sut.MergeKLists(lnList);
        CustomAssert.AssertListNode(ln1, actual);

    }

    [TestMethod]
    public void TestKSortedListEx3()
    {
        KSortedList sut = new KSortedList();
        ListNode ln1 = new ListNode();
        ListNode[] lnList = [];
        ListNode actual = sut.MergeKLists(lnList);
        CustomAssert.AssertListNode(null, actual);

    }
}