/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }


 You are given an array of k linked-lists lists, each linked-list is sorted in ascending order.

Merge all the linked-lists into one sorted linked-list and return it.

 

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
 */
namespace PracticePrgs;

public class ListNode {
    public int val;
    public ListNode? next;
    public ListNode(int val=0, ListNode? next=null) {
        this.val = val;
        this.next = next;
    }
}
public class KSortedList {
    
    public ListNode MergeKLists(ListNode[] lists) {
        Stack<int> stk1 = [];
        Stack<int> stk2 = [];
        if (lists.Length == 0)
        {
            return null;
        }
        //add a monotonic stack and later pop all to create a new list
        foreach (ListNode lst in lists)
        {
            ListNode itr = lst;

            //loop through each list
            while (itr != null)
            {
                int val = itr.val;

                //this happens only for first val
                //move vals greater than val from stk1 to stk2
                if (itr == lst)
                {
                    while (stk1.Count != 0 && stk1.Peek() > val)
                    {
                        stk2.Push(stk1.Pop());  
                    }
                }

                while (stk2.Count!= 0 && stk2.Peek() < val)
                {
                    stk1.Push(stk2.Pop());
                }
                
                stk1.Push(val);

                itr = itr.next;
            }
            //add stk2 to stk1
            if (stk2.Count > 0)
            {
                while (stk2.Count > 0)
                {
                    stk1.Push(stk2.Pop());
                }
            }
        }


        //convert stk1 to list
        ListNode result = null;
        while (stk1.Count > 0)
            {
                ListNode node = new ListNode();
                node.val = stk1.Pop();
                node.next = result;
                result = node;
            }
        return result;
    }
}