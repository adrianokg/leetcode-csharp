/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
 
public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
    if (headA == null || headB == null)
        return null;

    List<ListNode> visited = new List<ListNode>();

    while(headA != null)
    {
        visited.Add(headA);
        headA = headA.next;
    }

    while(headB != null)
    {
        if (visited.Contains(headB))
            return headB;

        headB = headB.next;
    }

    return null;
}
