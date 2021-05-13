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
public class Solution {
    public ListNode ReverseList(ListNode head) {
        if(head == null) return null;
        if(head.next == null) return head; // This checks to see if there is only one node in the list; if so, return the node

        // I need to grab references to currentNode, its next node, and its next next node
        // Without the reference to next next node, I will lose it once I change out the next pointer of the nextNode to its previous node
        ListNode currentNode = head;
        ListNode nextNode = head.next;
        ListNode nextNextNode = head.next?.next;
        head.next = null;

        while(nextNode != null)
        {
            nextNode.next = currentNode;
            currentNode = nextNode;
            nextNode = nextNextNode;
            nextNextNode = nextNextNode?.next;
        }

        return currentNode;
    }
}

/*
Facts/Assumptions:

1. The number of nodes in the list is the range [0, 5000]
    If the head node is null, then return null.
    If the head.next is null, then return head.
2. -5000 <= Node.val <= 5000

*/