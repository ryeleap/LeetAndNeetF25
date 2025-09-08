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
 */
public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        LinkedList<int> result = new LinkedList<int>();
        int carry = 0;

        ListNode curr1 = l1;
        ListNode curr2 = l2;

        while (curr1 != null && curr2 != null)
        {
            if (curr1.val + curr2.val + carry >= 10)
            {
                result.AddLast((curr1.val + curr2.val + carry) % 10);
                carry = 1;
            }
            else
            {
                result.AddLast(curr1.val + curr2.val + carry);
                carry = 0;
            }
            // Console.WriteLine(curr1.val);
            curr1 = curr1.next;
            // Console.WriteLine(curr2.val);
            curr2 = curr2.next;

            if (curr1 == null && curr2 != null)
            {
                while (curr2 != null)
                {
                    if (curr2.val + carry >= 10)
                    {
                        result.AddLast((curr2.val + carry) % 10);
                        carry = 1;
                    }
                    else
                    {
                        result.AddLast(curr2.val + carry);
                        carry = 0;
                    }
                    curr2 = curr2.next;
                }
            }
            else if (curr2 == null && curr1 != null)
            {
                while (curr1 != null)
                {
                    if (curr1.val + carry >= 10)
                    {
                        result.AddLast((curr1.val + carry) % 10);
                        carry = 1;
                    }
                    else
                    {
                        result.AddLast(curr1.val + carry);
                        carry = 0;
                    }
                    curr1 = curr1.next;
                }
            }
        }

        if (carry > 0)
        {
            result.AddLast(carry);
        }
        ListNode head = new ListNode(result.First.Value);
        ListNode currentListNode = head;
        foreach (int digit in result.Skip(1))
        {
            currentListNode.next = new ListNode(digit);
            currentListNode = currentListNode.next;
        }

        return head;
    }
}