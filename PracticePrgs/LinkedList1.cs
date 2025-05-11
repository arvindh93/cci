using System.Diagnostics;

namespace PracticePrgs{
    public class LinkedList1 {
        public Node? head = null;

        public void Append(int data)
        {
            if (this.head is null)
            {
                this.head = new(data);
                return;
            }
            Node? trav = this.head;
            while (trav.next != null)
            {
                trav = trav.next;
            }
            trav.next = new(data);
        }

        public void Print()
        {
            Node trav = head;
            while(trav != null)
            {
                Console.Write(trav.data.ToString() + ((trav.next is null) ? "" : "->"));
                trav = trav.next;
            }
        }
        
        public List<int> GetAsList()
        {
            List<int> result = [];
            Node trav = this.head;
            while (trav != null)
            {
                result.Add(trav.data);
                trav = trav.next;
            }
            return result;
        }

        public void RemoveDuplicates()
        {
            List<int> dlist = [];
            Node trav = this.head;
            if (trav != null)
            {
                if (trav.next == null)
                {
                    return;
                }
                dlist.Add(trav.data);
            }
            Node prev = trav;
            trav = trav.next;
            while(trav != null)
            {
                //check if next value is in list
                //remove if it already exists
                if (dlist.Contains(trav.data)) {
                    prev.next = trav.next;
                } else {
                    dlist.Add(trav.data);
                    prev = trav;
                }
                trav = trav.next;
            }
        }

        public int GetKthElementToLast(int k)
        {
            // take 2 runners - make 1st runner travers till it reaches kth element, then move both till it reaches last element
            // once last element reached by 1st runner (ahead one) return element form 2nd pointer
            Node right = this.head;
            Node left = this.head;
            int i = 1;
            while (i < k)
            {
                if (right.next == null)
                {
                    Console.Write("Linked list has elements less than k");
                    return 0;
                }
                right = right.next;
                i++;
            }
            while(right.next != null)
            {
                right = right.next;
                left = left.next;
            }
            Console.WriteLine(left.data);
            return left.data;
        }

        public void RemoveMiddleNode()
        {
            //take 2 runners - advance 1 runner with 2 elements and other with one element
            //When 1st runner reaches end of linked list, 1st runner will be in middle node
            Node fast = this.head;
            Node slow = this.head;
            while (slow.next != null)
            {
                if (slow.next.next != null)
                {
                    slow = slow.next.next;
                } else {
                    slow = slow.next;
                }
                fast = fast.next;
            }
            if (slow == fast || fast.next == slow)
            {
                Console.Write("Not more than 2 nodes");
                return;
            }
            //remove fast node
            slow = this.head;
            while (slow.next != fast)
            {
                slow = slow.next;
            }
            slow.next = fast.next;
        }
    }
    public record Node (int data) {
        public Node? next = null;
    }
}