// Name: Reorder list
// Url: https://leetcode.com/problems/reorder-list/
// Level: Medium
// Method: stack
// Time: O(n)
// Space: O(n)
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
void ReorderList(ListNode head)
{
    var stack = new Stack<ListNode>();
    var node = head;

    while (node != null)
    {
        stack.Push(node);
        node = node.next;
    }

    node = head;

    while (node != null && node.next != stack.Peek())
    {
        var aux = stack.Pop();
        aux.next = node.next;
        node.next = aux;
        node = aux.next;
        stack.Peek().next = null;
    }
}
