/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

public ListNode SwapPairs(ListNode head) {
    if (head == null || head.next == null) 
        return head;

    ListNode result = head.next;
    ListNode firstNode = null;
    ListNode secondNode = null;
    ListNode previousNode = new ListNode(0);

    while (head != null && head.next != null)
    {
        firstNode = head;
        secondNode = head.next;
        firstNode.next = secondNode.next;
        secondNode.next = firstNode;

        previousNode.next = secondNode;
        previousNode = firstNode;
        head = firstNode.next;
    }

    return result;
}
