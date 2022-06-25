// Name: Linked list cycle
// Url: https://leetcode.com/problems/linked-list-cycle/
// Level: Easy
// Method: Linked list and hashset
// Time: O(n)
// Space: O(n)

var isCycle = HasCycle(new ListNode(1, new ListNode(5, new ListNode(8, new ListNode(12)))));

Console.WriteLine("The linked list is {0}", isCycle);

bool HasCycle(ListNode head)
{
    var nodes = new HashSet<ListNode>();

    while (head != null && head.next != null)
    {
        if (nodes.Contains(head.next))
            return true;

        if (!nodes.Contains(head))
            nodes.Add(head);

        head = head.next;
    }

    return false;
}
